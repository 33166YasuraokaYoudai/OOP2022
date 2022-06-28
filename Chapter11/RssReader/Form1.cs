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
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        List<string> xTitle = new List<string>();
        List<string> xLink = new List<string>();


        public Form1() {
            InitializeComponent();
        }

        private void btRssGet_Click(object sender, EventArgs e) {

            using (var wc = new WebClient()) {
                var stream = wc.OpenRead(cbRssUrl.Text);

                var xdoc = XDocument.Load(stream);
                var xTitle = xdoc.Root.Descendants("item").Select(a => (string)a.Element("title"));
                var xLink = xdoc.Root.Descendants("item").Select(a => (string)a.Element("link"));
                foreach (var RssData in xTitle) {
                    lbRssTitle.Items.Add(RssData);
                }
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            var getindex = lbRssTitle.SelectedIndex;
           
        }
    }
}
