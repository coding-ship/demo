using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            string model = textBox2.Text.ToString();
            VechileList.SearchedItem = model;
            List<Vechile> list = VechileList.vechilelist();
            Vechile vech = list.Find(x => x.Model == model);
            if (vech == null)
            {
                MessageBox.Show("No Vechile found");
            }
            else
            {
                VechileList.SetSearch(vech);
                if (VechileList.search == true)
                {
                    Form6 form6 = new Form6();
                    this.Hide();
                    form6.Show();
                }
                else
                {
                    Form10 form10 = new Form10();
                    this.Hide();
                    form10.Show();
                }
            }
        }
    }
}
