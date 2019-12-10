using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HikingPlus 
{
    class Admin : Superuser
    {
        

       public Admin()
        {

        }

        public override void deleteusers(List<User> userlist)
        {
            Globallist.UserList.Clear();
        }

        //example of intitial method being "polymorphed"
        public void Greeting()
        {
            MessageBox.Show("Welcome Admin!");
        }

    }
}
