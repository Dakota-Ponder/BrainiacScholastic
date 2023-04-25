using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{
    public partial class Time : Form
    {
        private int countdown = 5;

        public Time()
        {
            InitializeComponent();
            label4.Visible = false;
            label6.Visible = false;
            timer1.Interval = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            countdown = 60 * (int)setTime.Value;

            if (countdown < (60*10))
            {
                countdownlbl.Text = $"00:0{countdown / 60}:00";
            }
            else if (countdown >= (60*10) & countdown < (60*60))
            {
                countdownlbl.Text = $"00:{countdown / 60}:00";
            }
            else
            {
                label4.Visible = true;
                countdownlbl.Text = $"{countdown / 60 / 60} hour";
            }
        }

        private void setTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            countdownlbl.Visible = false;
            startBtn.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            BackColor = Color.Green;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int min = countdown / 60;
            int seconds = countdown / 60 / 60;

            countdown--;
            if (min > 0 && min != 1)
            {
                label6.Text = $" {min} minutes remaining";
                min--;
            }
            else if (min == 1)
            {
                label6.Text = $"{min} minute remaining";
            }
            else if (min == 0)
            {
                label6.Text = $" {countdown} seconds remaining";
            }

            if (countdown < 0)
            {
                BackColor = Color.Crimson;
                label6.Text = " ";
                timer1.Stop();
                TopMost = true;
                MessageBox.Show("TIME'S UP!");
            }
        }

        private void rbtn30_CheckedChanged(object sender, EventArgs e)
        {
            countdown = 30;
            countdownlbl.Text = $"00:00:{countdown}";
        }

        private void rbtn1m_CheckedChanged(object sender, EventArgs e)
        {
            countdown = 60;
            countdownlbl.Text = $"00:00:{countdown}";
        }

        private void rbtn5m_CheckedChanged(object sender, EventArgs e)
        {
            countdown = 60 * 5;
            int timee = countdown / 60;
            countdownlbl.Text = $"00:0{timee}:00";
        }

        private void rbtn15m_CheckedChanged(object sender, EventArgs e)
        {
            countdown = 60 * 15;
            int timee = countdown / 60;
            countdownlbl.Text = $"00:{timee}:00";
        }

        private void rbtn30m_CheckedChanged(object sender, EventArgs e)
        {
            countdown = 60 * 30;
            int timee = countdown / 60;
            countdownlbl.Text = $"00:{timee}:00";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            countdownlbl.Visible = true;
            countdownlbl.Text = "00:00:00";
            startBtn.Visible = true;
            label6.Visible = false;
            label5.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            BackColor = Color.WhiteSmoke;
            countdown = 5;
            timer1.Stop();
        }
    }
}
