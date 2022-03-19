using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Pylon
{
    public partial class TAttendence : UserControl
    {
        public TAttendence()
        {
            InitializeComponent();
        }
        public string ID3;
        DataTable table = new DataTable();
        private void TAttendence_Load(object sender, EventArgs e)
        {
            string s = ID3;
            String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
            String query = "SELECT course FROM Assigned_courses WHERE teacherID = '" + s + "';";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                course2.Items.Add(DR1.GetValue(0).ToString());
            }
            con.Close();
            //string u1 = month.Text;
            //string u2 = date.Text;
            table.Columns.Add("SNo", typeof(int));
            table.Columns.Add("Roll Number", typeof(string));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Status", typeof(string));
            table.Columns["SNo"].ReadOnly = true;
            table.Columns["Roll Number"].ReadOnly = true;
            table.Columns["Date"].ReadOnly = true;
        }
        int p, A = 1;
        string c;

        private void Aupdate_Click(object sender, EventArgs e)
        {
            string str1 = course2.Text;
            string str2 = month.Text + date.Text;
            A--;
            for (int i = 0; i < A; i++)
            {
                String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
                String query = "UPDATE Attendance SET presence = '" + dataGridView1.Rows[i].Cells["Status"].Value.ToString() + "' WHERE rollNumber = '" + dataGridView1.Rows[i].Cells["Roll Number"].Value.ToString() + "' and courseName = '" + str1 + "' and date = '"+str2+"';";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Attendence have been Updated Successfully");
        }

        private void Create1_Click(object sender, EventArgs e){}

        private void Add1_Click(object sender, EventArgs e)
        {
            int j;
            string s1 = ID3;  //Teacher ID
            string s2 = course2.Text;  //Course Name
            string s3 = section2.Text;  //Section
            string s4 = month.Text;
            string s5 = date.Text;

            String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
            String query = "SELECT rollNumber, semester FROM Registered_courses WHERE courseName = '" + s2 + "' and section = '" + s3 + "';";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                string query2 = "INSERT INTO Attendance (rollNumber, courseName, section, semester, date, presence) VALUES ('" + DR1.GetValue(0).ToString() + "', '" + s2 + "', '" + s3 + "', '" + Int32.Parse(DR1.GetValue(1).ToString()) + "', '" + s4 + s5 + "', 'A');";
                SqlConnection con1 = new SqlConnection(str);
                SqlCommand cmd1 = new SqlCommand(query2, con1);
                con1.Open();
                cmd1.ExecuteNonQuery();
                con1.Close();
            }
            con.Close();

            A = 1;
            query = "SELECT rollNumber, date, presence FROM Attendance WHERE courseName = '" + s2 + "' and section = '" + s3 + "';";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                table.Rows.Add(A, DR1.GetValue(0).ToString(), DR1.GetValue(1).ToString(), DR1.GetValue(2).ToString());
                A++;
            }
            con.Close();
            dataGridView1.DataSource = table;
            MessageBox.Show("Attendence has been Added Successfully");
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            A = 1;
        }

        private void date_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            A = 1;
        }

        private void section2_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            A = 1;
        }

        private void course2_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            A = 1;
        }

        private void Search1_Click(object sender, EventArgs e)
        {
            int j;
            string s1 = ID3;  //Teacher ID
            string s2 = course2.Text;  //Course Name
            string s3 = section2.Text;  //Section
            A = 1;

            String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
            String query = "SELECT rollNumber, date, presence FROM Attendance WHERE courseName = '" + s2 + "' and section = '" + s3 + "';";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                table.Rows.Add(A, DR1.GetValue(0).ToString(), DR1.GetValue(1).ToString(), DR1.GetValue(2).ToString());
                A++;
            }
            con.Close();
            dataGridView1.DataSource = table;
        }
    }
}
