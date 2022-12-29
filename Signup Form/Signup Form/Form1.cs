using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signup_Form
{
    public partial class CREATE : Form
    {
        public CREATE()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dob_Click(object sender, EventArgs e)
        {

        }

        private void first_Name_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            
        }

        private void onSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            String Fnames = first_Name_input.Text;
            String Lname = Last_Name_input.Text;
            String dob = dob_input.Text;


            MessageBox.Show(Fnames+Lname+ dob);
        }

        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void femaleRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void otherRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void loginPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FORM login = new FORM();
            login.ShowDialog();
            login.CreateGraphics();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
