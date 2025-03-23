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
using MallVysota.View.Pages;
using Курсач.AppData;
using Курсач.View.Windows;

namespace Курсач.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void StartPageBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new StartPage());
        }

        private void RentPageBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new MallRoomsPage());
            
        }

        private void ListPageBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new RentListPage());
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
        }

        private void InformationPageBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new InformationPage());
        }
    }
}
