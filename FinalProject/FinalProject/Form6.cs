using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            Vechile vech = VechileList.Searched;
            textBox1.Text = vech.Make;
            textBox2.Text = vech.Model;
            textBox3.Text = vech.Engine_Cylinders;
            textBox4.Text = vech.Year.ToString();
            textBox5.Text = vech.NoOfDoors.ToString();
            textBox6.Text = vech.Price.ToString();
            textBox7.Text = vech.Color;
            textBox8.Text = vech.Date_Sold;
            string imageName = vech.Image;
            if (vech.Condition == "New")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton3.Checked = true;
            }
            string path = Helper.path + imageName + ".jpg";
            pictureBox1.Image = new Bitmap(path);

        }

    private void button1_Click(object sender, EventArgs e)
        {
            if (Helper.redirect4 == true)
            {
                Form7 form7 = new Form7();
                this.Hide();
                form7.Show();
            }
            else if (Helper.redirect1 == true)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            else if (Helper.redirect2 == true)
            {
                Form4 form4 = new Form4();
                this.Hide();
                form4.Show();
            }
            else
            {
                Form5 form5 = new Form5();
                this.Hide();
                form5.Show();
            }
        }
    }
}
