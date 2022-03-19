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
    public partial class ATRegistration : UserControl
    {
        public ATRegistration()
        {
            InitializeComponent();
        }

        private void TReg_Click(object sender, EventArgs e)
        {
            String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
            String query = "INSERT INTO Teacher (firstName, lastName, emailAddress, teacherID, cnic, dob, contactNo, homeAddress, nationality, qualification, position, degree, campus, password) VALUES ('" + Fname4.Text + "', '" + Lname4.Text + "', '" + Eaddress4.Text + "', '" + ID4.Text + "', '" + cnic4.Text + "', '" + dob4.Text + "', '" + cno4.Text + "', '" + Haddress4.Text + "', '" + nation4.Text + "', '" + qua4.Text + "', '" + pos4.Text + "', '" + degree4.Text + "', '" + campus4.Text + "', '" + password4.Text + "');";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            query = "INSERT INTO Users (id, password, user1) VALUES ('" + ID4.Text + "', '" + password4.Text + "', " + 2 + ");";
            con = new SqlConnection(str);
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            string message = "Teacher has been registered successfully";
            MessageBox.Show(message);

            Fname4.Clear();
            Lname4.Clear();
            Eaddress4.Clear();
            cnic4.Clear();
            dob4.Clear();
            cno4.Clear();
            Haddress4.Clear();
            nation4.Clear();
            qua4.Clear();
            pos4.Clear();
            degree4.Clear();
            campus4.Clear();
            ID4.Clear();
            password4.Clear();

        }
    }
}
