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
    public partial class ACRegistration : UserControl
    {
        public ACRegistration()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e){}

        private void ACRegistration_Load(object sender, EventArgs e)
        {
            int x;
            String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
            String query = "SELECT sta FROM Status;";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader DR1 = cmd.ExecuteReader();
            DR1.Read();
            x = Int32.Parse(DR1.GetValue(0).ToString());
            con.Close();
            if (x==0)
            {
                radioButton2.Checked = true;
            }
            else if(x==1)
            {
                radioButton1.Checked = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {   
            int x = 1;
            String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
            String query = "UPDATE Status SET sta = "+x+";";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int x = 0;
            String str = "server=localhost\\SQLEXPRESS;database=IPT_Project;Integrated Security=True;";
            String query = "UPDATE Status SET sta = " + x + ";";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
