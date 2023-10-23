using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace clgsm
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }
        public static string username1 = "";
        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='F:\\college.xlsx';Extended Properties=Excel 8.0;");
            con.Open();
            OleDbCommand cmd = new OleDbCommand();


            OleDbDataAdapter oda = new OleDbDataAdapter("SELECT COUNT(*) FROM [Sheet1$] WHERE [user] = '" + usernm.Text + "' AND [Pass] = '" + pass.Text + "'", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            username1 = usernm.Text;

            if (dt.Rows[0][0].ToString() == "1")
            {
                
                
                this.Hide();
                var upload = new upload();
                upload.loggedin = true;
                upload.Closed += (s, args) => this.Close();
                upload.Show();
                

            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please Retry!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            con.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
