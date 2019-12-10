using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HikingPlus
{

    class User
    {
        
        public string userName;
        public string password;
        public bool admin = false;

        
        public User() { }

        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            
        }
        public User(string userName, string password, bool admin)
        {
            this.userName = userName;
            this.password = password;
            this.admin = admin;
        }
        public static void AddUserToList(User user)
        {
            Globallist.UserList.Add(user);
        }

        public void Greeting()
        {
            MessageBox.Show("Welcome to Hiker Plus!");
        }
        
    }
}
