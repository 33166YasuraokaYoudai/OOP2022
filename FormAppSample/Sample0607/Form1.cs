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

        private void dt_Random_Click(object sender, EventArgs e) {
            var rand = new Random();
            Number.Value = rand.Next(minValue:(int)nudMin.Value,maxValue:(int)nudMax.Value + 1);
        }
    }
}
