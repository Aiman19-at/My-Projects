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
    public partial class Manage_Product : Form
    {
        public Manage_Product()
        {
            InitializeComponent();
        }


        private void Manage_Product_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.BackColor = Color.White;
          



        }
        private void button1_Click(object sender, EventArgs e)
        {
            New_Product NP = new Aiman_Project.New_Product();
            NP.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }
        public int select,rowss;

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
