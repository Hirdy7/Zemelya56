using Zemelya56.Models;
using Zemelya56.ViewModels;
using Zemelya56.Service;
using System;
using System.Windows.Input;


namespace Zemelya56.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private UserService userService;

        public LoginViewModel()
        {
            userService = new UserService();
            LoginCommand = new RelayCommand(Login);
        }

        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged();
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand { get; }

        private void Login()
        {
            var user = userService.Login(username, password);
            if (user != null)
            {
                Console.WriteLine("Успешный вход");
            }
            else
            {
                Console.WriteLine("Ошибка входа"); 
            }
        }
    }
}