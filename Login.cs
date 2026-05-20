using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hospital_Managment_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void ClrBtn_Click(object sender, EventArgs e)
        {
            Admin.Text = " ";
            Password.Text = " ";
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Admin.Text == " " && Password.Text == " ")
            {
                MessageBox.Show("Missing Information");
            }
            else if (Admin.Text == "Admin" && Password.Text == "Password")
            {
                Home1 obj = new Home1();
                obj.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Please enter a valid Admin username & Password");
            }

        }
    }
}
