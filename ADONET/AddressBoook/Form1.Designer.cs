
namespace AddressBoook {
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
            this.components = new System.ComponentModel.Container();
            this.addressTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.addressTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202214DataSet = new AddressBoook.infosys202214DataSet();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btImageOpen = new System.Windows.Forms.Button();
            this.btImageClear = new System.Windows.Forms.Button();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNameSerch = new System.Windows.Forms.TextBox();
            this.addressTableTableAdapter = new AddressBoook.infosys202214DataSetTableAdapters.AddressTableTableAdapter();
            this.tableAdapterManager = new AddressBoook.infosys202214DataSetTableAdapters.TableAdapterManager();
            this.btClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了XAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.データベース接続ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.addressTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202214DataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // addressTableDataGridView
            // 
            this.addressTableDataGridView.AllowUserToAddRows = false;
            this.addressTableDataGridView.AllowUserToDeleteRows = false;
            this.addressTableDataGridView.AutoGenerateColumns = false;
            this.addressTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Image});
            this.addressTableDataGridView.DataSource = this.addressTableBindingSource;
            this.addressTableDataGridView.Location = new System.Drawing.Point(29, 360);
            this.addressTableDataGridView.MultiSelect = false;
            this.addressTableDataGridView.Name = "addressTableDataGridView";
            this.addressTableDataGridView.ReadOnly = true;
            this.addressTableDataGridView.RowTemplate.Height = 21;
            this.addressTableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addressTableDataGridView.Size = new System.Drawing.Size(746, 220);
            this.addressTableDataGridView.TabIndex = 1;
            this.addressTableDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.addressTableDataGridView_DataError);
            this.addressTableDataGridView.Click += new System.EventHandler(this.addressTableDataGridView_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tel";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tel";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mail";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Memo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Memo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // addressTableBindingSource
            // 
            this.addressTableBindingSource.DataMember = "AddressTable";
            this.addressTableBindingSource.DataSource = this.infosys202214DataSet;
            // 
            // infosys202214DataSet
            // 
            this.infosys202214DataSet.DataSetName = "infosys202214DataSet";
            this.infosys202214DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbName.Location = new System.Drawing.Point(101, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(447, 31);
            this.tbName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAddress.Location = new System.Drawing.Point(101, 68);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(447, 31);
            this.tbAddress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(54, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tel";
            // 
            // tbTel
            // 
            this.tbTel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTel.Location = new System.Drawing.Point(101, 105);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(447, 31);
            this.tbTel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(46, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mail";
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMail.Location = new System.Drawing.Point(101, 142);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(447, 31);
            this.tbMail.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(25, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Memo";
            // 
            // tbMemo
            // 
            this.tbMemo.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMemo.Location = new System.Drawing.Point(101, 179);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(515, 132);
            this.tbMemo.TabIndex = 10;
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btUpdate.Location = new System.Drawing.Point(649, 249);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(88, 39);
            this.btUpdate.TabIndex = 12;
            this.btUpdate.Text = "更新";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btConnect.Location = new System.Drawing.Point(649, 295);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(88, 39);
            this.btConnect.TabIndex = 12;
            this.btConnect.Text = "接続";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAdd.Location = new System.Drawing.Point(649, 204);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(88, 39);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btImageOpen
            // 
            this.btImageOpen.Location = new System.Drawing.Point(628, 40);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(75, 23);
            this.btImageOpen.TabIndex = 14;
            this.btImageOpen.Text = "開く...";
            this.btImageOpen.UseVisualStyleBackColor = true;
            this.btImageOpen.Click += new System.EventHandler(this.btImageOpen_Click);
            // 
            // btImageClear
            // 
            this.btImageClear.Location = new System.Drawing.Point(712, 40);
            this.btImageClear.Name = "btImageClear";
            this.btImageClear.Size = new System.Drawing.Size(38, 23);
            this.btImageClear.TabIndex = 14;
            this.btImageClear.Text = "×";
            this.btImageClear.UseVisualStyleBackColor = true;
            this.btImageClear.Click += new System.EventHandler(this.btImageClear_Click);
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(2, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "名前検索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNameSerch
            // 
            this.tbNameSerch.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbNameSerch.Location = new System.Drawing.Point(101, 323);
            this.tbNameSerch.Name = "tbNameSerch";
            this.tbNameSerch.Size = new System.Drawing.Size(239, 31);
            this.tbNameSerch.TabIndex = 16;
            // 
            // addressTableTableAdapter
            // 
            this.addressTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddressTableTableAdapter = this.addressTableTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AddressBoook.infosys202214DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btClear.Location = new System.Drawing.Point(517, 320);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 39);
            this.btClear.TabIndex = 17;
            this.btClear.Text = "クリア";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.データベース接続ToolStripMenuItem,
            this.toolStripSeparator1,
            this.終了XAltF4ToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(F)";
            // 
            // 終了XAltF4ToolStripMenuItem
            // 
            this.終了XAltF4ToolStripMenuItem.Name = "終了XAltF4ToolStripMenuItem";
            this.終了XAltF4ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.終了XAltF4ToolStripMenuItem.Text = "終了（X）    Alt + F4";
            this.終了XAltF4ToolStripMenuItem.Click += new System.EventHandler(this.終了XAltF4ToolStripMenuItem_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報ToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(H)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            this.バージョン情報ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.バージョン情報ToolStripMenuItem.Text = "バージョン情報";
            this.バージョン情報ToolStripMenuItem.Click += new System.EventHandler(this.バージョン情報ToolStripMenuItem_Click);
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(628, 69);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(122, 129);
            this.pbImage.TabIndex = 13;
            this.pbImage.TabStop = false;
            // 
            // データベース接続ToolStripMenuItem
            // 
            this.データベース接続ToolStripMenuItem.Image = global::AddressBoook.Properties.Resources.officedatabase_103574;
            this.データベース接続ToolStripMenuItem.Name = "データベース接続ToolStripMenuItem";
            this.データベース接続ToolStripMenuItem.ShowShortcutKeys = false;
            this.データベース接続ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.データベース接続ToolStripMenuItem.Text = "データベース接続";
            this.データベース接続ToolStripMenuItem.Click += new System.EventHandler(this.データベース接続ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 592);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.tbNameSerch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btImageClear);
            this.Controls.Add(this.btImageOpen);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.addressTableDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addressTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202214DataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private infosys202214DataSet infosys202214DataSet;
        private System.Windows.Forms.BindingSource addressTableBindingSource;
        private infosys202214DataSetTableAdapters.AddressTableTableAdapter addressTableTableAdapter;
        private infosys202214DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView addressTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btImageOpen;
        private System.Windows.Forms.Button btImageClear;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbNameSerch;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem データベース接続ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了XAltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
    }
}

