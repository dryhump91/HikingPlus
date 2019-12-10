using System;
using System.Data;
using System.Windows.Forms;

namespace HikingPlus
{
    public partial class Form1 : Form, ITooltip
    {
        //public static string hikeName;
        //public static string miles;
        //public static string hours;
        DataTable table = new DataTable();
        newhike hike = new newhike();
        User user = new User();
        Admin adminUser = new Admin();
        


        public Form1()
        {
            InitializeComponent();
            ToolTip();
        }
        public Form1(bool admin)
        {
            InitializeComponent();
            if(admin == false)
            {
                user.Greeting();
            }
            else
            {
                adminUser.Greeting();
            }
            ToolTip();
        }

        public Form1(newhike newhike)
        {
            InitializeComponent();
            this.hike.HikeName = newhike.HikeName;
            this.hike.HikeMiles = newhike.HikeMiles;
            this.hike.HikeHours = newhike.HikeHours;
            this.hike.HikeDate = newhike.HikeDate;
            this.hike.HikeDifficulty = newhike.HikeDifficulty;
        }
        public void ToolTip()
        {
            MessageBox.Show("Welcome to Hiking Plus!" + "\n" + "The only features available right now are the new hike feature." + "\n" + "When you finish with the new hike form please hit the reload button and your hike should appear.");
        }

        private void NewHike_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewHikeInputForm newhike = new NewHikeInputForm();
            newhike.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Miles", typeof(string));
            table.Columns.Add("Hours", typeof(string));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Difficulty", typeof(string));

           

            dataGridView1.DataSource = table;
            
        }

        private void Reload_btn_Click(object sender, EventArgs e)
        {
            DataRow dr1 = table.NewRow();

         

            dr1[0] = hike.HikeName;
            dr1[1] = hike.HikeMiles;
            dr1[2] = hike.HikeHours;
            dr1[3] = hike.HikeDate;
            dr1[4] = hike.HikeDifficulty;


            table.Rows.Add(dr1);

            dataGridView1.DataSource = table;
        }
    }
}
