using System;
using System.Collections.Generic;

namespace bit285_assignment1_naps.Models
{
    public class UserRepository
    {
        List<User> users = new List<User>();

        public IEnumerable<User> Users
        {
            get { return users; }
        }

        public void AddUsers(User user)
        {
            users.Add(user);
        }
    }
}
