using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
            Company company = Company.company;
            label1.Text = company.Name;
            string path = Helper.path + company.Image + ".jpg";
            pictureBox1.Image = new Bitmap(path);
            textBox1.Text += "\r\n\r\nAddress: \r\nStreetName: " + company.StreetName + "\r\nCity: "
                 + company.City + "\r\nProvince: " + company.Province + "\r\nPostalCode: " + company.PostalCode
                 + "\r\nCar Sold: " + company.CarSold + "\r\nTotalProfit: " + company.TotalProfit+"$";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        
    }
}
