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

namespace MallVysota.View.Pages.MallPages
{
    /// <summary>
    /// Логика взаимодействия для Room1BPage.xaml
    /// </summary>
    public partial class Room1BPage : Page
    {
        public Room1BPage()
        {
            InitializeComponent();

            DatGr.ItemsSource = App.context.RentMall.ToList();

            MonthPriceTxtblk.DataContext = App.context.Rooms.ToList();
            YearPriceTxtblk.DataContext = App.context.Rooms.ToList();
        }

        private void RentRoomBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RoomCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DatGr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DatGr_Loaded(object sender, RoutedEventArgs e)
        {
            DatGr.ItemsSource = App.context.RentMall.ToList();
        }
    }
}
