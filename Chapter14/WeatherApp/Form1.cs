using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp {
    public partial class Form1 : Form {
        //Image currentImage = Image.FromFile();
        string Prefecture;
        
        public Form1() {
            InitializeComponent();
            lbCheack();
            tbCheack();
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {
            tbCheack();
            
            CheckArea();
            var json = JsonConvert.DeserializeObject<Class1[]>(Prefecture);
            tbWeatherInfo.Text = "地名 : " + (string)lbArea.SelectedItem;
            tbWeatherInfo.Text += Environment.NewLine;
            tbWeatherInfo.Text += "今日の天気 : " + json[0].timeSeries[0].areas[0].weathers[0];
            tbWeatherInfo.Text += Environment.NewLine;
            tbWeatherInfo.Text += "明日の天気 : " + json[0].timeSeries[0].areas[0].weathers[1];
            tbWeatherInfo.Text += Environment.NewLine;
            tbWeatherInfo.Text += "明後日の天気 : " + json[0].timeSeries[0].areas[0].weathers[2];
            tbWeatherInfo.Text += Environment.NewLine;
            tbWeatherInfo.Text += "最低気温 : " + json[1].tempAverage.areas[0].min + "度";
            tbWeatherInfo.Text += Environment.NewLine;
            tbWeatherInfo.Text += "最高気温 : " + json[1].tempAverage.areas[0].max + "度";
            WeatherPicture();
            //tbWeatherInfo.Text += 
        }

        private void lbCheack() {
            if(lbArea.Items.Count == 0) {
                btWeatherGet.Enabled = false;
                btClear.Enabled = false;
            } else {
                btWeatherGet.Enabled = true;
                btClear.Enabled = true;
            }
            
        }
        private void tbCheack() {
            
        }
        private void WeatherPicture() {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            var json = JsonConvert.DeserializeObject<Class1[]>(Prefecture);

            pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json[0].timeSeries[0].areas[0].weatherCodes[0] +".png";
            pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json[0].timeSeries[0].areas[0].weatherCodes[1] + ".png";
            pbTwodays.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json[0].timeSeries[0].areas[0].weatherCodes[2] + ".png";
        }


        private void CheckArea() {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            
            switch (lbArea.SelectedItem) {
                case "宗谷地方":
                
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json");
                    break;
                case "上川・留萌地方":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/012000.json");
                    
                    break;
                case "網走・北見・紋別地方":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/013000.json");
                    
                    break;
                case "十勝地方":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/014030.json");
                    break;
                case "釧路・北見・紋別地方":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/014100.json");

                    break;
                case "胆振・日高地方":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/015000.json");

                    break;
                case "石狩・空知・後志地方":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/016000.json");

                    break;
                case "渡島・檜山地方":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/017000.json");

                    break;
                case "青森県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/020000.json");

                    break;
                case "岩手県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/030000.json");

                    break;
                case "宮城県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/040000.json");

                    break;
                case "秋田県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/050000.json");

                    break;
                case "山形県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/060000.json");

                    break;
                case "福島県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/070000.json");

                    break;
                case "茨城県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/080000.json");

                    break;
                case "栃木県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/090000.json");

                    break;
                case "群馬県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json");

                    break;
                case "埼玉県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/110000.json");

                    break;
                case "千葉県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/120000.json");

                    break;
                case "東京都":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/130000.json");

                    break;
                case "神奈川県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/140000.json");

                    break;
                case "山梨県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/190000.json");

                    break;
                case "長野県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/200000.json");

                    break;
                case "岐阜県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/210000.json");

                    break;
                case "静岡県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/220000.json");

                    break;
                case "愛知県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/230000.json");

                    break;
                case "三重県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/240000.json");

                    break;
                case "新潟県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/150000.json");

                    break;
                case "富山県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/160000.json");

                    break;
                case "石川県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/170000.json");

                    break;
                case "福井県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/180000.json");

                    break;
                case "滋賀県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/250000.json");

                    break;
                case "京都府":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/260000.json");

                    break;
                case "大阪府":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/270000.json");

                    break;
                case "兵庫県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/280000.json");

                    break;
                case "奈良県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/290000.json");

                    break;
                case "和歌山県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/300000.json");

                    break;
                case "鳥取県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/310000.json");

                    break;
                case "島根県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/320000.json");

                    break;
                case "岡山県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/330000.json");

                    break;
                case "広島県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/340000.json");

                    break;
                case "徳島県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/360000.json");

                    break;
                case "香川県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/370000.json");

                    break;
                case "愛媛県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/380000.json");

                    break;
                case "高知県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/390000.json");

                    break;
                case "山口県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/350000.json");

                    break;
                case "福岡県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/400000.json");

                    break;
                case "佐賀県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/410000.json");

                    break;
                case "長崎県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/420000.json");

                    break;
                case "熊本県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/430000.json");

                    break;
                case "大分県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/440000.json");

                    break;
                case "宮崎県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/450000.json");

                    break;
                case "奄美地方":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/460040.json");

                    break;
                case "鹿児島県":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/460100.json");

                    break;
                case "沖縄本島地方":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/471000.json");

                    break;
                case "大東島地方":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/472000.json");

                    break;
                case "宮古島地方":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/473000.json");
                    break;

                case "八重山地方":
                    Prefecture = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/474000.json");
                    break;
                default:
                    break;

            }
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e) {
            

        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            //if(currentImage != null) {
            //    //画像を0,0に描画する
            //    e.Graphics.DrawImage(currentImage,
            //   200, 50, currentImage.Width, currentImage.Height);
            //}
        }
       

        private void btHokkaido_Click_1(object sender, EventArgs e) {
            lbClear();
            string[] hokkaido = { "宗谷地方", "上川・留萌地方", "網走・北見・紋別地方", "十勝地方", "釧路・根室地方", "胆振・日高地方",
                                   "石狩・空知・後志地方","渡島・檜山地方"};
            lbArea.Items.AddRange(hokkaido);
            lbCheack();
        }

        private void btTohoku_Click(object sender, EventArgs e) {
            lbClear();
            string[] Tohoku = {"青森県", "岩手県", "宮城県",
                                   "秋田県", "山形県", "福島県"};
            lbArea.Items.AddRange(Tohoku);
            lbCheack();
        }

        private void btKanto_Click(object sender, EventArgs e) {
            lbClear();
            string[] Kanto = {"茨城県", "栃木県", "群馬県", "埼玉県", "千葉県",
                                   "東京都", "神奈川県", "山梨県", "長野県"};
            lbArea.Items.AddRange(Kanto);
            lbCheack();
        }

        private void btHokuriku_Click(object sender, EventArgs e) {
            lbClear();
            string[] Hokuriki = { "新潟県", "富山県", "石川県", "福井県" };
            lbArea.Items.AddRange(Hokuriki);
            lbCheack();
        }

        private void btTokai_Click(object sender, EventArgs e) {
            lbClear();
            string[] Tokai = { "岐阜県", "静岡県", "愛知県", "三重県" };
            lbArea.Items.AddRange(Tokai);
            lbCheack();
        }
 

        private void btKinki_Click(object sender, EventArgs e) {
            string[] Kinki = { "滋賀県", "京都府", "大阪府", "兵庫県", "奈良県", "和歌山県" };
            lbArea.Items.AddRange(Kinki);
            lbCheack();
        }

        

        private void btTyugoku_Click(object sender, EventArgs e) {
            lbClear();
            string[] Tyugoku = { "鳥取県", "島根県", "岡山県", "広島県" };
            lbArea.Items.AddRange(Tyugoku);
            lbCheack();
        }

        private void btSikoku_Click(object sender, EventArgs e) {
            lbClear();
            string[] Sikoku = { "徳島県", "香川県", "愛媛県", "高知県" };
            lbArea.Items.AddRange(Sikoku);
            lbCheack();
        }

        private void btNkyusyu_Click(object sender, EventArgs e) {
            lbClear();
            string[] Nkyusyu = { "山口県", "福岡県", "佐賀県", "長崎県", "熊本県", "大分県" };
            lbArea.Items.AddRange(Nkyusyu);
            lbCheack();
        }

        private void btSkyusyu_Click(object sender, EventArgs e) {
            lbClear();
            string[] Skyusyu = { "宮崎県", "奄美地方", "鹿児島県" };
            lbArea.Items.AddRange(Skyusyu);
            lbCheack();
        }

        private void btOkinawa_Click(object sender, EventArgs e) {
            lbClear();
            string[] okinawa = { "沖縄本島地方", "大東島地方", "宮古島地方", "八重山地方" };
            lbArea.Items.AddRange(okinawa);
            lbCheack();
        }
        private void lbClear() {
            if (lbArea.Items != null) {
                lbArea.Items.Clear();
            }
        }

        private void btClear_Click(object sender, EventArgs e) {
            lbClear();
            tbWeatherInfo.Text = null;
            pbToday.ImageLocation = null;
            pbTomorrow.ImageLocation = null;
            pbTwodays.ImageLocation = null;
            lbCheack();
        }
    }
}
