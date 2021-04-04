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
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Value.Date.ToLocalTime();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count!=0)
            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,textBox5.Text,textBox6.Text,this.dateTimePicker1.Value.Date);
               
               
                label9.Text = "TOTAL NUMBER OF ORDER "+" " +textBox6.Text;
                label9.ForeColor = Color.Green;
                clean();
            }
        }
        public int select;

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowss = dataGridView1.Rows[select];
            rowss.Cells[0].Value = textBox1.Text;
            rowss.Cells[1].Value = textBox2.Text;
            rowss.Cells[2].Value = textBox3.Text;
            rowss.Cells[3].Value = textBox4.Text;
            rowss.Cells[4].Value = textBox5.Text;

            rowss.Cells[5].Value = textBox6.Text; 
            rowss.Cells[6].Value =dateTimePicker1;
            
        }
        public void clean()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            dateTimePicker1.Text = ""; 

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select = e.RowIndex;
            DataGridViewRow ro = dataGridView1.Rows[select];
            textBox1.Text = ro.Cells[0].Value.ToString();
            textBox2.Text = ro.Cells[1].Value.ToString();
            textBox3.Text = ro.Cells[2].Value.ToString();
            textBox4.Text = ro.Cells[3].Value.ToString();
            textBox5.Text = ro.Cells[4].Value.ToString();
            textBox6.Text = ro.Cells[5].Value.ToString();
            dateTimePicker1.Text = ro.Cells[6].Value.ToString();


        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.BackColor = Color.White;
        }
    }
}
