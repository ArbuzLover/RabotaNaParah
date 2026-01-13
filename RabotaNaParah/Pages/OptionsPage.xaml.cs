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
    /// Логика взаимодействия для OptionsPage.xaml
    /// </summary>
    public partial class OptionsPage : Page
    {
        double NewSum,DopOpt;
        public OptionsPage()
        {
            InitializeComponent();
            MinSize.Content = $"Маленькая: {Zakaz.sum}";
            AverageSize.Content = $"Средняя: {Zakaz.sum * 1.2}";
            MaxSize.Content = $"Большая: {Zakaz.sum *1.4}";
        }
        ComboBoxItem choice;
        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            choice = (sender as ComboBox).SelectedItem as ComboBoxItem;
        }
        private void ButtonChoice_Click(object sender, RoutedEventArgs e)
        {
            ChoiceLabel.Content = "Вы выбрали: " + choice.Content.ToString();
            if (choice == ComboBoxItem1) DopOpt = 50;
            else if (choice == ComboBoxItem2) DopOpt = 80;
            else if (choice == ComboBoxItem3) DopOpt = 40;
            else if (choice == ComboBoxItem4) DopOpt = 1000;
            SumLabel.Content = $"Итого: {DopOpt+NewSum} ";
        }

        

        private void MinSize_Checked(object sender, RoutedEventArgs e)
        {
            NewSum = Zakaz.sum;
        }

        private void AverageSize_Checked(object sender, RoutedEventArgs e)
        {
            NewSum = Zakaz.sum*1.2;
        }

        private void MaxSize_Checked(object sender, RoutedEventArgs e)
        {
            NewSum += Zakaz.sum*1.4;
        }
        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            Zakaz.sum = NewSum + DopOpt;
            NavigationService.Navigate(new ConfirmPage());
        }
    }
}
