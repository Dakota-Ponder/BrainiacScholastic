using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scholastic_App
{
    public partial class Resourcesss : Form
    {
        public Resourcesss()
        {
            InitializeComponent();
        }

        private void d2lBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://elearn.mtsu.edu/d2l/home");
        }

        private void emailBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://outlook.office.com/mail/");
        }

        private void lbryBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://library.mtsu.edu/home");
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pipeline.mtsu.edu/");
        }

        private void opnBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://google.com/");
        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
