using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTick.Forms
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            displaDays();
        }
        private void displaDays()
        {
            DateTime now = DateTime.Now;
            //lets get the fisrt day of the month
            DateTime startofthemonth = new DateTime(now.Year,now.Month,1);
            //get the count of day of the month 
            int days = DateTime.DaysInMonth(now.Year,now.Month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            //first lets create a blank usercontrol

        }
    }
}
