using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        Person newPerson = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listgroup = getCheckBoxGroup(),

            };
            listPerson.Add(newPerson);
            
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
            tbCompany.Text = listPerson[getIndex].Company;
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
            listPerson[getIndex].Company = tbCompany.Text;
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
            } else {
                bt_Delete.Enabled = true;
                btUpdate.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            bt_Delete.Enabled = false;
            btUpdate.Enabled = false;
            btPictureClear.Enabled = false;
        }
        
    }
}
