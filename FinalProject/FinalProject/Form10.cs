using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.Show();
        }

        private void Form10_Load(object sender, EventArgs e)
        {   
            Vechile vech = VechileList.Searched;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox7.ReadOnly = true;
            
            if (vech.Date_Sold != "") {
                textBox6.ReadOnly = true;
                textBox6.ReadOnly = true;
                button2.Enabled = false;
            }
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
            radioButton2.AutoCheck = false;
            radioButton3.AutoCheck = false;
            string path = Helper.path + imageName + ".jpg";
            pictureBox1.Image = new Bitmap(path);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Vechile> list = VechileList.vechilelist();
            string data = VechileList.SearchedItem;
            int index = list.FindIndex(x => x.Model == data);
            list[index].Price= int.Parse(textBox6.Text.ToString());
            list[index].Date_Sold=textBox8.Text;
            VechileList.list = list;
            MessageBox.Show("Details Update Sucessfully.");
        }
    }
}
