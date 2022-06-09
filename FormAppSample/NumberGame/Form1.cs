using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {

        Random rand = new Random();
        //保存用
        private int RandomNumber;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //乱数取得
            RandomNumber = rand.Next(1,51);
            this.Text = RandomNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {

            if(nudAns.Value > RandomNumber) {
                tbAns.Text = "小さく";
            } else if(nudAns.Value < RandomNumber){
                tbAns.Text = "大きく";
            } else {
                tbAns.Text = "正解!";
            }
        }

        private void nud1_ValueChanged(object sender, EventArgs e) {
            RandomNumber = rand.Next(1, (int)nud1.Value);
            this.Text = RandomNumber.ToString();
        }
    }
}
