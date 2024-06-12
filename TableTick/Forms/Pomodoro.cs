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
    public partial class Pomodoro : Form
    {
        private int timeLeft = 25 * 60; // 25 minutes in seconds
        private bool isRunning = false;
        private bool toggle;
        private int shortBreak = 3;
        private System.Windows.Forms.Timer timer;

        public Pomodoro()
        {
            InitializeComponent();
            tomatoWorking.Hide();
            tomatoBreaking.Hide();
        }


        private void reset(int time, bool isWork)
        {
            ProgressBar.Maximum = 1500;
            if (isWork)
            {
                status.Text = "Working Time !!!";
                tomatoWorking.Show();
                tomatoBreaking.Hide();
            }
            else
            {
                ProgressBar.Maximum = shortBreak < 0 ? 20 * 60 : 5 * 60;
                status.Text = "Breaking Time !!!";
                tomatoBreaking.Show();
                tomatoWorking.Hide();
            }
            timeLeft = time;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += Timer_Tick;
            ProgressBar.Value = time;
            TimeSpan timeSpan = TimeSpan.FromSeconds(time);
            ProgressBar.Text = timeSpan.ToString(@"mm\:ss");

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                ProgressBar.Value = timeLeft;
                TimeSpan timeSpan = TimeSpan.FromSeconds(timeLeft);
                ProgressBar.Value = timeLeft;
                ProgressBar.Text = timeSpan.ToString(@"mm\:ss");
                return;
            }
            if (shortBreak >= 0)
            {
                toggle = !toggle;
            }
            if (toggle)
            {
                reset(1500, true);
                return;
            }
            if (shortBreak == 0)
            {
                shortBreak--;
                reset(20 * 60, false);

            }
            else if (shortBreak > 0)
            {
                shortBreak--;
                reset(300, false);

                // Play notification sound here (optional)
            }
            else
            {
                status.Text = "Session Finished !!!";
                timer.Stop();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            toggle = true;
            reset(1500, true);
            timer.Start();
            isRunning = true;
            status.Text = "Working Time !!!!";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            toggle = false;
            isRunning = false;
            timer.Stop();
            status.Text = "Pomodoro Timer.";
            shortBreak = 3;
            ProgressBar.Value = 1500;
            ProgressBar.Text = @"25:00";
            tomatoBreaking.Hide();
            tomatoWorking.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeLeft = 5;
        }
    }
}

