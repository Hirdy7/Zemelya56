using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Zemelya56.Models;

namespace Zemelya56.Services
{
    public class UserService
    {
        private List<User> users;
        private readonly string filePath = "users.json";

        public UserService()
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                users = JsonConvert.DeserializeObject < List < User>> (json);
            }
            else
            {
                users = new List<User>();
            }
        }

        public bool Register(User user)
        {
            user.Id = users.Any() ? users.Max(u => u.Id) + 1 : 1;            
            SaveToFile();
            if (users.Any(u => u.Username == user.Username))
            {
                Console.WriteLine("Пользователь существует");
                return false; 
            }
            users.Add(user);            
            SaveToFile();
            return true;
           
        }

        public User Login(string username, string password)
        {
            return users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        private void SaveToFile()
        {
            var json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}