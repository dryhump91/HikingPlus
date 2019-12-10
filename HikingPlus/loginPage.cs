using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HikingPlus
{
    public partial class loginPage : Form
    {
        User user1 = new User("admin", "root", true);

        public loginPage()
        {
            InitializeComponent();
        }

        
        

        private void login_btn_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (string.IsNullOrWhiteSpace(userName_txtbx.Text) && (string.IsNullOrWhiteSpace(password_txtbx.Text)))
            {
                MessageBox.Show("Please enter the following: " + "\n" + "Username" + "\n" + "Password");
            }
            else if(string.IsNullOrWhiteSpace(userName_txtbx.Text))
            {
                MessageBox.Show("Please enter your username");
            }
            else if(string.IsNullOrWhiteSpace(password_txtbx.Text))
            {
                MessageBox.Show("Please enter a password");
            }
            else
            {
                bool contains = Globallist.UserList.Any(p => p.userName == userName_txtbx.Text );
                bool contains2 = Globallist.UserList.Any(s => s.password == password_txtbx.Text);
                bool contains3 =Globallist.UserList.Any(i => i.admin == true);
                if (contains && contains2 && contains3)
                {
                    MessageBox.Show("Login successful");

                    this.Hide();
                    Form1 form1 = new Form1(user1.admin);
                    form1.ShowDialog();
                    this.Close();
                    
                    
                }
                else if(contains && contains2)
                {
                   
                    MessageBox.Show("Login successful");

                    this.Hide();
                    Form1 form1 = new Form1(user.admin);
                    form1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Error");
                }
            }

        }

        private void createuser_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userName_txtbx.Text) && (string.IsNullOrWhiteSpace(password_txtbx.Text)))
            {
                MessageBox.Show("Please enter the following: " + "\n" + "Username" + "\n" + "Password");
            }
            else
            {
                User user = new User(userName_txtbx.Text, password_txtbx.Text, false);

                bool contains = Globallist.UserList.Any(p => p.userName == userName_txtbx.Text);

                if (contains)
                {
                    MessageBox.Show("Username already taken." + "\n" + "Please select another");
                }
                else
                {
                    MessageBox.Show("User creation successful");
                    User.AddUserToList(user);

                    this.Hide();
                    Form1 form1 = new Form1(false);
                    form1.ShowDialog();
                    this.Close();
                }

                //if (User.UserList.Contains(new User(userName_txtbx.Text., password_txtbx.Text)))
                //{
                //    MessageBox.Show("Username already taken." + "\n" + "Please select another");
                //}
                //else
                //{
                //    User.AddUserToList(user);
                //}

            }
        }
    }
}
