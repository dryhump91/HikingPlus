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
    public partial class NewHikeInputForm : Form
    {
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

        public NewHikeInputForm()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            HikeName = Name_txtbx.Text;
            hikeMiles = Miles_txtbx.Text;
            hikeHours = Hours_txtbx.Text;
            hikeDate = this.dateTimePicker1.Value.Date;
            hikeDifficulty = Difficulty_trackBar.Value.ToString();



            this.Close();
        }
    }
}
