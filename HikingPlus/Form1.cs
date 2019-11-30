using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace HikingPlus
{
    public partial class Form1 : Form
    {
        public static string hikeName;
        public static string miles;
        public static string hours;
        DataTable table = new DataTable();

        

        public Form1()
        {
            InitializeComponent();
        }

        private void NewHike_Btn_Click(object sender, EventArgs e)
        {
            NewHikeInputForm newhike = new NewHikeInputForm();
            newhike.ShowDialog();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    if(NewHikeInputForm.hikeName != "")
        //    {
        //        hikeName = NewHikeInputForm.hikeName;
        //    }
        //}

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (NewHikeInputForm.HikeName != "")
            {
                hikeName = NewHikeInputForm.HikeName;
                miles = NewHikeInputForm.HikeMiles;
                hours = NewHikeInputForm.HikeHours;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Miles", typeof(string));
            table.Columns.Add("Hours", typeof(string));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Difficulty", typeof(string));

            DataRow dr1 = table.NewRow();

            dataGridView1.DataSource = table;
            
        }

        private void Reload_btn_Click(object sender, EventArgs e)
        {
            DataRow dr1 = table.NewRow();

            dr1[0] = NewHikeInputForm.HikeName;
            dr1[1] = NewHikeInputForm.HikeMiles;
            dr1[2] = NewHikeInputForm.HikeHours;
            dr1[3] = NewHikeInputForm.HikeDate;
            dr1[4] = NewHikeInputForm.HikeDifficulty;


            

            table.Rows.Add(dr1);

            dataGridView1.DataSource = table;
        }
    }
}
