using Lecture30_databinding_wpf.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lecture30_databinding_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List<User> userList = new List<User>();
        ObservableCollection<User> userList = new ObservableCollection<User>();
        public MainWindow()
        {
            InitializeComponent();
            userList.Add(new User {Name="Ali", Age=12 });
            userList.Add(new User { Name = "Ibrahim", Age = 22 });
            userList.Add(new User { Name = "Usman", Age = 32 });
            lstUser.ItemsSource = userList;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            userList.Add(new User { Name = "New User", Age = 42 });
        }

        private void btnUpdateUser_Click(object sender, RoutedEventArgs e)
        {
            if (lstUser.SelectedItem != null) {
                (lstUser.SelectedItem as User).Name = "Mustafa";
            }
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (lstUser.SelectedItem != null) {
                userList.Remove(lstUser.SelectedItem as User);
            }
        }
    }
}
