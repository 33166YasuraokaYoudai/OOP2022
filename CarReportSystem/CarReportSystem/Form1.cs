using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> listPerson = new BindingList<CarReport>();
        public Form1() {
            InitializeComponent();
            dgv.DataSource = listPerson;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btAddition_Click(object sender, EventArgs e) {
            if(String.IsNullOrWhiteSpace(cbRecorder.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }
            CarReport carReport = GetCarReport();
            listPerson.Add(carReport);
        }
        private CarReport GetCarReport() {
            return new CarReport {
                Date = dtpTime.Value,
                Auther = cbRecorder.Text,
                CarName = cbCarName.Text,
                Report = tbReport.Text,

            };
        }


        
        private void btPictureOpen_Click(object sender, EventArgs e) {

        }
    }
}
