using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if(checkBoxPass.Checked==false)
                txtPass.UseSystemPasswordChar= true;
            else
                txtPass.UseSystemPasswordChar = false;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question
                )==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
