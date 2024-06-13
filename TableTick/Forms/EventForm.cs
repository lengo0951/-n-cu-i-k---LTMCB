using System;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace TableTick.Forms
{
    public partial class EventForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "Tt2HjOm0bxRwwUL9NFsg6ONtEP3piyFWSQxXAK78",
            BasePath = "https://tabletick-33966-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        public EventForm()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txdate.Text = $"{Calendar.static_month}/{UserControlDays.static_day}/{Calendar.static_year}";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var date = txdate.Text;
            var eventName = txevent.Text;

            var eventItem = new Event
            {
                Date = date,
                EventName = eventName
            };

            string formattedDate = $"{Calendar.static_year}-{Calendar.static_month}-{UserControlDays.static_day}";

            try
            {
                SetResponse response = await client.SetAsync($"tbl_calendar/{formattedDate}", eventItem);
                MessageBox.Show("Đã thêm sự kiện!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        public class Event
        {
            public string Date { get; set; }
            public string EventName { get; set; }
        }
    }
}
