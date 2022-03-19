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
    public partial class STranscript : UserControl
    {
        public STranscript()
        {
            InitializeComponent();
        }
        public string ID7;
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();
        DataTable table3 = new DataTable();
        DataTable table4 = new DataTable();
        DataTable table5 = new DataTable();
        DataTable table6 = new DataTable();
        DataTable table7 = new DataTable();
        DataTable table8 = new DataTable();

        private void STranscript_Load(object sender, EventArgs e)
        {
            int A = 1;
            table1.Columns.Add("SNo", typeof(int));
            table1.Columns.Add("Course Name", typeof(string));
            table1.Columns.Add("Course Grade", typeof(string));
            table1.Columns.Add("Course SGPA", typeof(string));

            table2.Columns.Add("SNo", typeof(int));
            table2.Columns.Add("Course Name", typeof(string));
            table2.Columns.Add("Course Grade", typeof(string));
            table2.Columns.Add("Course SGPA", typeof(string));

            table3.Columns.Add("SNo", typeof(int));
            table3.Columns.Add("Course Name", typeof(string));
            table3.Columns.Add("Course Grade", typeof(string));
            table3.Columns.Add("Course SGPA", typeof(string));

            table4.Columns.Add("SNo", typeof(int));
            table4.Columns.Add("Course Name", typeof(string));
            table4.Columns.Add("Course Grade", typeof(string));
            table4.Columns.Add("Course SGPA", typeof(string));

            table5.Columns.Add("SNo", typeof(int));
            table5.Columns.Add("Course Name", typeof(string));
            table5.Columns.Add("Course Grade", typeof(string));
            table5.Columns.Add("Course SGPA", typeof(string));

            table6.Columns.Add("SNo", typeof(int));
            table6.Columns.Add("Course Name", typeof(string));
            table6.Columns.Add("Course Grade", typeof(string));
            table6.Columns.Add("Course SGPA", typeof(string));

            table7.Columns.Add("SNo", typeof(int));
            table7.Columns.Add("Course Name", typeof(string));
            table7.Columns.Add("Course Grade", typeof(string));
            table7.Columns.Add("Course SGPA", typeof(string));

            table8.Columns.Add("SNo", typeof(int));
            table8.Columns.Add("Course Name", typeof(string));
            table8.Columns.Add("Course Grade", typeof(string));
            table8.Columns.Add("Course SGPA", typeof(string));
            
            dataGridViewA.DataSource = table1;
            dataGridViewB.DataSource = table2;
            dataGridViewC.DataSource = table3;
            dataGridViewD.DataSource = table4;
            dataGridViewE.DataSource = table5;
            dataGridViewF.DataSource = table6;
            dataGridViewG.DataSource = table7;
            dataGridViewH.DataSource = table8;

            string s = ID7;

            String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";

            String query = "SELECT courseName, courseGrade, sGpa FROM Transcript WHERE rollNumber = '" + s + "' and semester = 1;";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                table1.Rows.Add(A, DR1.GetValue(0).ToString(), DR1.GetValue(1).ToString(), DR1.GetValue(2).ToString());
                A++;
            }
            con.Close();
            dataGridViewA.DataSource = table1;
            A = 1;

            query = "SELECT courseName, courseGrade, sGpa FROM Transcript WHERE rollNumber = '" + s + "' and semester = 2;";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                table2.Rows.Add(A, DR1.GetValue(0).ToString(), DR1.GetValue(1).ToString(), DR1.GetValue(2).ToString());
                A++;
            }
            con.Close();
            dataGridViewB.DataSource = table2;
            A = 1;

            query = "SELECT courseName, courseGrade, sGpa FROM Transcript WHERE rollNumber = '" + s + "' and semester = 3;";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                table3.Rows.Add(A, DR1.GetValue(0).ToString(), DR1.GetValue(1).ToString(), DR1.GetValue(2).ToString());
                A++;
            }
            con.Close();
            dataGridViewC.DataSource = table3;
            A = 1;

            query = "SELECT courseName, courseGrade, sGpa FROM Transcript WHERE rollNumber = '" + s + "' and semester = 4;";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                table4.Rows.Add(A, DR1.GetValue(0).ToString(), DR1.GetValue(1).ToString(), DR1.GetValue(2).ToString());
                A++;
            }
            con.Close();
            dataGridViewD.DataSource = table4;
            A = 1;

            query = "SELECT courseName, courseGrade, sGpa FROM Transcript WHERE rollNumber = '" + s + "' and semester = 5;";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                table5.Rows.Add(A, DR1.GetValue(0).ToString(), DR1.GetValue(1).ToString(), DR1.GetValue(2).ToString());
                A++;
            }
            con.Close();
            dataGridViewE.DataSource = table5;
            A = 1;

            query = "SELECT courseName, courseGrade, sGpa FROM Transcript WHERE rollNumber = '" + s + "' and semester = 6;";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                table6.Rows.Add(A, DR1.GetValue(0).ToString(), DR1.GetValue(1).ToString(), DR1.GetValue(2).ToString());
                A++;
            }
            con.Close();
            dataGridViewF.DataSource = table6;
            A = 1;

            query = "SELECT courseName, courseGrade, sGpa FROM Transcript WHERE rollNumber = '" + s + "' and semester = 7;";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                table7.Rows.Add(A, DR1.GetValue(0).ToString(), DR1.GetValue(1).ToString(), DR1.GetValue(2).ToString());
                A++;
            }
            con.Close();
            dataGridViewG.DataSource = table7;
            A = 1;

            query = "SELECT courseName, courseGrade, sGpa FROM Transcript WHERE rollNumber = '" + s + "' and semester = 8;";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            DR1 = cmd.ExecuteReader();
            while (DR1.Read())
            {
                table8.Rows.Add(A, DR1.GetValue(0).ToString(), DR1.GetValue(1).ToString(), DR1.GetValue(2).ToString());
                A++;
            }
            con.Close();
            dataGridViewH.DataSource = table8;
            A = 1;
        }
    }
}
