using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {

        //住所データ管理用
        BindingList<Person> listPerson = new BindingList<Person>();
             

        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if(ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
            
        }

        private void btAddPerson_Click(object sender, EventArgs e) {

            //氏名が未入力なら登録しない
            if (String.IsNullOrWhiteSpace(tbName.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }

            Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = cbCompnay.Text,
                Picture = pbPicture.Image,
                listgroup = getCheckBoxGroup(),

            };
            listPerson.Add(newPerson);
            Check();

            setCbCompny(cbCompnay.Text);

        }
        //コンボボックスに会社名を登録(重複なし)
        private void setCbCompny(string company) {
            if (!cbCompnay.Items.Contains(cbCompnay.Text)) {
                //まだ登録されてない処理
                cbCompnay.Items.Add(cbCompnay.Text);
            }
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> getCheckBoxGroup() {
            var listgroup = new List<Person.GroupType>();

            if(cbFamily.Checked)   {
                listgroup.Add(Person.GroupType.家族);
            }
            if(cbFriend.Checked) {
                listgroup.Add(Person.GroupType.友人);
            }
            if(cbWork.Checked) {
                listgroup.Add(Person.GroupType.仕事);
            }
            if(cbOther.Checked) {
                listgroup.Add(Person.GroupType.その他);
            }

            return listgroup;
        }


        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //データグリッドビューをクリックした時のイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {

            if (dgvPersons.CurrentRow == null) return;

            var getIndex = dgvPersons.CurrentRow.Index;

            tbName.Text = listPerson[getIndex].Name;
            tbMailAddress.Text = listPerson[getIndex].MailAddress;
            tbAddress.Text = listPerson[getIndex].Address;
            cbCompnay.Text = listPerson[getIndex].Company;
            pbPicture.Image = listPerson[getIndex].Picture;

            groupCheckBoxAllClear();//チェックボックス初期化

            foreach (var group in listPerson[getIndex].listgroup) {

                switch (group) {
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }
            }
            
            if (listPerson.Count == 0) {
                btUpdate.Enabled = false;
                bt_Delete.Enabled = false;
                btPictureClear.Enabled = false;
               
            } else {
                bt_Delete.Enabled = true;
                btUpdate.Enabled = true;
                btPictureClear.Enabled = false;
            }
            
        }
        //グループのチェックボックスをオールクリア
        private void groupCheckBoxAllClear() {
            cbFamily.Checked = false;
            cbFriend.Checked = false;
            cbWork.Checked = false;
            cbOther.Checked = false;
        }

        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e) {

            var getIndex = dgvPersons.CurrentRow.Index;
            
            listPerson[getIndex].Name = tbName.Text;
            listPerson[getIndex].MailAddress = tbMailAddress.Text;
            listPerson[getIndex].Address = tbAddress.Text;
            listPerson[getIndex].Company = cbCompnay.Text;
            listPerson[getIndex].Picture = pbPicture.Image;
            listPerson[getIndex].listgroup = getCheckBoxGroup();
            dgvPersons.Refresh();//データグリッドビュー更新
   
        }

        private void bt_Delete_Click(object sender, EventArgs e) {
            var getIndex = dgvPersons.CurrentRow.Index;
            listPerson.RemoveAt(getIndex);

            Check();

        }

        private void Check() {
            if (listPerson.Count == 0) {
                bt_Delete.Enabled = false;
                btUpdate.Enabled = false;
                btPictureClear.Enabled = false;
            } else {
                bt_Delete.Enabled = true;
                btUpdate.Enabled = true;
                btPictureClear.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            bt_Delete.Enabled = false;
            btUpdate.Enabled = false;
            btPictureClear.Enabled = false;
        }

        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e) {
            if(sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName,FileMode.Create)) {
                        bf.Serialize(fs, listPerson);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {

                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    
                    using(FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listPerson = (BindingList<Person>)bf.Deserialize(fs);
                        dgvPersons.DataSource = null;
                        dgvPersons.DataSource = listPerson;

                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);

                }
                foreach (var item in listPerson) {
                    setCbCompny(item.Company);//存在する会社を登録

                }
                

            }
        }
    }
}
