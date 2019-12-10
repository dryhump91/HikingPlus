using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HikingPlus 
{
    class Admin : User
    {
        

       public Admin()
        {

        }

        public static void deleteUsers(List<User> userlist)
        {
            Globallist.UserList.Clear();
        }

        public void Greeting()
        {
            MessageBox.Show("Welcome Admin!");
        }

    }
}
