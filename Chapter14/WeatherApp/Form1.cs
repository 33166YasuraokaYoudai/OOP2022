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

        string Prefecture;
        Class1[] json;

        public Form1() {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            string[] Kanto = {"茨城県", "栃木県", "群馬県", "埼玉県", "千葉県",
                                   "東京都", "神奈川県", "山梨県", "長野県"};
            lbArea.Items.AddRange(Kanto);


            tbToday.Text = dt.Day + "日";
            tbTomorrow.Text = dt.Day + 1 + "日";
            tbTwodays.Text = dt.Day + 2 + "日";
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {
            tbWeatherInfo.Clear();

            DateTime dt = DateTime.Now;
            tbWeatherInfo.Text = dt.Month + "月";
            tbWeatherInfo.Text += dt.Day + "日";
            CheckArea();
            json = JsonConvert.DeserializeObject<Class1[]>(Prefecture);
            tbWeatherInfo.Text = dt.Month + "月";
            tbWeatherInfo.Text += dt.Day + "日";
            tbWeatherInfo.Text += Environment.NewLine;
            tbWeatherInfo.Text += "地名 : " + (string)lbArea.SelectedItem;
            tbWeatherInfo.Text += Environment.NewLine;
            tbWeatherInfo.Text += Environment.NewLine;
            tbWeatherInfo.Text += "今日の天気 : " + json[0].timeSeries[0].areas[0].weathers[0];
            tbWeatherInfo.Text += Environment.NewLine;
            tbWeatherInfo.Text += "明日の天気 : " + json[0].timeSeries[0].areas[0].weathers[1];
            tbWeatherInfo.Text += Environment.NewLine;
            try {
                tbWeatherInfo.Text += "明後日の天気 : " + json[0].timeSeries[0].areas[0].weathers[2];
            }
            catch (Exception) {

            }
            tbWeatherInfo.Text += Environment.NewLine;
            tbWeatherInfo.Text += "最低気温  : " + json[1].tempAverage.areas[0].min + "度";
            tbWeatherInfo.Text += "  最高気温  : " + json[1].tempAverage.areas[0].max + "度";
            WeatherPicture();
        }


        private void WeatherPicture() {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            json = JsonConvert.DeserializeObject<Class1[]>(Prefecture);

            pbToday.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json[0].timeSeries[0].areas[0].weatherCodes[0] + ".png";
            pbTomorrow.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json[0].timeSeries[0].areas[0].weatherCodes[1] + ".png";
            try {
                pbTwodays.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + json[0].timeSeries[0].areas[0].weatherCodes[2] + ".png";

            }
            catch (Exception) {

            }
        }


        private void CheckArea() {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            string code = "";

            switch (lbArea.SelectedItem) {
                case "宗谷地方":
                    code = "011000";

                    break;
                case "上川・留萌地方":
                    code = "012000";

                    break;
                case "網走・北見・紋別地方":
                    code = "013000";

                    break;
                case "釧路・北見・紋別地方":
                    code = "014100";

                    break;
                case "胆振・日高地方":
                    code = "015000";

                    break;
                case "石狩・空知・後志地方":
                    code = "016000";

                    break;
                case "渡島・檜山地方":
                    code = "017000";

                    break;
                case "青森県":
                    code = "020000";

                    break;
                case "岩手県":
                    code = "030000";

                    break;
                case "宮城県":
                    code = "040000";

                    break;
                case "秋田県":
                    code = "050000";

                    break;
                case "山形県":
                    code = "190000";

                    break;
                case "福島県":
                    code = "070000";

                    break;
                case "茨城県":
                    code = "080000";

                    break;
                case "栃木県":
                    code = "090000";
                    break;
                case "群馬県":
                    code = "100000";

                    break;
                case "埼玉県":
                    code = "110000";

                    break;
                case "千葉県":
                    code = "120000";

                    break;
                case "東京都":
                    code = "130000";

                    break;
                case "神奈川県":
                    code = "140000";

                    break;
                case "山梨県":
                    code = "190000";

                    break;
                case "長野県":
                    code = "200000";

                    break;
                case "岐阜県":
                    code = "210000";

                    break;
                case "静岡県":
                    code = "220000";

                    break;
                case "愛知県":
                    code = "230000";

                    break;
                case "三重県":
                    code = "240000";

                    break;
                case "新潟県":
                    code = "150000";

                    break;
                case "富山県":
                    code = "160000";

                    break;
                case "石川県":
                    code = "170000";

                    break;
                case "福井県":
                    code = "180000";

                    break;
                case "滋賀県":
                    code = "250000";

                    break;
                case "京都府":
                    code = "260000";

                    break;
                case "大阪府":
                    code = "270000";

                    break;
                case "兵庫県":
                    code = "280000";

                    break;
                case "奈良県":
                    code = "290000";

                    break;
                case "和歌山県":
                    code = "300000";

                    break;
                case "鳥取県":
                    code = "310000";

                    break;
                case "島根県":
                    code = "320000";

                    break;
                case "岡山県":
                    code = "330000";

                    break;
                case "広島県":
                    code = "340000";

                    break;
                case "徳島県":
                    code = "360000";

                    break;
                case "香川県":
                    code = "370000";

                    break;
                case "愛媛県":
                    code = "380000";

                    break;
                case "高知県":
                    code = "390000";

                    break;
                case "山口県":
                    code = "350000";

                    break;
                case "福岡県":
                    code = "400000";

                    break;
                case "佐賀県":
                    code = "410000";

                    break;
                case "長崎県":
                    code = "420000";

                    break;
                case "熊本県":
                    code = "430000";

                    break;
                case "大分県":
                    code = "440000";

                    break;
                case "宮崎県":
                    code = "450000";

                    break;


                case "鹿児島県":
                    code = "460100";

                    break;
                case "沖縄本島地方":
                    code = "471000";

                    break;
                case "大東島地方":
                    code = "472000";

                    break;
                case "宮古島地方":
                    code = "473000";
                    break;

                case "八重山地方":
                    code = "474000";
                    break;
                default:
                    break;

            }
            string url = "https://www.jma.go.jp/bosai/forecast/data/forecast/" + code + ".json";
            Prefecture = wc.DownloadString(url);


        }





        private void btHokkaido_Click_1(object sender, EventArgs e) {
            lbClear();
            string[] hokkaido = { "宗谷地方", "上川・留萌地方", "網走・北見・紋別地方","釧路・根室地方", "胆振・日高地方",
                                   "石狩・空知・後志地方","渡島・檜山地方"};
            lbArea.Items.AddRange(hokkaido);

        }

        private void btTohoku_Click(object sender, EventArgs e) {
            lbClear();
            string[] Tohoku = {"青森県", "岩手県", "宮城県",
                                   "秋田県", "山形県", "福島県"};
            lbArea.Items.AddRange(Tohoku);

        }

        private void btKanto_Click(object sender, EventArgs e) {
            lbClear();
            string[] Kanto = {"茨城県", "栃木県", "群馬県", "埼玉県", "千葉県",
                                   "東京都", "神奈川県", "山梨県", "長野県"};
            lbArea.Items.AddRange(Kanto);

        }

        private void btHokuriku_Click(object sender, EventArgs e) {
            lbClear();
            string[] Hokuriki = { "新潟県", "富山県", "石川県", "福井県" };
            lbArea.Items.AddRange(Hokuriki);

        }

        private void btTokai_Click(object sender, EventArgs e) {
            lbClear();
            string[] Tokai = { "岐阜県", "静岡県", "愛知県", "三重県" };
            lbArea.Items.AddRange(Tokai);

        }


        private void btKinki_Click(object sender, EventArgs e) {
            lbClear();
            string[] Kinki = { "滋賀県", "京都府", "大阪府", "兵庫県", "奈良県", "和歌山県" };
            lbArea.Items.AddRange(Kinki);

        }



        private void btTyugoku_Click(object sender, EventArgs e) {
            lbClear();
            string[] Tyugoku = { "鳥取県", "島根県", "岡山県", "広島県" };
            lbArea.Items.AddRange(Tyugoku);

        }

        private void btSikoku_Click(object sender, EventArgs e) {
            lbClear();
            string[] Sikoku = { "徳島県", "香川県", "愛媛県", "高知県" };
            lbArea.Items.AddRange(Sikoku);

        }

        private void btNkyusyu_Click(object sender, EventArgs e) {
            lbClear();
            string[] Nkyusyu = { "山口県", "福岡県", "佐賀県", "長崎県", "熊本県", "大分県", "宮崎県", "鹿児島県" };
            lbArea.Items.AddRange(Nkyusyu);

        }



        private void btOkinawa_Click(object sender, EventArgs e) {
            lbClear();
            string[] okinawa = { "沖縄本島地方", "大東島地方", "宮古島地方", "八重山地方" };
            lbArea.Items.AddRange(okinawa);

        }
        private void lbClear() {
            if (lbArea.Items != null) {
                lbArea.Items.Clear();
            }
        }
    }
}
