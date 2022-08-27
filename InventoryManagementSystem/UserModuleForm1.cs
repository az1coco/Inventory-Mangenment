using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class UserModuleForm1 : Form
    {
        SqlConnection con= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbMs.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public UserModuleForm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to save this user?","Saving Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cm = new SqlConnection("INSERT INTO tbUser(username,fullname,password,phone)VALUES(@username,@fullname,@password,@phone)", con);
                    cm.Parameters.AddWithValue("@username", txtUserName.Text);
                    cm.Parameters.AddWithValue("@fullname", txtFullName.Text);
                    cm.Parameters.AddWithValue("@password", txtPassword.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been added successfully.");
                    Clear();
                       
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            
        }
        public  void Clear()
        {
            txtUserName.Clear();
            txtFullName.Clear();
            txtPassword.Clear();
            txtPhone.Clear();

        }
    }
}
