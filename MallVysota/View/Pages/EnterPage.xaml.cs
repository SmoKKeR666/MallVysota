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
using MallVysota.View.Pages;
using Курсач.AppData;
using Курсач.View.Windows;

namespace Курсач.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для EnterPage.xaml
    /// </summary>
    public partial class EnterPage : Page
    {
        public EnterPage()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (string.IsNullOrEmpty(EnterLoginTxb.Text) && string.IsNullOrEmpty(EnterPasswordPb.Password)) 
            {
                MessageBox.Show("Введите логин и пароль");
            }
            else if (string.IsNullOrEmpty(EnterLoginTxb.Text))
            {
                MessageBox.Show("Введите логин");
            }
            else if (string.IsNullOrEmpty(EnterPasswordPb.Password))
            {
                MessageBox.Show("Введите пароль");
            }
            else
            {
                App.currentUser = App.context.Users.FirstOrDefault(user => user.Login == EnterLoginTxb.Text && user.Password == EnterPasswordPb.Password);

                if (App.currentUser != null)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                }    
            }
        }


        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.mainFrame.Navigate(new RegistrationPage());
        }
    }
}
