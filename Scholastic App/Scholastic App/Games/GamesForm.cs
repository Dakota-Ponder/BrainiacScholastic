using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scholastic_App.Games
{
    public partial class GamesForm : Form
    {
        public GamesForm()
        {
            InitializeComponent();
        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void blackjack_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/k C:\\Users\\jayvo\\Desktop\\cuhz\\BlackJack.exe");
        }
    }
}
