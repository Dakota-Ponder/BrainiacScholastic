namespace timer
{
    public partial class Timer : Form
    {
        public int countdown = 5;
        public Timer()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            countdown = 60 * (int)setTime.Value;
            label3.Text = $"Timer Set: {countdown} seconds";

        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);

        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            BackColor = Color.Green;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int min = countdown / 60;
            countdown--;
            if (min > 0 && min != 1)
            {
                label3.Text = $" {min} minutes remaining";
                min--;
            }
            else if(min == 1)
            {
                label3.Text = $"{min} minute remaining";
            }
            else if (min == 0)
            {
                label3.Text = $" {countdown} seconds remaining";
            }

            if (countdown < 0)
            {
                BackColor = Color.Crimson;
                label3.Text = " ";
                timer1.Stop();
                TopMost = true;
                MessageBox.Show("TIME'S UP!");
            }
        }

        private void rbtn_30s_CheckedChanged(object sender, EventArgs e)
        {
            countdown = 30;
            label3.Text = $"Timer Set: {countdown} seconds";
        }

        private void rbtn_1min_CheckedChanged(object sender, EventArgs e)
        {
            countdown = 60;
            label3.Text = $"Timer Set: {countdown} seconds";

        }

        private void rbtn_5min_CheckedChanged(object sender, EventArgs e)
        {
            countdown = 60 * 5;
            label3.Text = label3.Text = $"Timer Set: {countdown} seconds";

        }

        private void rbtn_15min_CheckedChanged(object sender, EventArgs e)
        {
            countdown = 60 * 15;
            label3.Text = label3.Text = $"Timer Set: {countdown} seconds";
        }

        private void rbtn_30min_CheckedChanged(object sender, EventArgs e)
        {
            countdown = 60 * 30;
            label3.Text = label3.Text = $"Timer Set: {countdown} seconds";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            panel1.Visible = true;
            panel2.Visible = true;
            BackColor = Color.WhiteSmoke;
            countdown = 5;
            timer1.Stop();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}