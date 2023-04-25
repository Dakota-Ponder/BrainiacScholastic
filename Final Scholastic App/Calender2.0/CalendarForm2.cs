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
    public partial class CalendarForm2 : Form
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EventList.mdf;Integrated Security=True";
        SqlConnection con;

        public CalendarForm2()
        {
            InitializeComponent();
            date.Text = (CalendarForm1.static_month + "/" + UserControlDays.static_day + "/" + CalendarForm1.static_year);
            ShowEventsForDate(date.Text);
            con = new SqlConnection(conString);

        }
        private void ShowEventsForDate(string date)
        {
            checkedListBox1.Items.Clear();

            // Connect to the database
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                // Build the SQL query to retrieve events on the specified date
                string sql = "SELECT event FROM Event WHERE date = @date";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@date", date);

                // Execute the query and read the results
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    checkedListBox1.Items.Add(reader.GetString(0));
                }

                // Clean up
                reader.Close();
                cmd.Dispose();
                con.Close();
            }
        }


        private void add_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(eventt.Text);

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string insertSql = "INSERT INTO Event (date, event) VALUES (@date, @event)";
                SqlCommand insertCmd = new SqlCommand(insertSql, con);
                insertCmd.Parameters.AddWithValue("@date", date.Text);
                insertCmd.Parameters.AddWithValue("@event", eventt.Text);
                insertCmd.ExecuteNonQuery();

                con.Close();
            }
        }

        private void done_Click(object sender, EventArgs e)
        {
            
                this.Close();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
                string item = checkedListBox1.SelectedItem.ToString();
            //MessageBox.Show(checkedListBox1.SelectedItem.ToString());

            
            // Loop through the checked items and delete them from the database
            if (checkedListBox1.SelectedItem != null && e.NewValue == CheckState.Checked)
                {

                using (SqlConnection con = new SqlConnection(conString))
                    {                    
                        con.Open();

                        // Build the SQL command to delete the item from the database
                        SqlCommand cmd = new SqlCommand("DELETE FROM Event WHERE date = @date AND event = @event", con);
                        cmd.Parameters.AddWithValue("@date", date.Text);
                        cmd.Parameters.AddWithValue("@event", item);

                    // Execute the command and get the number of rows affected
                        cmd.ExecuteNonQuery();

                        // Clean up
                        cmd.Dispose();
                        con.Close();
                }
        }
        }
    }
}

