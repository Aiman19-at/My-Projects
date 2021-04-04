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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1, pwd;
            s1 = Convert.ToString(textBox1.Text);
           pwd = Convert.ToString(textBox2.Text);
            try
            {
                if (error_detact()==false)
                {
                    return;

                }
                else if (s1=="aiman" && pwd=="123")
                {
                    Dashboardcs db = new Aiman_Project.Dashboardcs();
                    db.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" Username And Password Are Not Valid", "Information", MessageBoxButtons.OK);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public bool error_detact()
        {
            bool val = true;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1,"Name is Required");
             
                
                textBox1.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Password is is Required");
                textBox2.Focus();
                return false;
            }
            return val;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox1.Focus();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
