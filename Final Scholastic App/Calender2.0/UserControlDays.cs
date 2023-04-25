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
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EventList.mdf;Integrated Security=True";

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }
        public void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            timer1.Start();
            //EventForm eventform = new EventForm();
            //eventform.Show();
            CalendarForm2 f2 = new CalendarForm2();
            f2.Show();

        }
        private void displayEvent()
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            string sql = "SELECT * FROM tbl_calendar where date = ?";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@date", CalendarForm1.static_year + "-" + CalendarForm1.static_month + "-" + lbdays.Text);
            //cmd.Parameters.AddWithValue("@event", txtevent.Text);
            //SqlDataReader reader = cmd.ExecuteReader();
            /*if (reader.Read())
            {
                lbevent.Text = reader["event"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();*/
            conn.Close();
            /*ProductListDataContext db = new ProductListDataContext();

            Product prod = new Product();
            prod.Product_Number = textBox1.Text;//  "40-01";
            prod.Description = textBox2.Text;//"Hiking Boots";
            prod.Units_On_Hand = int.Parse(textBox3.Text);// 10;
            prod.Price = decimal.Parse(textBox4.Text);// 299m;
            db.Products.InsertOnSubmit(prod);
            db.SubmitChanges();
            refresh();
            clearTxtBox();*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
