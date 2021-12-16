using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form9 : Form
    {
        public static string name = null;
        public static string path = null;
        public static bool error = false;
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                error = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Property should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                error = false;
                errorProvider1.SetError(textBox1, "");
            }
        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                e.Cancel = true;
                error = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Property should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                error = false;
                errorProvider1.SetError(textBox2, "");
            }
        }
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                e.Cancel = true;
                error = true;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Property should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                error = false;
                errorProvider1.SetError(textBox3, "");
            }
        }
        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                e.Cancel = true;
                error = true;
                textBox4.Focus();
                errorProvider1.SetError(textBox4, "Property should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                error = false;
                errorProvider1.SetError(textBox4, "");
            }
        }
        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                e.Cancel = true;
                error = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox5, "Property should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                error = false;
                errorProvider1.SetError(textBox5, "");
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            
                Company company = Company.company;
                textBox1.Text = company.Name;
                textBox2.Text = company.StreetName;
                textBox3.Text = company.City;
                textBox4.Text = company.Province;
                textBox5.Text = company.PostalCode;
                string path = Helper.path + company.Image + ".jpg";
                pictureBox1.Image = new Bitmap(path);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        if (error == false && pictureBox1.Image!=null)
         {
        pictureBox1.Image.Save(Helper.path + name + ".jpg");
            Company company = Company.company;
            company.Name = textBox1.Text;
            company.StreetName=textBox2.Text;
            company.City=textBox3.Text;
            company.Province=textBox4.Text;
            company.PostalCode=textBox5.Text;
            company.Image = name;
            Company.company = company;
            MessageBox.Show("Details Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Validation Error: All Fields are required.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                name = opnfd.FileName.ToString();
                path = name;
                int index = name.LastIndexOf('\\');

                name = name.Substring(index + 1);
                int ind = name.LastIndexOf('.');
                name = name.Substring(0, ind);
                Bitmap b = new Bitmap(opnfd.FileName);
                System.Drawing.Image i = resizeImage(b, new Size(400, 200));
                pictureBox1.Image = i;

            }
        }

        private static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }

    }
}
