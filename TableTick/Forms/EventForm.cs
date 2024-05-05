using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;



namespace TableTick.Forms
{
    public partial class EventForm : Form
    {
        //create connectionstring 
        String connString = "server=loclahost;user id=root;database=db calendar;ssmode=none";
        // i already created a datebase using xampp

        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }
    }
}
