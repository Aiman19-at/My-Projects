using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Aiman_Project
{
    public partial class New_Product : Form
    {
        public string ss; 
        public DataTable dt = new DataTable();
        public New_Product()
        {
            InitializeComponent();
        }

        private void New_Product_Load(object sender, EventArgs e)
        {

            
            
            this.MaximizeBox = false;
            
       
            this.BackColor = Color.White;
            comboBox1.Items.Add("MOBILE");
            comboBox1.Items.Add("COMPUTER");

            panel3.Hide();
          


        }
        public void SETS()
        {
            //  DT.Columns.AddRange(new DataColumn[5] { new DataColumn("NAME",typeof(string)),
            //    new DataColumn("MODEL",typeof(string)),
            //new DataColumn("DESCRIPTION",typeof(string))  })
           

           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPEN = new OpenFileDialog();
            OPEN.Filter = "Image files | *.jpg";
            if (OPEN.ShowDialog() == DialogResult.OK)
            {
                ss = OPEN.FileName;
                pictureBox1.Image = Image.FromFile(ss);
               button3.Hide();
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button3.Enabled==true)
            {
                this.Close();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string new_itm = Convert.ToString(textBox5.Text);
            if (string.IsNullOrWhiteSpace(new_itm))
            {
                MessageBox.Show("Please FillUp Properly", "Information", MessageBoxButtons.OK);
            }
            else
            {
                comboBox1.Items.Add(new_itm);
                panel3.Hide();
                 
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        public void clean()
        {
            textBox1.Text = "";
            textBox2.Text = "";

            textBox3.Text = "";
            textBox4.Text = "";

            comboBox1.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
    
          
              dataGridView1.Rows.Add(comboBox1.Text,textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,pictureBox1.Image); 
            clean();

        }
        public int selectedrow;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedrow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[selectedrow];
                comboBox1.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                MemoryStream ms = new MemoryStream();
                Bitmap img = (Bitmap)dataGridView1.CurrentRow.Cells[6].Value;
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                pictureBox1.Image = Image.FromStream(ms);
                    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public int select;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select = e.RowIndex;
            DataGridViewRow ro = dataGridView1.Rows[select];
            comboBox1.Text = ro.Cells[0].Value.ToString();
            textBox1.Text = ro.Cells[1].Value.ToString();
            textBox2.Text = ro.Cells[2].Value.ToString();
            textBox3.Text = ro.Cells[3].Value.ToString();
            textBox4.Text = ro.Cells[4].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowss = dataGridView1.Rows[select];
            rowss.Cells[0].Value = comboBox1.Text;
            rowss.Cells[1].Value = textBox1.Text;
            rowss.Cells[2].Value = textBox2.Text;
            rowss.Cells[3].Value = textBox3.Text;
            rowss.Cells[4].Value = textBox4.Text;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow rowss = dataGridView1.Rows[select];
            rowss.Cells[0].Value = comboBox1.Text;
            rowss.Cells[1].Value = textBox1.Text;
            rowss.Cells[2].Value = textBox2.Text;
            rowss.Cells[3].Value = textBox3.Text;
            rowss.Cells[4].Value = textBox4.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            while (dataGridView1.CurrentCell.RowIndex != 0)
            {

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
        }
    }
}
