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
        public loginPage()
        {
            InitializeComponent();
        }

        
        

        private void login_btn_Click(object sender, EventArgs e)
        {
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
                bool contains = User.UserList.Any(p => p.userName == userName_txtbx.Text );
                bool contains2 = User.UserList.Any(s => s.password == password_txtbx.Text);

                if (contains && contains2)
                {
                    MessageBox.Show("Login successful");

                    this.Hide();
                    Form1 form1 = new Form1();
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
                User user = new User(userName_txtbx.Text, password_txtbx.Text);

                bool contains = User.UserList.Any(p => p.userName == userName_txtbx.Text);

                if (contains)
                {
                    MessageBox.Show("Username already taken." + "\n" + "Please select another");
                }
                else
                {
                    MessageBox.Show("User creation successful");
                    User.AddUserToList(user);

                    Form1 form1 = new Form1();
                    form1.ShowDialog();
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
