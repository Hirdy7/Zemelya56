using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Zemelya56.Models;

namespace Zemelya56.Service
{
    public class UserService
    {
        private List<User> users = new List<User>();

        public bool Register(User user)
        {
            if (users.Any(u => u.Username == user.Username))
            {
                MessageBox.Show("Пользователь существует!");
                return false;
                
            }
            users.Add(user);
            return true;
        }

        public User Authenticate(string username, string password)
        {
            return users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}