using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using Microsoft.Office.Interop;
//using System.Windows.Forms.dlll;
namespace clgsm
{
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void view_Load(object sender, EventArgs e)
        {
           
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='F:\\college.xlsx';Extended Properties=Excel 8.0;");
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            DataTable rand = new DataTable();

            String sql = "select username1,Textpt from [sheet2$]";
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            //string chck = upload.imgptnm;
            con.Close();
            ((OleDbDataAdapter)new OleDbDataAdapter(cmd)).Fill(rand);
            dataGridView2.DataSource = rand;
            
            string[] files = Directory.GetFiles(@"F:\Users\RISHAB GHANTI\Documents\Visual Studio 2010\Projects\clgsm\clgsm\Images");
            DataTable table = new DataTable();
            table.Columns.Add("File Path");
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);
            }

        
            dataGridView1.DataSource = table;


            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            pcture myForm = new pcture();
            string imagName = dataGridView1.CurrentRow.Cells[0].Value.ToString();//Cells[0].Value.ToString();
            Image im;
            im = Image.FromFile(@"F:\Users\RISHAB GHANTI\Documents\Visual Studio 2010\Projects\clgsm\clgsm\Images\" + imagName);
            myForm.pictureBox1.Image = im;
            myForm.ShowDialog();
        }

        private void dataGridView1_ColumnDividerDoubleClick(object sender, DataGridViewColumnDividerDoubleClickEventArgs e)
        {
        //    //pcture myForm = new pcture();
        //    //string imagName = dataGridView1.CurrentRow.Cells[0].Value.ToString();//Cells[0].Value.ToString();
        //    //Image im;
        //    //im = Image.FromFile(@"F:\Users\RISHAB GHANTI\Documents\Visual Studio 2010\Projects\clgsm\clgsm\Images\" + imagName);
        //    //myForm.pictureBox1.Image = im;
        //    //myForm.ShowDialog();
        }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        //string pic=dataGridView1.Rows[e.RowIndex].Cells[].FormattedValue;

    }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Show();
            //ji
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex != -1)
        //    {
        //        DataGridViewRow dgvRow= dataGridView1.Rows[e.RowIndex];
        //        Column1.

            
        //    }

        //}
    }
}
