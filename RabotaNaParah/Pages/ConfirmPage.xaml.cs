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

namespace RabotaNaParah.Pages
{
    /// <summary>
    /// Логика взаимодействия для ConfirmPage.xaml
    /// </summary>
    public partial class ConfirmPage : Page
    {
        public ConfirmPage()
        {
            InitializeComponent();
            PizzaLabel.Text += Zakaz.pizza;
            SizeLabel.Text += Zakaz.razmer;
            DopLabel.Text += Zakaz.dop;
            SumTextBlock.Text += Zakaz.sum;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Грациас за заказ!");
        }
    }
}
