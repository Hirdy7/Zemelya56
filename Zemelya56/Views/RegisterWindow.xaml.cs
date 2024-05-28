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
using System.Windows.Shapes;
using Zemelya56.Models;
using Zemelya56.Services;

namespace Zemelya56.Views
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private UserService userService;
        public RegisterWindow(UserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            User user = new User
            {
                Username = Username.Text,
                Password = Password.Password,
                Email = Email.Text
            };

            if (userService.Register(user))
            {
                MessageBox.Show("Registration successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("Username already exists");
            }
        }
    }
}
