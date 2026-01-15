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
using System.Xml.Serialization;

namespace RabotaNaParah.Pages
{
    /// <summary>
    /// Логика взаимодействия для OptionsPage.xaml
    /// </summary>
    public partial class OptionsPage : Page
    {
        double NewSum,DopOpt = 0;
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
        string dobavki;
        private void ButtonChoice_Click(object sender, RoutedEventArgs e)
        {
            dobavki += choice.Content.ToString() + ", ";
            ChoiceLabel.Content = "Вы выбрали: " + dobavki;
            if (choice == ComboBoxItem1) DopOpt += 50;
            else if (choice == ComboBoxItem2) DopOpt += 80;
            else if (choice == ComboBoxItem3) DopOpt += 40;
            else if (choice == ComboBoxItem4) DopOpt += 1000;
            else if (choice == ComboBoxItem0) DopOpt += 0;
            SumLabel.Content = $"Итого: {DopOpt+NewSum} ";
            Zakaz.dop = ChoiceLabel.Content.ToString();
        }

        

        private void MinSize_Checked(object sender, RoutedEventArgs e)
        {
            NewSum = Zakaz.sum;
            Zakaz.razmer = MinSize.Content.ToString();
        }

        private void AverageSize_Checked(object sender, RoutedEventArgs e)
        {
            NewSum = Zakaz.sum*1.2;
            Zakaz.razmer = AverageSize.Content.ToString();
        }

        private void MaxSize_Checked(object sender, RoutedEventArgs e)
        {
            NewSum += Zakaz.sum*1.4;
            Zakaz.razmer = MaxSize.Content.ToString();
        }
        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            Zakaz.sum = NewSum + DopOpt;
            NavigationService.Navigate(new ConfirmPage());
        }
    }
}
