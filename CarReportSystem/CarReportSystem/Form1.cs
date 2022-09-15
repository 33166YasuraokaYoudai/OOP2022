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


        
        //設定情報保存用オブジェクト
        Settings settings = Settings.getInstance();
        public Form1() {
            InitializeComponent();
            carReportDBDataGridView.RowsDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            carReportDBDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Yellow;
            //列の幅を自動変更
            carReportDBDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //行の幅を自動変更
            carReportDBDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            DataRow newRow = infosys202214DataSet.CarReportDB.NewRow();
            newRow[1] = dtpTime.Value;
            newRow[2] = cbRecorder.Text;
            newRow[3] = GetRadioButtonMakerGroup();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbPicture.Image);

            //データセットへ新しいレコードを追加
            infosys202214DataSet.CarReportDB.Rows.Add(newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update(this.infosys202214DataSet.CarReportDB);
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
       
        //クリア
        private void btClear_Click(object sender, EventArgs e) {

            dtpTime.Text = null;
            cbRecorder.Text = null;
            cbCarName.Text = null;
            groupCheckBoxAllClear();
            tbReport.Text = null;
            pbPicture.Image = null;
        }

        private void MakerCheckDB() {
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "トヨタ") {
                rbToyota.Checked = true;
            }
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "日産") {
                rbNissann.Checked = true;
            }
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "ホンダ") {
                rbHonda.Checked = true;
            }
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "スバル") {
                rbSubaru.Checked = true;
            }
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "外国車") {
                rbOutsideCar.Checked = true;
            }
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "その他") {
                rbOther.Checked = true;
            }
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
        private void EnabledCheck() {

            btUpdate.Enabled = btAddition.Enabled = btClear.Enabled = btDelete.Enabled = 更新ToolStripMenuItem.Enabled = carReportDBDataGridView.RowCount > 0 ? true : false;
            

           
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //シリアル化
            using (var write = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(write, settings);
            }
        }
        private void Form1_Load(object sender, EventArgs e) {
            EnabledCheck();
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
        

        //DB接続
        private void btConect_Click(object sender, EventArgs e) {
            
            this.carReportDBTableAdapter.Fill(this.infosys202214DataSet.CarReportDB);
            for (int i = 0; i < carReportDBDataGridView.Rows.Count; i++) {
                setcbRecorder(carReportDBDataGridView.Rows[i].Cells[2].Value.ToString());
                setcbCarName(carReportDBDataGridView.Rows[i].Cells[4].Value.ToString());
                
            }
            EnabledCheck();
        }

        private void carReportDBDataGridView_Click(object sender, EventArgs e) {
            if (carReportDBDataGridView.CurrentRow == null)
                return;
            //データグリッドビューの選択レコードを各テキストボックスへ設定
            dtpTime.Text = carReportDBDataGridView.CurrentRow.Cells[1].Value.ToString();
            cbRecorder.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString();
            MakerCheckDB();
            cbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString();
            
            if (!(carReportDBDataGridView.CurrentRow.Cells[6].Value is DBNull))
                pbPicture.Image = ByteArrayToImage((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);
            else
                pbPicture.Image = null;

        }

        //更新
        private void btUpdate_Click(object sender, EventArgs e) {

            carReportDBDataGridView.CurrentRow.Cells[1].Value = dtpTime.Value;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbRecorder.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = GetRadioButtonMakerGroup();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);

            //データベースに保存
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202214DataSet);
            
            for (int i = 0; i < carReportDBDataGridView.Rows.Count; i++) {
                setcbRecorder(carReportDBDataGridView.Rows[i].Cells[2].Value.ToString());
                setcbCarName(carReportDBDataGridView.Rows[i].Cells[4].Value.ToString());

            }

        }
        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        //エラー回避
        private void carReportDBDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void 接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.carReportDBTableAdapter.Fill(this.infosys202214DataSet.CarReportDB);

        }

        private void 更新ToolStripMenuItem_Click(object sender, EventArgs e) {
            
            carReportDBDataGridView.CurrentRow.Cells[1].Value = dtpTime.Value;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbRecorder.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = GetRadioButtonMakerGroup();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);

            //データベースに保存
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202214DataSet);
        }

        private void button1_Click(object sender, EventArgs e) {
            this.carReportDBTableAdapter.FillByName(this.infosys202214DataSet.CarReportDB, tbNameSerch.Text);

        }

        private void btDelete_Click(object sender, EventArgs e) {

            DialogResult result = MessageBox.Show("削除しますか？", "警告！！", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (result == System.Windows.Forms.DialogResult.Yes) {
                DataGridViewSelectedRowCollection src = carReportDBDataGridView.SelectedRows;
                for (int i = src.Count - 1; i >= 0; i--) {
                    carReportDBDataGridView.Rows.RemoveAt(src[i].Index);
                }
            } else if (result == System.Windows.Forms.DialogResult.No) {

            }

            
            //データベースに保存
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202214DataSet);
        }
    }
}
