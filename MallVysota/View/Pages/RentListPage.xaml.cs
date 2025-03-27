using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
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

namespace Курсач.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RentListPage.xaml
    /// </summary>
    public partial class RentListPage : Page
    {
        public RentListPage()
        {
            InitializeComponent();

            RoomCmb.SelectedValuePath = "ID";
            RoomCmb.DisplayMemberPath = "Name";
            RoomCmb.ItemsSource = App.context.Rooms.ToList();

            DatGr.ItemsSource = App.context.RentMall.ToList();
        }

        private void DatGr_Loaded(object sender, RoutedEventArgs e)
        {
            DatGr.ItemsSource = App.context.RentMall.Where(x => x.IDUsers == App.currentUser.ID).ToList();
        }

        private void RoomCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedRoom = Convert.ToInt32(RoomCmb.SelectedValue);
            DatGr.ItemsSource = App.context.RentMall.Where(room => room.ID == selectedRoom).ToList();

            //int currentMonthPrice = Convert.ToInt32(RoomCmb.SelectedValue);
            //MonthPriceTxtblk.DataContext = App.context.Rooms.Where(mp => mp.MonthPrice == currentMonthPrice).ToList();

            //int currentYearPrice = Convert.ToInt32(RoomCmb.SelectedValue);
            //YearPriceTxtblk.DataContext = App.context.Rooms.Where(yp => yp.YearPrice == currentYearPrice).ToList();

        }

        private void DatGr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void RentRoomBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RoomCmb.Text))
            {
                MessageBox.Show("Выберите помещение");
            }
            if (string.IsNullOrWhiteSpace(FacilityTxb.Text))
            {
                MessageBox.Show("Введите название предприятия");
            }
            if (string.IsNullOrWhiteSpace(RentDateStartDtp.Text))
            {
                MessageBox.Show("Выберите дату начала аренды");
            }
            if (string.IsNullOrWhiteSpace(RentDateEndDtp.Text))
            {
                MessageBox.Show("Выберите дату окончания аренды");
            }
            Rooms rooms = new Rooms()
            {
                Facility = FacilityTxb.Text,
                RentDateStart = (DateTime)RentDateStartDtp.SelectedDate,
                RentDateEnd = (DateTime)RentDateEndDtp.SelectedDate,
                IDRenter = App.currentUser.ID,
                IDRoomStatus = 1
            };

            App.context.Rooms.AddOrUpdate(rooms);
            App.context.SaveChanges();
            MessageBox.Show("Помещение добавлено!");

            RoomCmb.Text = "";
            FacilityTxb.Text = "";
            RentDateStartDtp.Text = "";
            RentDateEndDtp.Text = "";
        }
    }
}
