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
    public partial class ASRegistration : UserControl
    {
        public ASRegistration()
        {
            InitializeComponent();
        }

        private void SReg_Click(object sender, EventArgs e)
        {
            String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
            String query = "INSERT INTO Student (firstName, lastName, email, cnic, dob, contactNo, homeAddresss, nationality, rollNo, cgpa, degree, semester, campus, batch, dc, warningCount, section, _passWord_) VALUES ('"+ Fname3.Text + "', '"+ Lname3.Text + "', '"+ Eaddress3.Text + "', "+ Int32.Parse(cnic3.Text) + ", '"+ dob3.Text + "', "+ Int32.Parse(cno3.Text) + ", '"+ Haddress3.Text + "', '"+ nation3.Text + "', '"+ rno3.Text + "', "+ float.Parse(cgpa3.Text) + ", '"+ degree1.Text + "', "+ Int32.Parse(semester1.Text) + ", '"+ campus3.Text + "', "+ Int32.Parse(batch3.Text) + ", "+ Int32.Parse(dc3.Text) + ", "+ Int32.Parse(warning3.Text) + ", '"+ sec3.Text + "', '"+ password1.Text + "');";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            query = "INSERT INTO Users (id, password, user1) VALUES ('" + rno3.Text + "', '" + password1.Text + "', " + 1 + ");";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            query = "SELECT courseName FROM Course WHERE semester = 1;";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();
            DR1.Read();
            string a = DR1.GetValue(0).ToString();
            DR1.Read();
            string b = DR1.GetValue(0).ToString();
            DR1.Read();
            string c = DR1.GetValue(0).ToString();
            DR1.Read();
            string d = DR1.GetValue(0).ToString();
            DR1.Read();
            string e1 = DR1.GetValue(0).ToString();
            DR1.Read();
            string f = DR1.GetValue(0).ToString();
            DR1.Read();
            string g = DR1.GetValue(0).ToString();
            DR1.Read();
            string h = DR1.GetValue(0).ToString();
            con.Close();

            query = "INSERT INTO Registered_courses (rollNumber, courseName, semester, section) VALUES ('" + rno3.Text + "', '" + a + "', " + 1 + ", '" + sec3.Text + "'), ('" + rno3.Text + "', '" + b + "', " + 1 + ", '" + sec3.Text + "'), ('" + rno3.Text + "', '" + c + "', " + 1 + ", '" + sec3.Text + "'), ('" + rno3.Text + "', '" + d + "', " + 1 + ", '" + sec3.Text + "'), ('" + rno3.Text + "', '" + e1 + "', " + 1 + ", '" + sec3.Text + "'), ('" + rno3.Text + "', '" + f + "', " + 1 + ", '" + sec3.Text + "'), ('" + rno3.Text + "', '" + g + "', " + 1 + ", '" + sec3.Text + "'), ('" + rno3.Text + "', '" + h + "', " + 1 + ", '" + sec3.Text + "');";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            query = "INSERT INTO Marks (rollNumber, courseName, section, semester, quiz01, assignment01, mid01, quiz02, assignment02, mid02, project, final, grandTotal) VALUES ('" + rno3.Text + "', '" + a + "', '" + sec3.Text + "', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0), ('" + rno3.Text + "', '" + b + "', '" + sec3.Text + "', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0), ('" + rno3.Text + "', '" + c + "', '" + sec3.Text + "', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0), ('" + rno3.Text + "', '" + d + "', '" + sec3.Text + "', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0), ('" + rno3.Text + "', '" + e + "', '" + sec3.Text + "', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0), ('" + rno3.Text + "', '" + f + "', '" + sec3.Text + "', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0), ('" + rno3.Text + "', '" + g + "', '" + sec3.Text + "', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0), ('" + rno3.Text + "', '" + h + "', '" + sec3.Text + "', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0);";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            query = "INSERT INTO Transcript (rollNumber, semester, courseName, courseGrade, sGpa, cGpa) VALUES ('" + rno3.Text + "', 1, '" + a + "', 'NA', 0, 0), ('" + rno3.Text + "', 1, '" + b + "', 'NA', 0, 0), ('" + rno3.Text + "', 1, '" + c + "', 'NA', 0, 0), ('" + rno3.Text + "', 1, '" + d + "', 'NA', 0, 0), ('" + rno3.Text + "', 1, '" + e1 + "', 'NA', 0, 0), ('" + rno3.Text + "', 1, '" + f + "', 'NA', 0, 0), ('" + rno3.Text + "', 1, '" + g + "', 'NA', 0, 0), ('" + rno3.Text + "', 1, '" + h + "', 'NA', 0, 0);";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            string message = "Student has been registered successfully....";
            MessageBox.Show(message);

            Fname3.Clear();

            Lname3.Clear();

            Eaddress3.Clear();

            cnic3.Clear();

            dob3.Clear();

            cno3.Clear();

            Haddress3.Clear();

            nation3.Clear();

            rno3.Clear();

            cgpa3.Clear();

            degree1.Clear();

            campus3.Clear();

            batch3.Clear();

            dc3.Clear();

            warning3.Clear();

            sec3.Clear();

            password1.Clear();
        }
    }
}
