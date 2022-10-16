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
using System.Drawing;

namespace ColorPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ColorViewModel VMColor;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = VMColor;
            alphaSlider.Value = 0;
            redSlider.Value = 0;
            greenSlider.Value = 0;
            blueSlider.Value = 0;
        }

        private void redSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            box.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb((byte)VM.Alpha, (byte)VM.Red, (byte)VM.Green, (byte)VM.Blue));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var data = DataContext as ColorViewModel;
            data.colorList.Add(new ListBoxItem() { Content = data.model, Background = new SolidColorBrush() { Color = System.Windows.Media.Color.FromArgb((byte)data.Alpha, (byte)data.Red, (byte)data.Green, (byte)data.Blue) } });
            listbox.Items.Add(VM.colorList[VM.colorList.Count - 1]);
        }
    }
}
