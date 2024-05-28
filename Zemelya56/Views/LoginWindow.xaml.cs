using System.Windows;
using Zemelya56.Service;

namespace Zemelya56.Views
{
    public partial class LoginWindow : Window
    {
        private UserService userService = new UserService();

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var user = userService.Authenticate(Username.Text, Password.Password);
            if (user != null)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow(userService);
            registerWindow.ShowDialog();
        }
    }
}