
namespace AddressBook {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbTelNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbWork = new System.Windows.Forms.CheckBox();
            this.cbFriend = new System.Windows.Forms.CheckBox();
            this.cbOther = new System.Windows.Forms.CheckBox();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btPictureClear = new System.Windows.Forms.Button();
            this.cbFamily = new System.Windows.Forms.CheckBox();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.ofdFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.btUpdate = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.cbCompnay = new System.Windows.Forms.ComboBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.sfdSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.gbKindNumber = new System.Windows.Forms.GroupBox();
            this.rbCellPhone = new System.Windows.Forms.RadioButton();
            this.rbHome = new System.Windows.Forms.RadioButton();
            this.tbMailAddress = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbKindNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(96, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "住所";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(96, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "名前";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "メールアドレス";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(96, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "会社";
            // 
            // dgvPersons
            // 
            this.dgvPersons.AllowUserToAddRows = false;
            this.dgvPersons.AllowUserToDeleteRows = false;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Location = new System.Drawing.Point(93, 397);
            this.dgvPersons.MultiSelect = false;
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.ReadOnly = true;
            this.dgvPersons.RowTemplate.Height = 21;
            this.dgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersons.Size = new System.Drawing.Size(718, 145);
            this.dgvPersons.TabIndex = 1;
            this.dgvPersons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersons_CellContentClick);
            this.dgvPersons.Click += new System.EventHandler(this.dgvPersons_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbName.Location = new System.Drawing.Point(195, 27);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(383, 31);
            this.tbName.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAddress.Location = new System.Drawing.Point(195, 120);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(383, 68);
            this.tbAddress.TabIndex = 2;
            // 
            // tbTelNumber
            // 
            this.tbTelNumber.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTelNumber.Location = new System.Drawing.Point(196, 351);
            this.tbTelNumber.Name = "tbTelNumber";
            this.tbTelNumber.Size = new System.Drawing.Size(382, 31);
            this.tbTelNumber.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(71, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "グループ";
            // 
            // cbWork
            // 
            this.cbWork.AutoSize = true;
            this.cbWork.Location = new System.Drawing.Point(344, 280);
            this.cbWork.Name = "cbWork";
            this.cbWork.Size = new System.Drawing.Size(48, 16);
            this.cbWork.TabIndex = 3;
            this.cbWork.Text = "仕事";
            this.cbWork.UseVisualStyleBackColor = true;
            // 
            // cbFriend
            // 
            this.cbFriend.AutoSize = true;
            this.cbFriend.Location = new System.Drawing.Point(269, 280);
            this.cbFriend.Name = "cbFriend";
            this.cbFriend.Size = new System.Drawing.Size(48, 16);
            this.cbFriend.TabIndex = 3;
            this.cbFriend.Text = "友人";
            this.cbFriend.UseVisualStyleBackColor = true;
            // 
            // cbOther
            // 
            this.cbOther.AutoSize = true;
            this.cbOther.Location = new System.Drawing.Point(424, 280);
            this.cbOther.Name = "cbOther";
            this.cbOther.Size = new System.Drawing.Size(55, 16);
            this.cbOther.TabIndex = 3;
            this.cbOther.Text = "その他";
            this.cbOther.UseVisualStyleBackColor = true;
            // 
            // btAddPerson
            // 
            this.btAddPerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAddPerson.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAddPerson.Location = new System.Drawing.Point(514, 287);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(99, 49);
            this.btAddPerson.TabIndex = 4;
            this.btAddPerson.Text = "追加";
            this.btAddPerson.UseVisualStyleBackColor = false;
            this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.Color.DarkGray;
            this.pbPicture.Location = new System.Drawing.Point(613, 27);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(127, 161);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 5;
            this.pbPicture.TabStop = false;
            // 
            // btPictureClear
            // 
            this.btPictureClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPictureClear.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPictureClear.Location = new System.Drawing.Point(684, 194);
            this.btPictureClear.Name = "btPictureClear";
            this.btPictureClear.Size = new System.Drawing.Size(65, 29);
            this.btPictureClear.TabIndex = 6;
            this.btPictureClear.Text = "クリア";
            this.btPictureClear.UseVisualStyleBackColor = false;
            this.btPictureClear.Click += new System.EventHandler(this.btPictureClear_Click);
            // 
            // cbFamily
            // 
            this.cbFamily.AutoSize = true;
            this.cbFamily.Location = new System.Drawing.Point(185, 280);
            this.cbFamily.Name = "cbFamily";
            this.cbFamily.Size = new System.Drawing.Size(48, 16);
            this.cbFamily.TabIndex = 3;
            this.cbFamily.Text = "家族";
            this.cbFamily.UseVisualStyleBackColor = true;
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPictureOpen.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPictureOpen.Location = new System.Drawing.Point(604, 194);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(65, 29);
            this.btPictureOpen.TabIndex = 6;
            this.btPictureOpen.Text = "開く...";
            this.btPictureOpen.UseVisualStyleBackColor = false;
            this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // ofdFileOpenDialog
            // 
            this.ofdFileOpenDialog.FileName = "openFileDialog1";
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btUpdate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btUpdate.Location = new System.Drawing.Point(641, 287);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(99, 49);
            this.btUpdate.TabIndex = 4;
            this.btUpdate.Text = "更新";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.BackColor = System.Drawing.Color.Red;
            this.bt_Delete.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_Delete.Location = new System.Drawing.Point(762, 280);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(49, 62);
            this.bt_Delete.TabIndex = 7;
            this.bt_Delete.Text = "削除";
            this.bt_Delete.UseVisualStyleBackColor = false;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // cbCompnay
            // 
            this.cbCompnay.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbCompnay.FormattingEnabled = true;
            this.cbCompnay.Location = new System.Drawing.Point(196, 210);
            this.cbCompnay.Name = "cbCompnay";
            this.cbCompnay.Size = new System.Drawing.Size(382, 32);
            this.cbCompnay.TabIndex = 8;
            // 
            // btOpen
            // 
            this.btOpen.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOpen.Location = new System.Drawing.Point(12, 432);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 43);
            this.btOpen.TabIndex = 9;
            this.btOpen.Text = "開く...";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSave.Location = new System.Drawing.Point(12, 499);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 43);
            this.btSave.TabIndex = 9;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(472, 563);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "登録日：";
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp.Location = new System.Drawing.Point(540, 558);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 23);
            this.dtp.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(48, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "電話番号";
            // 
            // gbKindNumber
            // 
            this.gbKindNumber.Controls.Add(this.rbCellPhone);
            this.gbKindNumber.Controls.Add(this.rbHome);
            this.gbKindNumber.Location = new System.Drawing.Point(185, 302);
            this.gbKindNumber.Name = "gbKindNumber";
            this.gbKindNumber.Size = new System.Drawing.Size(121, 43);
            this.gbKindNumber.TabIndex = 12;
            this.gbKindNumber.TabStop = false;
            this.gbKindNumber.Text = "種別";
            // 
            // rbCellPhone
            // 
            this.rbCellPhone.AutoSize = true;
            this.rbCellPhone.Location = new System.Drawing.Point(60, 19);
            this.rbCellPhone.Name = "rbCellPhone";
            this.rbCellPhone.Size = new System.Drawing.Size(47, 16);
            this.rbCellPhone.TabIndex = 0;
            this.rbCellPhone.Text = "携帯";
            this.rbCellPhone.UseVisualStyleBackColor = true;
            // 
            // rbHome
            // 
            this.rbHome.AutoSize = true;
            this.rbHome.Checked = true;
            this.rbHome.Location = new System.Drawing.Point(6, 18);
            this.rbHome.Name = "rbHome";
            this.rbHome.Size = new System.Drawing.Size(47, 16);
            this.rbHome.TabIndex = 0;
            this.rbHome.TabStop = true;
            this.rbHome.Text = "自宅";
            this.rbHome.UseVisualStyleBackColor = true;
            // 
            // tbMailAddress
            // 
            this.tbMailAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMailAddress.Location = new System.Drawing.Point(195, 75);
            this.tbMailAddress.Name = "tbMailAddress";
            this.tbMailAddress.Size = new System.Drawing.Size(382, 31);
            this.tbMailAddress.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(847, 593);
            this.Controls.Add(this.gbKindNumber);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.cbCompnay);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.btPictureClear);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAddPerson);
            this.Controls.Add(this.cbFamily);
            this.Controls.Add(this.cbFriend);
            this.Controls.Add(this.cbOther);
            this.Controls.Add(this.cbWork);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbMailAddress);
            this.Controls.Add(this.tbTelNumber);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dgvPersons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "住所録アプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.gbKindNumber.ResumeLayout(false);
            this.gbKindNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbTelNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbWork;
        private System.Windows.Forms.CheckBox cbFriend;
        private System.Windows.Forms.CheckBox cbOther;
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btPictureClear;
        private System.Windows.Forms.CheckBox cbFamily;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.OpenFileDialog ofdFileOpenDialog;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.ComboBox cbCompnay;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.SaveFileDialog sfdSaveDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbKindNumber;
        private System.Windows.Forms.RadioButton rbCellPhone;
        private System.Windows.Forms.RadioButton rbHome;
        private System.Windows.Forms.TextBox tbMailAddress;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

