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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            NextPageButton.IsEnabled = true;
            if((sender as ListBox).SelectedItem is  ListBoxItem choice)
            {
                if (choice == ListBoxItem1) Zakaz.sum = 4000;
                else if (choice == ListBoxItem2) Zakaz.sum = 500;
                else if (choice == ListBoxItem3) Zakaz.sum = 1000000;
                else if (choice == ListBoxItem4) Zakaz.sum = 3;
                else if (choice == ListBoxItem5) Zakaz.sum = 1000;
                else if (choice == ListBoxItem6) Zakaz.sum = 1200000;
            }
            Sum.Content = $"Итого: {Zakaz.sum}";
        }

        private void NextPageButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OptionsPage());
        }
    }
}
