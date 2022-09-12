using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {

        BindingList<CarReport> listPerson = new BindingList<CarReport>();
        //設定情報保存用オブジェクト
        Settings settings = Settings.getInstance();
        public Form1() {
            InitializeComponent();
            dgv.DataSource = listPerson;
            
        }
        
        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        
        //追加ボタンが押された時の処理
        private void btAddition_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(cbRecorder.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }
            CarReport carReport = GetCarReport();
            listPerson.Add(carReport);
            Check();
            EnabledCheck();
            setcbRecorder(cbRecorder.Text);
            setcbCarName(cbCarName.Text);

        }

        private CarReport GetCarReport() {
            return new CarReport {
                Date = dtpTime.Value,
                Auther = cbRecorder.Text,
                CarName = cbCarName.Text,
                Maker = GetRadioButtonMakerGroup(),
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
        }
        
        private void btPictureOpen_Click_1(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }
        
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }
        
        private void btModify_Click(object sender, EventArgs e) {
            var getIndex = dgv.CurrentRow.Index;

            listPerson[getIndex].Date = dtpTime.Value;
            listPerson[getIndex].Auther = cbRecorder.Text;
            listPerson[getIndex].CarName = cbCarName.Text;
            listPerson[getIndex].Maker = GetRadioButtonMakerGroup();
            listPerson[getIndex].Report = tbReport.Text;
            listPerson[getIndex].Picture = pbPicture.Image;

            dgv.Refresh();
        }
       
        private void groupCheckBoxAllClear() {
            rbToyota.Checked = false;
            rbNissann.Checked = false;
            rbHonda.Checked = false;
            rbSubaru.Checked = false;
            rbOutsideCar.Checked = false;
            rbOther.Checked = false;

        }
       
        private CarReport.MakerGroup GetRadioButtonMakerGroup() {
            CarReport.MakerGroup selectedMakerGroup = CarReport.MakerGroup.その他;
            if (rbToyota.Checked) {
                return CarReport.MakerGroup.トヨタ;
            }
            if (rbNissann.Checked) {
                return CarReport.MakerGroup.日産;
            }
            if (rbHonda.Checked) {
                return CarReport.MakerGroup.ホンダ;
            }
            if (rbSubaru.Checked) {
                return CarReport.MakerGroup.スバル;
            }
            if (rbOutsideCar.Checked) {
                return CarReport.MakerGroup.外国車;
            }
            if (rbOther.Checked) {
                return CarReport.MakerGroup.その他;
            }
            return selectedMakerGroup;
        }
        
        private void RadioButtonCheck(int getIndex) {

            switch (listPerson[getIndex].Maker) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissann.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbOutsideCar.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbToyota.Checked = true;
                    break;
                default:
                    break;
            }
        }
       
        private void dgv_Click(object sender, EventArgs e) {
            if (dgv.CurrentRow == null) return;
            var getIndex = dgv.CurrentRow.Index;

            dtpTime.Value = listPerson[getIndex].Date;
            cbRecorder.Text = listPerson[getIndex].Auther;
            cbCarName.Text = listPerson[getIndex].CarName;
            tbReport.Text = listPerson[getIndex].Report;
            pbPicture.Image = listPerson[getIndex].Picture;

            groupCheckBoxAllClear();
            RadioButtonCheck(getIndex);
        }
        
        private void btDelete_Click(object sender, EventArgs e) {
            var getIndex = dgv.CurrentRow.Index;
            listPerson.RemoveAt(getIndex);
            Check();
        }
       
        private void Check() {
            EnabledCheck();
        }
        
        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                cbCarName.Items.Clear();
                cbRecorder.Items.Clear();
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listPerson = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgv.DataSource = null;
                        dgv.DataSource = listPerson;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }

            }
        }
       
        private void btSave_Click(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listPerson);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                foreach (var item in listPerson.Select(a => a.CarName)) {
                    setcbCarName(item);
                }
            }
            EnabledCheck();
        }
        
        private void setcbRecorder(string auther) {
            if (!cbRecorder.Items.Contains(auther)) {
                //まだ登録されていない処理
                cbRecorder.Items.Add(auther);
            }
        }
       
        private void setcbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                //まだ登録されていない処理
                cbCarName.Items.Add(carname);
            }
        }
        
        //マスク処理
        private void EnabledCheck() {

            btModify.Enabled = btDelete.Enabled = btPictureDelete.Enabled = listPerson.Count() > 0 ? true : false;
        }
        
        //開く
        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                cbCarName.Items.Clear();
                cbRecorder.Items.Clear();
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listPerson = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgv.DataSource = null;
                        dgv.DataSource = listPerson;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }

            }
        }
       
        //保存
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listPerson);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                foreach (var item in listPerson.Select(a => a.CarName)) {
                    setcbCarName(item);
                }
            }
            EnabledCheck();
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //シリアル化
            using (var write = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(write, settings);
            }
        }
        private void Form1_Load(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202214DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202214DataSet.CarReportDB);

            EnabledCheck();//マスク処理呼び出し
            //逆シリアル化
            try {
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception) {
            }    
        }

        //色設定
        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                BackColor = colorDialog1.Color;//背景変更
                settings.MainFormColor = colorDialog1.Color.ToArgb(); 

            }
        }
       
        //終了
        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);

            }
        }

        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202214DataSet);

        }
    }
}
