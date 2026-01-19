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
using System.Windows.Shapes;

namespace RabotaNaParah
{
    /// <summary>
    /// Логика взаимодействия для OptionWindow.xaml
    /// </summary>
    public partial class OptionWindow : Window
    {
        public OptionWindow()
        {
            InitializeComponent();
            
        }
        private void WidthSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Application.Current.MainWindow.Width = WidthSlider.Value;
        }

        private void HeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Application.Current.MainWindow.Height = HeightSlider.Value;
        }

        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Background = Brushes.Red;
        }

        private void GreenButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Background = Brushes.Green;
        }

        private void BlueButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Background = Brushes.Blue;
        }

        private void YellowButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Background = Brushes.Yellow;
        }
    }
}
