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
        List<MyColor> colorlist = new List<MyColor>();
        MyColor mycolor = new MyColor();
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
            
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            GetColor();
        }


        private void GetColor() {
            label.Background = new SolidColorBrush(Color.FromRgb(((byte)Slider1.Value), ((byte)Slider2.Value), ((byte)Slider3.Value)));
            
        }
        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void setColor() {
            var r = byte.Parse(rText.Text);
            var g = byte.Parse(gText.Text);
            var b = byte.Parse(bText.Text);
            Color color = Color.FromRgb(r, g, b);
            label.Background = new SolidColorBrush(color);

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Slider1.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.R;
            Slider2.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.G;
            Slider3.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.B;
            setColor();
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
            GetColor();
            
        }

        

        private void Savebt_Click(object sender, RoutedEventArgs e) {
            var stColor = getMyColor(byte.Parse(rText.Text), byte.Parse(gText.Text), byte.Parse(bText.Text));
           
            
            //var color = $"R:{rText.Text} G:{gText.Text} B:{bText.Text}";
            //ColorInfo.Items.Add(color);
            ColorInfo.Items.Insert(0, stColor?.Name ?? "R:" + stColor.Color.R + "G:" + stColor.Color.G + "B:" + stColor.Color.B);
            colorlist.Insert(0, stColor);
            
        }
        private MyColor getMyColor(byte r,byte g,byte b) {

            return new MyColor {
                Color = Color.FromRgb(r, g, b),
                Name = ((IEnumerable<MyColor>)DataContext)
                                    .Where(c => c.Color.R == r &&
                                               c.Color.G == g &&
                                               c.Color.B == b)
                                    .Select(c => c.Name).FirstOrDefault(),
            };
        }

        private void Deletebt_Click(object sender, RoutedEventArgs e) {

            ColorInfo.Items.Remove(ColorInfo.SelectedItem);
            
        }

        private void ColorInfo_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            //var colors = ColorInfo.SelectedItem;
            //string[] color = colors.ToString().Split(' ');
            //rText.Text = color[0].Substring(2);
            //gText.Text = color[1].Substring(2);
            //bText.Text = color[2].Substring(2);
            if(ColorInfo.SelectedIndex != -1) {
                Slider1.Value = colorlist[ColorInfo.SelectedIndex].Color.R;
                Slider2.Value = colorlist[ColorInfo.SelectedIndex].Color.G;
                Slider3.Value = colorlist[ColorInfo.SelectedIndex].Color.B;
            }
            
            GetColor();


        }
    }
}
