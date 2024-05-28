using System.Windows;
using Zemelya56.Models;
using Zemelya56.Service;

namespace Zemelya56.Views
{
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