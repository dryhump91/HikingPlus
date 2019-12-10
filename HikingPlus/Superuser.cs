using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HikingPlus
{
    abstract class Superuser
    {
        public abstract void deleteusers(List<User> userlist);

        //example of polymorphism 1a
        public void greeting()
        {
            MessageBox.Show("Users should not see this placeholder");
        }
    }
}
