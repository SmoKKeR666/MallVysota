using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using MallVysota.Model;
using Курсач.AppData;
using Курсач.View.Pages;

namespace MallVysota.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FullNameTxb.Text))
            {
                MessageBox.Show("Введите ФИО");
            }
            if (string.IsNullOrWhiteSpace(EnterLoginTxb.Text))
            {
                MessageBox.Show("Введите логин");
            }
            if (string.IsNullOrWhiteSpace(EnterPasswordPb.Password))
            {
                MessageBox.Show("Введите пароль");
            }
            Users users = new Users()
            {
                FullName = FullNameTxb.Text,
                Login = EnterLoginTxb.Text,
                Password = EnterPasswordPb.Password
            };

            App.context.Users.Add(users);
            App.context.SaveChanges();
            MessageBox.Show("Поздравляем с регистрацией!");

            FullNameTxb.Text = "";
            EnterLoginTxb.Text = "";
            EnterPasswordPb.Password = "";

            ClassFrame.mainFrame.Navigate(new EnterPage());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new EnterPage());
        }
    }
}
