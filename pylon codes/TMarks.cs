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
    public partial class TMarks : UserControl
    {
        public TMarks()
        {
            InitializeComponent();
        }
        public string ID2;
        DataTable table = new DataTable();
        private void TMarks_Load(object sender, EventArgs e)
        {
            string s = ID2;

            String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
            String query = "SELECT course FROM Assigned_courses WHERE teacherID = '" + s + "';";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                course1.Items.Add(DR1.GetValue(0).ToString());
            }
            con.Close();
            table.Columns.Add("SNo", typeof(int));
            table.Columns.Add("Roll Number", typeof(string));
            table.Columns.Add("Marks Obtained", typeof(int));
            table.Columns.Add("Total Marks", typeof(int));
            table.Columns["SNo"].ReadOnly = true;
            table.Columns["Roll Number"].ReadOnly = true;
            table.Columns["Total Marks"].ReadOnly = true;
        }

        int p, A = 1;
        string c;
        private void Search1_Click(object sender, EventArgs e)
        {
            string s1 = ID2;  //Teacher ID
            string s2 = course1.Text;  //Course Name
            string s3 = section1.Text;  //Section
            string s4 = category1.Text;// Category

            if (s4 == "quiz01")
            {
                p = 5;
            }
            else if (s4 == "assignment01")
            {
                p = 5;
            }
            else if (s4 == "mid01")
            {
                p = 15;
            }
            else if (s4 == "quiz02")
            {
                p = 5;
            }
            else if (s4 == "assignment02")
            {
                p = 5;
            }
            else if (s4 == "mid02")
            {
                p = 15;
            }
            else if (s4 == "project")
            {
                p = 10;
            }
            else
            {
                p = 40;
            }

            String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
            String query = "SELECT rollNumber, "+s4+" FROM Marks WHERE courseName = '" + s2 + "' and section = '"+s3+"';";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                table.Rows.Add(A, DR1.GetValue(0).ToString(), DR1.GetValue(1).ToString(), p);
                A++;
            }
            con.Close();
            dataGridView1.DataSource = table;
        }

        private void category1_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            A = 1;
        }

        private void section1_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            A = 1;
        }
        private void course1_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            A = 1;
        }

        private void Aupdate_Click(object sender, EventArgs e)
        {
            string str1 = course1.Text;
            string str2 = category1.Text;
            A--;
            for (int i=0; i<A; i++)
            {
                String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
                String query = "UPDATE Marks SET " + str2 + " = " + Int32.Parse(dataGridView1.Rows[i].Cells["Marks Obtained"].Value.ToString()) + " WHERE rollNumber = '"+ dataGridView1.Rows[i].Cells["Roll Number"].Value.ToString()+"' and courseName = '"+str1+"';";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Marks have been Updated Successfully");
        }
    }
}