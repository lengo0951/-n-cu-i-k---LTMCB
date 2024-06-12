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
        }


        private void reset(int time, bool isWork)
        {
            timeLeft = time;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += Timer_Tick;
            ProgressBar.Value = time;
            TimeSpan timeSpan = TimeSpan.FromSeconds(time);
            ProgressBar.Text = timeSpan.ToString(@"mm\:ss");
            if (isWork)
            {
                status.Text = "Working Time !!!";
            }
            else
            {
                status.Text = "Breaking Time !!!";
            }
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
            if (shortBreak > 0)
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

        private void pauseButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            isRunning = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            shortBreak = 3;
            reset(1500, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeLeft = 5;
        }
    }
}

