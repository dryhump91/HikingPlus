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
    public partial class NewHikeInputForm : Form, ITooltip
    {

        #region NewHikeInputForm Properties
        private static string hikeName;
        private static string hikeMiles;
        private static string hikeHours;
        private static DateTime hikeDate;
        private static string hikeDifficulty;
        
        
        public static string HikeName { get => hikeName; set => hikeName = value; }
        public static string HikeMiles { get => hikeMiles; set => hikeMiles = value; }
        public static string HikeHours { get => hikeHours; set => hikeHours = value; }
        public static DateTime HikeDate { get => hikeDate; set => hikeDate = value; }
        public static string HikeDifficulty { get => hikeDifficulty; set => hikeDifficulty = value; }

        #endregion

        #region NewHikeInputForm Constructors
        public NewHikeInputForm()
        {
            InitializeComponent();
            ToolTip();

        }
        #endregion

        #region NewHikeInputForm Methods
        public void ToolTip()
        {
            MessageBox.Show("Welcome to the New Hike input section!" + "\n" + "Please fill out all sections!");
        }
        #endregion
        #region NewHikeInputForm Events
        private void Submit_btn_Click(object sender, EventArgs e)
        {
            decimal numeric;
            decimal hoursNum;
            if(decimal.TryParse(Miles_txtbx.Text, out numeric) && decimal.TryParse(Hours_txtbx.Text, out hoursNum))
            {
                newhike newhike = new newhike(Name_txtbx.Text, Miles_txtbx.Text, Hours_txtbx.Text, this.dateTimePicker1.Value.Date, Difficulty_trackBar.Value.ToString());
                this.Hide();
                Form1 form1 = new Form1(newhike);
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid new hike information" + "\n" + "Miles and hours must be numeric.");
                Miles_txtbx.Clear();
                Hours_txtbx.Clear();
            }        
        }
        #endregion

    }
}
