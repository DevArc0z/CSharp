using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Login.Services
{
    internal class UserManager
    {
        private static List<Registration> _users = new List<Registration>();

        public static bool Register(string username, string password)
        {
            foreach(Registration user in _users)
            {
                if(user.UserName.Equals(username))
                {
                    return false;
                }
            }
            Registration newUser = new Registration(username, HashPassword(password));
            _users.Add(newUser);
            return true;

        }

        public static bool TryLogin(string username, string password)
        {
            foreach(Registration user in _users)
            {
                if(user.UserName.Equals(username) && user.Password.Equals(HashPassword(password)))
                {
                    return true;
                }
            }
            return false;
        }
        private static string HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}