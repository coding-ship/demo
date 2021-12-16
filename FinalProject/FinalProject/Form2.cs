using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        public static int i = 1;
        public Form2()
        {
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            if (i == 1)
            {
                Company.data();
                VechileList.list = Vechile.VechileList();
                Helper.path = @"C:\Users\19mad\source\repos\FinalProject\FinalProject\Image\\";
                i++;
            }
            List<Vechile> list= VechileList.vechilelist();
            this.dataGridView1.DataSource = list;
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.Columns[2].ReadOnly = true;
            this.dataGridView1.Columns[3].ReadOnly = true;
            this.dataGridView1.Columns[4].ReadOnly = true;
            this.dataGridView1.Columns[5].ReadOnly = true;
            this.dataGridView1.Columns[6].ReadOnly = true;
            this.dataGridView1.Columns[7].ReadOnly = true;
            this.dataGridView1.Columns[9].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.Name = "Image";
            this.dataGridView1.Columns.Add(imageCol);
            for (int i = 0; i < list.Count; i++)
            {
                string path = Helper.path + list[i].Image+"thumb.jpg";
                Bitmap img = new Bitmap(path);
                this.dataGridView1.Rows[i].Cells[10].Value = img;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Helper.redirect1 = true;
            Helper.redirect2 = false;
            Helper.redirect3 = false;
            Helper.redirect4 = false;
            List<Vechile> list = VechileList.vechilelist();
            Vechile vech = list[e.RowIndex];
            VechileList.SetSearch(vech);
            Form6 form6 = new Form6();
                this.Hide();
                form6.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
