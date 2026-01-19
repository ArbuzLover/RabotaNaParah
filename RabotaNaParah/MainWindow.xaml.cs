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

namespace RabotaNaParah
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("РЕАЛЬНО БРОСАЕШЬ НАС?", "КИДАЛА", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ModalWindow CaptchaWindow = new ModalWindow();

            if (CaptchaWindow.ShowDialog() == true)
            {
                if (CaptchaWindow.CaptchaEnter.Text.ToString() == CaptchaWindow.Captcha.Content.ToString())
                    MessageBox.Show("Капча пройдена");
                else
                    MessageBox.Show("Капча не пройдена ты ботяра");
            }
            else
            {
                MessageBox.Show("Капча не пройдена ты ботяра");
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            OptionWindow OptionWindow = new OptionWindow();
            if (OptionWindow.ShowDialog() == true)
            {

            }
        }
    }
}
