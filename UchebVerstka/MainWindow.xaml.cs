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

namespace UchebVerstka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<StatusUser> list = new List<StatusUser>()
            {
            new StatusUser()
            {
                Id = 1, LName = "Ivanov", FName = "Ivan", Age = 15, City = "Kazan"
            },
            new StatusUser() 
            { 
            Id = 1 , LName = "Petrov", FName = "Ivan", Age = 15, City = "Kazan" 
            }
            };
            LVStatus.ItemsSource = list;
            
        }
    }
}
