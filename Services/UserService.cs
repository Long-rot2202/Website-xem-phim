using MovieStreamingApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieStreamingApp.Services
{
    public class UserService
    {
        private List<User> Users = new List<User>();

        public bool RegisterUser(User user)
        {
            if (Users.Any(u => u.Username == user.Username)) return false;
            Users.Add(user);
            return true;
        }

        public bool ValidateUser(string username, string password)
        {
            return Users.Any(u => u.Username == username && u.Password == password);
        }
    }
}
