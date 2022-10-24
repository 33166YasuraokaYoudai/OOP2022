using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        Random rand = new Random(); 
        private int coorectNumber; //正解Number

        public MainWindow() {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Button bt = (Button)sender;
            if((String)bt.Content == coorectNumber.ToString()) {
                infoDisp.Text = "正解";
                bt.Background = Brushes.Red;
            } else {
                infoDisp.Text = int.Parse((string)bt.Content) < coorectNumber
                                                    ? "もっと大きいです!" : "もっと小さいです！";
                bt.Background = int.Parse((string)bt.Content) < coorectNumber
                                                    ? Brushes.Blue : Brushes.Yellow;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            infoDisp.Text = "ゲームスタート";
            coorectNumber = rand.Next(25) + 1; //正解Numberを設定
            this.Title = coorectNumber.ToString(); //デバック用
        }
    }
}
