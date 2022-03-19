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
    public partial class SRegistration : UserControl
    {
        public SRegistration()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        public string ID5;
        int A = 1;
        //Fazool Hai
        private void cr3_Click(object sender, EventArgs e){}

        private void SRegistration_Load(object sender, EventArgs e)
        {
            int x;
            String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
            String query = "SELECT sta FROM Status;";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();
            DR1.Read();
            int a = Int32.Parse(DR1.GetValue(0).ToString());
            con.Close();

            if(a == 1)
            {
                Registor1.Enabled = true;
                label1.Text = "Registration is Open.";
            }
            else
            {
                Registor1.Enabled = false;
                label1.Text = "Registration is Close.";
            }
            if(a == 1)
            {
                Registor1.Enabled = true;
                string s1 = ID5;

                query = "SELECT semester FROM Student WHERE rollNo = '"+ s1 +"';";
                con = new SqlConnection(str);
                cmd = new SqlCommand(query, con);
                con.Open();
                DR1 = cmd.ExecuteReader();
                DR1.Read();
                x = Int32.Parse(DR1.GetValue(0).ToString());
                x = x + 1;
                con.Close();

                table.Columns.Add("SNo", typeof(int));
                table.Columns.Add("Course Name", typeof(string));
                table.Columns.Add("Course Code", typeof(string));
                table.Columns.Add("Course Credit Hours", typeof(string));
                table.Columns["SNo"].ReadOnly = true;
                table.Columns["Course Name"].ReadOnly = true;
                table.Columns["Course Code"].ReadOnly = true;
                table.Columns["Course Credit Hours"].ReadOnly = true;

                query = "SELECT * FROM Course WHERE semester = " + x + ";";
                con = new SqlConnection(str);
                cmd = new SqlCommand(query, con);
                con.Open();
                DR1 = cmd.ExecuteReader();
                while (DR1.Read())
                {
                    table.Rows.Add(A, DR1.GetValue(1).ToString(), DR1.GetValue(2).ToString(), DR1.GetValue(3).ToString());
                    A++;
                }
                con.Close();
                dataGridView1.DataSource = table;
            }
        }
        //string p;
        private void Registor1_Click(object sender, EventArgs e)
        {
            StreamReader sr0 = new StreamReader("C:\\Project\\Files\\Student\\Bio\\" + ID5 + ".txt");

            string s = ID5;

            String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
            String query = "SELECT semester, section FROM Student WHERE rollNo = '" + s + "';";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();
            DR1.Read();
            int a = Int32.Parse(DR1.GetValue(0).ToString());
            a = a + 1;
            String section = DR1.GetValue(1).ToString();
            con.Close();

            query = "UPDATE Student SET semester = " + a + " WHERE rollNo = '" + s + "';";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            A--;
            for(int i=0; i<A;i++)
            {
                if(Convert.ToBoolean(dataGridView1.Rows[i].Cells["Column4"].Value))
                {
                    query = "INSERT INTO Student ('rollNumber', 'courseName', 'semester', 'section') VALUES ('"+s+"', '"+dataGridView1.Rows[i].Cells["Course Name"].Value.ToString()+"', "+a+", '"+section+"');";
                    con = new SqlConnection(str);
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                
            }
            dataGridView1.DataSource = table;
            MessageBox.Show("You have successfully registered your courses.");
        }
    }
}
