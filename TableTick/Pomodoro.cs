using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private int timeLeft = 25 * 60; // 25 minutes in seconds
        private bool isRunning = false;
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();

            // Set up the timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                TimeSpan timeSpan = TimeSpan.FromSeconds(timeLeft);
                remainingTimeLabel.Text = timeSpan.ToString(@"mm\:ss");
            }
            else
            {
                timer.Stop();
                isRunning = false;
                // Play notification sound here (optional)
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                timer.Start();
                isRunning = true;
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer.Stop();
                isRunning = false;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timeLeft = 25 * 60;
            remainingTimeLabel.Text = @"25:00";
            timer.Stop();
            isRunning = false;
        }
    }
}

