using System;
using System.Globalization;
using System.Windows.Forms;

namespace TableTick.Forms
{
    public partial class Calendar : Form
    {
        int month, year;
        public static int static_month, static_year;

        public Calendar()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.BackColor = Color.WhiteSmoke;

            LBDATE.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            LBDATE.ForeColor = Color.Black;

            btnnext.Font = new Font("Segoe UI", 10);
            btnprevious.Font = new Font("Segoe UI", 10);

            btnnext.BackColor = Color.LightBlue;
            btnprevious.BackColor = Color.LightBlue;

            btnnext.ForeColor = Color.White;
            btnprevious.ForeColor = Color.White;

            btnnext.FlatStyle = FlatStyle.Flat;
            btnprevious.FlatStyle = FlatStyle.Flat;

            btnnext.FlatAppearance.BorderSize = 0;
            btnprevious.FlatAppearance.BorderSize = 0;
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthname = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
            LBDATE.Text = $"{monthname} {year}";

            static_month = month;
            static_year = year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek) + 1;

            daycontainer.Controls.Clear();

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            DisplayDays();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }
            DisplayDays();
        }
    }
}
