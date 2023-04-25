using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Calender2._0
{
    public partial class EventForm : Form
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EventList.mdf;Integrated Security=True";
        public EventForm()
        {
            InitializeComponent();
        }
        public void EventForm_Load(object sender, EventArgs e)
        {
            txtdate.Text = (CalendarForm1.static_year +"/"+ CalendarForm1.static_month + "/"+ UserControlDays.static_day);
        }
        public void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(conString);
            db.Open();
            String sql = "INSERT INTO tbl calendar(date, event)values(?,?)";
            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", txtdate.Text);
            cmd.Parameters.AddWithValue("event", txtevent.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            cmd.Dispose();
            db.Close();

        }
    }
}
