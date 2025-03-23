using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MallVysota.Model;

namespace MallVysota
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MallVysotaEntities context = new MallVysotaEntities();

        public static Users currentUser;
    }
}
