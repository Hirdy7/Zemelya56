using System.Windows;
using Zemelya56.Service;
using Zemelya56.ViewModels;

namespace Zemelya56.Views
{
    public partial class LoginWindow : Window
    {
        private readonly LoginViewModel loginViewModel;

        public LoginWindow()
        {
            InitializeComponent();
            var userService = new UserService();
            loginViewModel = new LoginViewModel(userService);
            DataContext = loginViewModel;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (loginViewModel.Login())
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
            var registerWindow = new RegisterWindow(new UserService());
            registerWindow.Show();
        }
    }
}
