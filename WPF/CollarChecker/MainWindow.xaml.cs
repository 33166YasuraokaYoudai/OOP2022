using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
            getColor();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            getColor();
        }


        private void getColor() {
            var Rcolor = Slider1.Value;
            var Gcolor = Slider2.Value;
            var Bcolor = Slider3.Value;
            label.Background = new SolidColorBrush(Color.FromRgb(((byte)Rcolor), ((byte)Gcolor), ((byte)Bcolor)));
        }
        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;
            label.Background = new SolidColorBrush(color);

            int r = color.R;
            int g = color.G;
            int b = color.B;
            Slider1.Value = r;
            Slider2.Value = g;
            Slider3.Value = b;
        }

        private void Border_Loaded(object sender, RoutedEventArgs e) {

        }
        /// <summary>
        /// 色と色名を保持するクラス
        /// </summary>
        public class MyColor {
            public Color Color { get; set; }
            public string Name { get; set; }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            getColor();
            
        }

        

        private void Savebt_Click(object sender, RoutedEventArgs e) {
            var color = $"R:{rText.Text} G:{gText.Text} B:{bText.Text}";
            ColorInfo.Items.Add(color);
        }

        private void ColorInfo_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var colors = ColorInfo.SelectedItem;
            string[] color = colors.ToString().Split(' ');

            rText.Text = color[0].Substring(2);
            gText.Text = color[1].Substring(2);
            bText.Text = color[2].Substring(2);


        }
    }
}
