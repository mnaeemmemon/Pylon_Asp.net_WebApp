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
    public partial class SAttendence : UserControl
    {
        public SAttendence()
        {
            InitializeComponent();
        }
        public string ID3;
        DataTable table = new DataTable();
        private void SAttendence_Load(object sender, EventArgs e)
        {
            string s = ID3;

            String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
            String query = "SELECT courseName FROM Registered_courses WHERE rollNumber = '" + s + "';";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                course2.Items.Add(DR1.GetValue(0).ToString());
            }
            con.Close();
            table.Columns.Add("SNo", typeof(int));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Status", typeof(string));
        }
        int A = 1;
        private void Search1_Click(object sender, EventArgs e)
        {
            string s = ID3;

            String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
            String query = "SELECT dateOfAttendance, presence FROM Attendance WHERE rollNumber = '" + s + "' and courseName = '" + course2.Text + "';";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                table.Rows.Add(A, DR1.GetValue(0).ToString(), DR1.GetValue(1).ToString());
                A++;
            }
            con.Close();
            dataGridView1.DataSource = table;
        }

        private void course2_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            A = 1;
        }
    }
}
