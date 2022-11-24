
namespace WeatherApp {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.pictuer = new System.Windows.Forms.PictureBox();
            this.btTokai = new System.Windows.Forms.Button();
            this.btNkyusyu = new System.Windows.Forms.Button();
            this.btKinki = new System.Windows.Forms.Button();
            this.btSikoku = new System.Windows.Forms.Button();
            this.btTyugoku = new System.Windows.Forms.Button();
            this.btOkinawa = new System.Windows.Forms.Button();
            this.btHokuriku = new System.Windows.Forms.Button();
            this.btKanto = new System.Windows.Forms.Button();
            this.btTohoku = new System.Windows.Forms.Button();
            this.btHokkaido = new System.Windows.Forms.Button();
            this.lbArea = new System.Windows.Forms.ListBox();
            this.pbToday = new System.Windows.Forms.PictureBox();
            this.pbTomorrow = new System.Windows.Forms.PictureBox();
            this.pbTwodays = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictuer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwodays)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tbWeatherInfo.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherInfo.Location = new System.Drawing.Point(591, 482);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(615, 178);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btWeatherGet.Location = new System.Drawing.Point(913, 206);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(97, 30);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // pictuer
            // 
            this.pictuer.BackColor = System.Drawing.Color.Transparent;
            this.pictuer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictuer.BackgroundImage")));
            this.pictuer.ErrorImage = null;
            this.pictuer.Location = new System.Drawing.Point(92, 22);
            this.pictuer.Name = "pictuer";
            this.pictuer.Size = new System.Drawing.Size(527, 493);
            this.pictuer.TabIndex = 5;
            this.pictuer.TabStop = false;
            // 
            // btTokai
            // 
            this.btTokai.Location = new System.Drawing.Point(330, 400);
            this.btTokai.Name = "btTokai";
            this.btTokai.Size = new System.Drawing.Size(100, 31);
            this.btTokai.TabIndex = 6;
            this.btTokai.Text = "東海地方";
            this.btTokai.UseVisualStyleBackColor = true;
            this.btTokai.Click += new System.EventHandler(this.btTokai_Click);
            // 
            // btNkyusyu
            // 
            this.btNkyusyu.Location = new System.Drawing.Point(12, 448);
            this.btNkyusyu.Name = "btNkyusyu";
            this.btNkyusyu.Size = new System.Drawing.Size(100, 31);
            this.btNkyusyu.TabIndex = 6;
            this.btNkyusyu.Text = "九州";
            this.btNkyusyu.UseVisualStyleBackColor = true;
            this.btNkyusyu.Click += new System.EventHandler(this.btNkyusyu_Click);
            // 
            // btKinki
            // 
            this.btKinki.Location = new System.Drawing.Point(203, 291);
            this.btKinki.Name = "btKinki";
            this.btKinki.Size = new System.Drawing.Size(100, 31);
            this.btKinki.TabIndex = 6;
            this.btKinki.Text = "近畿地方";
            this.btKinki.UseVisualStyleBackColor = true;
            this.btKinki.Click += new System.EventHandler(this.btKinki_Click);
            // 
            // btSikoku
            // 
            this.btSikoku.Location = new System.Drawing.Point(203, 448);
            this.btSikoku.Name = "btSikoku";
            this.btSikoku.Size = new System.Drawing.Size(100, 31);
            this.btSikoku.TabIndex = 6;
            this.btSikoku.Text = "四国地方";
            this.btSikoku.UseVisualStyleBackColor = true;
            this.btSikoku.Click += new System.EventHandler(this.btSikoku_Click);
            // 
            // btTyugoku
            // 
            this.btTyugoku.Location = new System.Drawing.Point(110, 328);
            this.btTyugoku.Name = "btTyugoku";
            this.btTyugoku.Size = new System.Drawing.Size(100, 31);
            this.btTyugoku.TabIndex = 6;
            this.btTyugoku.Text = "中国地方";
            this.btTyugoku.UseVisualStyleBackColor = true;
            this.btTyugoku.Click += new System.EventHandler(this.btTyugoku_Click);
            // 
            // btOkinawa
            // 
            this.btOkinawa.Location = new System.Drawing.Point(373, 484);
            this.btOkinawa.Name = "btOkinawa";
            this.btOkinawa.Size = new System.Drawing.Size(100, 31);
            this.btOkinawa.TabIndex = 6;
            this.btOkinawa.Text = "沖縄地方";
            this.btOkinawa.UseVisualStyleBackColor = true;
            this.btOkinawa.Click += new System.EventHandler(this.btOkinawa_Click);
            // 
            // btHokuriku
            // 
            this.btHokuriku.Location = new System.Drawing.Point(278, 228);
            this.btHokuriku.Name = "btHokuriku";
            this.btHokuriku.Size = new System.Drawing.Size(100, 31);
            this.btHokuriku.TabIndex = 6;
            this.btHokuriku.Text = "北陸地方";
            this.btHokuriku.UseVisualStyleBackColor = true;
            this.btHokuriku.Click += new System.EventHandler(this.btHokuriku_Click);
            // 
            // btKanto
            // 
            this.btKanto.Location = new System.Drawing.Point(440, 328);
            this.btKanto.Name = "btKanto";
            this.btKanto.Size = new System.Drawing.Size(100, 31);
            this.btKanto.TabIndex = 6;
            this.btKanto.Text = "関東甲信地方";
            this.btKanto.UseVisualStyleBackColor = true;
            this.btKanto.Click += new System.EventHandler(this.btKanto_Click);
            // 
            // btTohoku
            // 
            this.btTohoku.Location = new System.Drawing.Point(466, 194);
            this.btTohoku.Name = "btTohoku";
            this.btTohoku.Size = new System.Drawing.Size(100, 31);
            this.btTohoku.TabIndex = 6;
            this.btTohoku.Text = "東北地方";
            this.btTohoku.UseVisualStyleBackColor = true;
            this.btTohoku.Click += new System.EventHandler(this.btTohoku_Click);
            // 
            // btHokkaido
            // 
            this.btHokkaido.Location = new System.Drawing.Point(320, 51);
            this.btHokkaido.Name = "btHokkaido";
            this.btHokkaido.Size = new System.Drawing.Size(100, 31);
            this.btHokkaido.TabIndex = 6;
            this.btHokkaido.Text = "北海道地方";
            this.btHokkaido.UseVisualStyleBackColor = true;
            this.btHokkaido.Click += new System.EventHandler(this.btHokkaido_Click_1);
            // 
            // lbArea
            // 
            this.lbArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbArea.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbArea.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbArea.FormattingEnabled = true;
            this.lbArea.ItemHeight = 21;
            this.lbArea.Location = new System.Drawing.Point(666, 22);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(225, 214);
            this.lbArea.TabIndex = 7;
            // 
            // pbToday
            // 
            this.pbToday.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pbToday.Location = new System.Drawing.Point(640, 348);
            this.pbToday.Name = "pbToday";
            this.pbToday.Size = new System.Drawing.Size(120, 120);
            this.pbToday.TabIndex = 8;
            this.pbToday.TabStop = false;
            // 
            // pbTomorrow
            // 
            this.pbTomorrow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pbTomorrow.Location = new System.Drawing.Point(795, 348);
            this.pbTomorrow.Name = "pbTomorrow";
            this.pbTomorrow.Size = new System.Drawing.Size(120, 120);
            this.pbTomorrow.TabIndex = 8;
            this.pbTomorrow.TabStop = false;
            // 
            // pbTwodays
            // 
            this.pbTwodays.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pbTwodays.Location = new System.Drawing.Point(948, 348);
            this.pbTwodays.Name = "pbTwodays";
            this.pbTwodays.Size = new System.Drawing.Size(120, 120);
            this.pbTwodays.TabIndex = 8;
            this.pbTwodays.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(672, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "今日";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(826, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "明日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(969, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "明後日";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1254, 664);
            this.Controls.Add(this.tbWeatherInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbTwodays);
            this.Controls.Add(this.pbTomorrow);
            this.Controls.Add(this.pbToday);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.btHokkaido);
            this.Controls.Add(this.btTohoku);
            this.Controls.Add(this.btKanto);
            this.Controls.Add(this.btHokuriku);
            this.Controls.Add(this.btOkinawa);
            this.Controls.Add(this.btTyugoku);
            this.Controls.Add(this.btSikoku);
            this.Controls.Add(this.btKinki);
            this.Controls.Add(this.btNkyusyu);
            this.Controls.Add(this.btTokai);
            this.Controls.Add(this.pictuer);
            this.Controls.Add(this.btWeatherGet);
            this.Name = "Form1";
            this.Text = "天気予報表示アプリ";
            ((System.ComponentModel.ISupportInitialize)(this.pictuer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwodays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.PictureBox pictuer;
        private System.Windows.Forms.Button btTokai;
        private System.Windows.Forms.Button btNkyusyu;
        private System.Windows.Forms.Button btKinki;
        private System.Windows.Forms.Button btSikoku;
        private System.Windows.Forms.Button btTyugoku;
        private System.Windows.Forms.Button btOkinawa;
        private System.Windows.Forms.Button btHokuriku;
        private System.Windows.Forms.Button btKanto;
        private System.Windows.Forms.Button btTohoku;
        private System.Windows.Forms.Button btHokkaido;
        private System.Windows.Forms.ListBox lbArea;
        private System.Windows.Forms.PictureBox pbToday;
        private System.Windows.Forms.PictureBox pbTomorrow;
        private System.Windows.Forms.PictureBox pbTwodays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

