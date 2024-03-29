﻿using System;
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
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }

        }

        private void btAddPerson_Click(object sender, EventArgs e) {

            //氏名が未入力なら登録しない
            if (String.IsNullOrWhiteSpace(tbName.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }

            Person newPerson = GetNewPerson();
            listPerson.Add(newPerson);
            Check();
            EnabledCheck();
            setCbCompny(cbCompnay.Text);

        }

        private Person GetNewPerson() {
            return new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = cbCompnay.Text,
                Picture = pbPicture.Image,
                listgroup = getCheckBoxGroup(),
                Registration = dtp.Value,
                KindNumber = GetRadioButtonKindNumber(),
                TelNumber = tbTelNumber.Text,
            };
        }

        private Person.KindNumberType GetRadioButtonKindNumber() {

            Person.KindNumberType selectedKindNumber = Person.KindNumberType.その他;

            if (rbHome.Checked) { //自宅にチェックがついている
                return Person.KindNumberType.自宅;
            }
            if (rbCellPhone.Checked) { //携帯にチェックがついている
                return Person.KindNumberType.携帯;
            }
            return selectedKindNumber;
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
            dtp.Value =
                listPerson[getIndex].Registration.Year > 1900 ? listPerson[getIndex].Registration : DateTime.Today;
            tbTelNumber.Text = listPerson[getIndex].TelNumber;


            groupCheckBoxAllClear();//チェックボックス初期化

            ListGroupCheck(getIndex);//グループを設定

            RadioButtonCheck(getIndex);//番号種別を設定
        }

        private void RadioButtonCheck(int getIndex) {
            //番号種別チェック処理
            switch (listPerson[getIndex].KindNumber) {
                case Person.KindNumberType.自宅:
                    rbHome.Checked = true;
                    break;
                case Person.KindNumberType.携帯:
                    rbCellPhone.Checked = true;
                    break;
                case Person.KindNumberType.その他:
                    break;
                default:
                    break;
            }
        }

        private void ListGroupCheck(int getIndex) {
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
            listPerson[getIndex].MailAddress = tbTelNumber.Text;
            listPerson[getIndex].Address = tbAddress.Text;
            listPerson[getIndex].Company = cbCompnay.Text;
            listPerson[getIndex].Picture = pbPicture.Image;
            listPerson[getIndex].listgroup = getCheckBoxGroup();
            listPerson[getIndex].Registration = dtp.Value;
            listPerson[getIndex].TelNumber = tbTelNumber.Text;
            listPerson[getIndex].KindNumber = GetRadioButtonKindNumber();

            dgvPersons.Refresh();//データグリッドビュー更新
   
        }
        //削除ボタンが押された時の処理
        private void bt_Delete_Click(object sender, EventArgs e) {
            var getIndex = dgvPersons.CurrentRow.Index;
            listPerson.RemoveAt(getIndex);

            Check();
        }
        private void Check() {
            EnabledCheck();
        }

        //更新・削除ボタン・のマスク処理を行う（判定）
        private void EnabledCheck() {

            btUpdate.Enabled = bt_Delete.Enabled = listPerson.Count() > 0 ? true : false;
        }

        private void Form1_Load(object sender, EventArgs e) {
            EnabledCheck();
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
                cbCompnay.Items.Clear();
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
                //コンボボックスへ登録
                foreach (var item in listPerson.Select(p => p.Company)) {
                    setCbCompny(item);//存在する会社を登録
                }              
            }
            EnabledCheck();
        }
        //コンボボックスに会社名を登録(重複なし)
        private void setCbCompny(string company) {
            if (!cbCompnay.Items.Contains(company)) {
                //まだ登録されてない処理
                cbCompnay.Items.Add(company);
            }

        }
    }
}
