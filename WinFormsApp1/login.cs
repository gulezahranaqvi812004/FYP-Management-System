using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = guna2TextBox1.Text;
            string password = guna2TextBox2.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            if (username == "admin" && password == "password")
            {
                // Navigate to the main form if the login is successful
                AdminMenu mainForm = new AdminMenu();
                mainForm.Show();
                this.Hide();
            }
            if (username == "student" && password == "password")
            {
                // Navigate to the main form if the login is successful
                StudentMenu mainForm = new StudentMenu();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
