using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
namespace clgsm
{

    public partial class upload : Form
    {
        public upload()
        {
            InitializeComponent();
            panel2.Hide();
        }
        
        public static bool loggedin = false;
        public static string imgptnm = "";
        private void upload_Load(object sender, EventArgs e)
        {
            if (loggedin)
            {
                loginbt.Hide();
                loginlabel.Hide();
                panel2.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new login();
            login.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.gif; *bmp;)|*.jpg;*.jpeg;*.gif; *bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            File.Copy(textBox1.Text, Path.Combine(@"F:\Users\RISHAB GHANTI\Documents\Visual Studio 2010\Projects\clgsm\clgsm\Images\", Path.GetFileName(textBox1.Text)), true);
            
            label4.Text = "Image file saved successfully";
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='F:\\college.xlsx';Extended Properties=Excel 8.0;");
            //imgptnm = textBox1.Text;
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            String sql = "INSERT INTO [sheet2$](username1,Textpt) values('" + login.username1 + "','" + textBox2.Text + "')";
            
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved successfully");
            this.Hide();
            var view = new view();
            view.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}