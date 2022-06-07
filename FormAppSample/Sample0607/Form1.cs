using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {

            if(tbNum2.Text == 0.ToString()){
                MessageBox.Show("計算できない","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);

            } else {
                nudAns.Value = nudNum1.Value / nudNum2.Value;
                nudMod.Value = nudNum1.Value % nudNum2.Value;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {

        }
    }
}
