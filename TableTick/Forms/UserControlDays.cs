using System;
using System.Drawing;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace TableTick.Forms
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        private ToolTip toolTip;
        private IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "Tt2HjOm0bxRwwUL9NFsg6ONtEP3piyFWSQxXAK78",
            BasePath = "https://tabletick-33966-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        private IFirebaseClient client;

        public UserControlDays()
        {
            InitializeComponent();
            SetupUI();
            toolTip = new ToolTip();
        }

        private void SetupUI()
        {
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
            lbdays.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            lbdays.TextAlign = ContentAlignment.MiddleCenter;
            lbdays.Dock = DockStyle.Fill;
            this.MouseHover += UserControlDays_MouseHover;
        }

        private async void UserControlDays_MouseHover(object sender, EventArgs e)
        {
            if (client == null)
            {
                client = new FireSharp.FirebaseClient(config);
            }

            string date = $"{Calendar.static_year}-{Calendar.static_month}-{lbdays.Text}";
            FirebaseResponse response = await client.GetAsync($"tbl_calendar/{date}");
            var eventItem = response.ResultAs<Event>();

            if (eventItem != null)
            {
                toolTip.SetToolTip(this, $"Event: {eventItem.EventName}");
            }
            else
            {
                toolTip.SetToolTip(this, "No events");
            }
        }

        private void UserControlDays_Load(object sender, EventArgs e) { }

        public void days(int numday)
        {
            lbdays.Text = numday.ToString();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            EventForm eventform = new EventForm();
            eventform.Show();
        }

        public class Event
        {
            public string Date { get; set; }
            public string EventName { get; set; }
        }
    }
}
