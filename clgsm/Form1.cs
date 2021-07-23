using System;
using System.Windows.Forms;
using clgsm.Properties;

namespace clgsm
{
    public partial class Form1 : Form
    {
        private bool isCollapsed = true;
        private bool collapsed = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Its working");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            if (isCollapsed)
            {
                button3.Image = Resources.collapse;
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button3.Image = Resources.expand;
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
               
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {


        }


        private void button8_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (collapsed)
            {
                button8.Image = Resources.collapse;
                panel2.Height += 10;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timer2.Stop();
                    collapsed = false;
                }
            }
            else
            {
                button8.Image = Resources.expand;
                panel2.Height -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer2.Stop();
                    collapsed = true;
                }
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            var view = new view();
            view.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void upload_Click(object sender, EventArgs e)
        {
            this.Hide();
            var upload = new upload();
            upload.Show();
            
            //panel2.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // pictureBox1.Image = Image.FromFile(@"C:\Users\Reev M D'souza\Downloads\T&P.JPG");
            // pictureBox1.ImageLocation = "";
        }
    }
}

