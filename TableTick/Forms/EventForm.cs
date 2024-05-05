using System;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using FireSharp;
using FirebaseClient = Firebase.Database.FirebaseClient; // Alias for Firebase.Database
//using FirebaseClient = FireSharp.FirebaseClient; // Alias for FireSharp, uncomment this line if you want to use FireSharp

namespace TableTick.Forms
{
    public partial class EventForm : Form
    {
        // Khai báo biến cho FirebaseClient
        private readonly FirebaseClient firebase = new FirebaseClient("https://tabletick-33966-default-rtdb.asia-southeast1.firebasedatabase.app/");

        public EventForm()
        {
            InitializeComponent();
        }
        private void EventForm_Load(object sender, EventArgs e)
        {
            // call the static var we declare
            txdate.Text = Calendar.static_month+"/"+UserControlDays.static_day + "/" + Calendar.static_year;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Lưu ý: txdate và txevent cần phải được khai báo trong Form của bạn,
            // và phải là các control TextBox hoặc các control tương tự để nhập dữ liệu.
            var date = txdate.Text;
            var eventName = txevent.Text;

            var eventItem = new Event
            {
                Date = date,
                EventName = eventName
            };

            // Thêm sự kiện mới vào Firebase Database vào node "tbl_calendar"
            await firebase
                .Child("tbl_calendar")
                .PostAsync(eventItem);

            MessageBox.Show("Event saved to Firebase Database!");
        }

        // Định nghĩa class Event cho dữ liệu sự kiện
        public class Event
        {
            public string Date { get; set; }
            public string EventName { get; set; }
        }
    }
}
