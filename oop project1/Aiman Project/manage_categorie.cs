using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aiman_Project
{
    public partial class manage_categorie : Form
    {
        public manage_categorie()
        {
            InitializeComponent();
        }

        private void manage_categorie_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.MaximizeBox = false;


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public int select;

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowss = dataGridView1.Rows[select];
            rowss.Cells[0].Value = textBox1.Text;
            rowss.Cells[1].Value = textBox2.Text;
            rowss.Cells[2].Value = textBox3.Text;
            rowss.Cells[3].Value = textBox4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (dataGridView1.CurrentCell.RowIndex!=0)
            {

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select = e.RowIndex;
            DataGridViewRow ro = dataGridView1.Rows[select];
            textBox1.Text = ro.Cells[0].Value.ToString();
            textBox2.Text = ro.Cells[1].Value.ToString();
            textBox3.Text = ro.Cells[2].Value.ToString();
            textBox4.Text = ro.Cells[3].Value.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
