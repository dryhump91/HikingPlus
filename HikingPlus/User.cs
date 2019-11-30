using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HikingPlus
{
    class User
    {
        public static List<User> UserList = new List<User>();
        public string userName;
        public string password;

 
        


        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            
        }
        public static void AddUserToList(User user)
        {
            UserList.Add(user);
        }
        
    }
}
