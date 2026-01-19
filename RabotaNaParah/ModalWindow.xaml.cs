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
    /// Логика взаимодействия для ModalWindow.xaml
    /// </summary>
    public partial class ModalWindow : Window
    {
        public ModalWindow()
        {
            InitializeComponent();
            Captcha.Content = GenerateCaptcha();

        }


        public string GenerateCaptcha()
        {
            
                Random rand = new Random();
                string captcha = "";
                string chrs = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                int i = 0;
                while (i < 10)
                {
                    captcha += chrs[rand.Next(chrs.Length)];
                    i++;
                }
                return captcha;
            
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CaptchaEnter.Text))
            {
                DialogResult = true;
            }
        }
    }
}
