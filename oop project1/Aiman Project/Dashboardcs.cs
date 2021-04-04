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
    public partial class Dashboardcs : Form
    {
        public Dashboardcs()
        {
            InitializeComponent();
        }

        private void Dashboardcs_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.MaximizeBox = true;
            this.BackColor = Color.White;
            label6.ForeColor = Color.Blue;
           
        }

        private void pRODUCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Product pp = new Aiman_Project.Manage_Product();
            pp.Show();

        }

        private void cATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage_categorie mc = new Aiman_Project.manage_categorie();
            mc.Show();
        }

        private void cUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomer manage = new Aiman_Project.ManageCustomer();
            manage.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
           
           

        }
    }
}
