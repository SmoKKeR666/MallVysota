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
using MallVysota;
using MallVysota.Model;
using MallVysota.View.Pages.MallPages;
using Курсач.AppData;

namespace Курсач.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MallRoomsPage.xaml
    /// </summary>
    public partial class MallRoomsPage : Page
    {
        public MallRoomsPage()
        {
            InitializeComponent();

            DatGr.ItemsSource = App.context.RentMall.ToList();
        }

        private void DatGr_Loaded(object sender, RoutedEventArgs e)
        {
            DatGr.ItemsSource = App.context.RentMall.ToList();
        }

        private void Room1ABtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new Room1APage());
        }

        private void Room1BBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new Room1BPage());
        }

        private void Room1CBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new Room1CPage());
        }

        private void Room2ABtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new Room2APage());
        }

        private void Room2BBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new Room2BPage());
        }

        private void Room2CBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new Room2CPage());
        }
    }
}
