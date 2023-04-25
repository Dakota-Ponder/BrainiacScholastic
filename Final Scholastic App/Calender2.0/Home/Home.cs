using Calender2._0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scholastic_App
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void rscBtn_Click(object sender, EventArgs e)
        {
            var openRsc = new Resourcesss();
            openRsc.ShowDialog();
        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void dateTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString(); 
        }

        private void calndrBtn_Click(object sender, EventArgs e)
        {
            var openCal = new CalendarForm1();
            openCal.ShowDialog();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void tmrBtn_Click(object sender, EventArgs e)
        {
            var openTimer = new Time.Time();
            openTimer.ShowDialog();
        }

        private void gameBtn_Click(object sender, EventArgs e)
        {
            var openGames = new Games.GamesForm();
            openGames.ShowDialog();
        }

        private void stdyBtn_Click(object sender, EventArgs e)
        {
            var openStudy = new Brainiac.Form1();
            openStudy.ShowDialog();
        }
    }
}
