using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Zemelya56.Service;
using Zemelya56.Models;

namespace Zemelya56.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private readonly UserService userService;
        private string username;
        private string password;

        public LoginViewModel(UserService userService)
        {
            this.userService = userService;
        }

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool Login()
        {
            var user = userService.Authenticate(username, password);
            if (user != null)
            {
                return true;
            }
            return false;
        }
    }
}