using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class StudentMenu : Form
    {
        private string connectionString;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public bool isanotherClick = false;
        public StudentMenu()
        {
            InitializeComponent();
            connectionString = Configuration.getInstance().getConnection().ConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string registrationNumber = textBoxRegistrationNumber.Text;

            if (string.IsNullOrEmpty(registrationNumber))
            {
                MessageBox.Show("Please enter your registration number.");
                return;
            }

            // Check if student exists in database
            if (IsStudentExist(registrationNumber))
            {
                // Enable all buttons except submit
                foreach (Control control in this.Controls)
                {
                    if (control is Button && control.Name != "submitButton")
                    {
                        control.Enabled = true;
                    }
                }
                MessageBox.Show("Welcome, student!");
                viewStud viewStud = new viewStud(registrationNumber, loadAssignedProjects: false);
                this.Hide();
                viewStud.Show();
            }
            else
            {
                MessageBox.Show("Invalid registration number. Please try again.");
            }

        }
        private bool IsStudentExist(string registrationNumber)
        {
            bool isExist = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Student WHERE RegistrationNo = @registrationNumber";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@registrationNumber", registrationNumber);

                connection.Open();
                isExist = (int)command.ExecuteScalar() > 0;
            }

            return isExist;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string registrationNumber = textBoxRegistrationNumber.Text;

            if (string.IsNullOrEmpty(registrationNumber))
            {
                MessageBox.Show("Please enter your registration number.");
                return;
            }

            // Check if student exists in database
            if (IsStudentExist(registrationNumber))
            {
                // Enable all buttons except submit
                foreach (Control control in this.Controls)
                {
                    if (control is Button && control.Name != "submitButton")
                    {
                        control.Enabled = true;
                    }
                }
                MessageBox.Show("Welcome, student!");
                viewStud viewStud = new viewStud(registrationNumber, loadAssignedProjects: true);
                this.Hide();
                viewStud.Show();
            }
            else
            {
                MessageBox.Show("Invalid registration number. Please try again.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string registrationNumber = textBoxRegistrationNumber.Text;

            if (string.IsNullOrEmpty(registrationNumber))
            {
                MessageBox.Show("Please enter your registration number.");
                return;
            }

            // Check if student exists in database
            if (IsStudentExist(registrationNumber))
            {
                // Enable all buttons except submit
                foreach (Control control in this.Controls)
                {
                    if (control is Button && control.Name != "submitButton")
                    {
                        control.Enabled = true;
                    }
                }
                MessageBox.Show("Welcome, student!");
                viewStud viewStud = new viewStud(registrationNumber, loadEvaluations: true);
                this.Hide();
                viewStud.Show();
            }
            else
            {
                MessageBox.Show("Invalid registration number. Please try again.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string registrationNumber = textBoxRegistrationNumber.Text;

            if (string.IsNullOrEmpty(registrationNumber))
            {
                MessageBox.Show("Please enter your registration number.");
                return;
            }

            // Check if student exists in database
            if (IsStudentExist(registrationNumber))
            {
                // Enable all buttons except submit
                foreach (Control control in this.Controls)
                {
                    if (control is Button && control.Name != "submitButton")
                    {
                        control.Enabled = true;
                    }
                }
                MessageBox.Show("Welcome, student!");
                viewStud viewStud = new viewStud(registrationNumber, LoadAdvisor: true);
                this.Hide();
                viewStud.Show();
            }
            else
            {
                MessageBox.Show("Invalid registration number. Please try again.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu form1 = new AdminMenu();
            form1.Show();
        }
    }
}
