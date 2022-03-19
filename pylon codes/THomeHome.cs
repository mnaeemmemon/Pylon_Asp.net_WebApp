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
    public partial class THomeHome : UserControl
    {
        public THomeHome()
        {
            InitializeComponent();
        }
        public string ID1;

        private void THomeHome_Load(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            string s = ID1;

            String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
            String query = "SELECT * FROM Teacher WHERE teacherID = '" + s + "';";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();
            DR1.Read();
            Fname2.Text = DR1.GetValue(0).ToString();
            Lname2.Text = DR1.GetValue(1).ToString();
            Eaddress2.Text = DR1.GetValue(2).ToString();
            cnic2.Text = DR1.GetValue(4).ToString();
            dob2.Text = DR1.GetValue(5).ToString();
            cno2.Text = DR1.GetValue(6).ToString();
            Haddress2.Text = DR1.GetValue(7).ToString();
            nation2.Text = DR1.GetValue(8).ToString();
            qua2.Text = DR1.GetValue(9).ToString();
            pos2.Text = DR1.GetValue(10).ToString();
            degree2.Text = DR1.GetValue(11).ToString();
            campus2.Text = DR1.GetValue(12).ToString();
            con.Close();
        }
    }
}
