using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Advisor : Form
    {
        int rowIndex;
        int gender = 1;
        int id;
        private bool isEditing = false;
        public Advisor()
        {
            InitializeComponent();
        }
        public Advisor(string FName, string LName, string contact, string email, string gender, string designation, string salary, string dob, int Id)
        {
            InitializeComponent();
            isEditing = true;
            firstNameTextBox.Text = FName;
            lastNameTextBox.Text = LName;
            contactTextBox.Text = contact;
            emailTextBox.Text = email;
            salaryTextBox.Text = salary;
            dateOfBirthPicker.Value = DateTime.ParseExact(dob, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            id = Id;
            genderComboBox.Text = gender;
            desComboBox.Text = designation;
        }
        private void dgvAdvisors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected row
            DataGridViewRow row = dgvAdvisors.Rows[e.RowIndex];

            // Populate the text boxes with the data
            rowIndex = e.RowIndex;
            firstNameTextBox.Text = row.Cells["FirstName"].Value.ToString();
            lastNameTextBox.Text = row.Cells["LastName"].Value.ToString();
            contactTextBox.Text = row.Cells["Contact"].Value.ToString();
            emailTextBox.Text = row.Cells["Email"].Value.ToString();
            dateOfBirthPicker.Text = row.Cells["DateOfBirth"].Value.ToString();
            genderComboBox.Text = row.Cells["Gender"].Value.ToString();
            salaryTextBox.Text = row.Cells["Salary"].Value.ToString();
            desComboBox.Text = row.Cells["Designation"].Value.ToString();
            /*id = Convert.ToInt32(row.Cells["Id"].Value);
            idTxtBox.Text = id.ToString();*/
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {

            bool value = true;
            int gender = GetGender(genderComboBox.Text);
            int designation = GetDesignation(desComboBox.Text);


            if (validations.CheckSalary(salaryTextBox.Text))
            {
                // first name is valid
            }
            else
            {
                MessageBox.Show("Salary is invalid");
                value = false;
            }

            if (validations.CheckFirstName(firstNameTextBox.Text))
            {
                // first name is valid
            }
            else
            {
                MessageBox.Show("first name is invalid");
                value = false;
            }
            if (validations.CheckSecondName(lastNameTextBox.Text))
            {

            }
            else
            {
                MessageBox.Show("last name is invalid");
                value = false;
            }

            if (validations.CheckEmail(emailTextBox.Text))
            {

            }
            else
            {
                MessageBox.Show("email is invalid");
                value = false;

            }
            if (validations.CheckContact(contactTextBox.Text))
            {

            }
            else
            {
                MessageBox.Show("contact is invalid");
                value = false;
            }

            /* if (Validation.CheckEmpty(genderComboBox.Text))
             {

             }
             else
             {
                 MessageBox.Show("Designation is invalid");
                 value = false;
             }*/
            if (CheckEmailExists(emailTextBox.Text))
            {
                Console.WriteLine("Email address already exists.");
            }

            if (value)
            {

                insertAdvisor(designation, int.Parse(salaryTextBox.Text), firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, contactTextBox.Text, dateOfBirthPicker.Text, gender);
                MessageBox.Show("Successfully saved");
            }

        }
        private bool CheckEmailExists(string email)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=ProjectA;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*)  FROM Person WHERE Email = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private bool insertAdvisor(int designation, int salary, String FirstName, String LastName, String Email, String Contact, String DOB, int Gender)
        {


            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DateTime dob = Convert.ToDateTime(DOB);
            SqlCommand cmd = new SqlCommand("INSERT INTO Person (FirstName, LastName, Contact, Email, DateOfBirth, Gender) " +
                "OUTPUT INSERTED.ID " +
                "VALUES (@FirstName, @LastName, @Contact, @Email, @DOB, @Gender)", con);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@Contact", Contact);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@DOB", dob);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            int insertedPersonID = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("INSERT INTO Advisor (Id, Designation, Salary) " +
                "VALUES (@Id, @Designation, @Salary)", con);
            cmd.Parameters.AddWithValue("@Id", insertedPersonID);
            cmd.Parameters.AddWithValue("@Designation", designation);
            cmd.Parameters.AddWithValue("@Salary", salary);


            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }

        }

        private void Advisor_Load(object sender, EventArgs e)
        {
            GenderBoxValue();
            DesignationBoxValue();
        }
        public void GenderBoxValue()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id,Value from Lookup where Category = 'GENDER'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["Value"];
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            genderComboBox.DataSource = dataList;
        }

        public void DesignationBoxValue()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id,Value from Lookup where Category = 'DESIGNATION'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["Value"];
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            desComboBox.DataSource = dataList;
        }

        private void showAdvisorBtn_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            // SqlCommand cmd = new SqlCommand("SELECT * FROM Advisor ", con);
            SqlCommand cmd = new SqlCommand("SELECT Person.*, Advisor.* FROM Person INNER JOIN Advisor ON Person.Id = Advisor.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdvisors.DataSource = dt;
        }
        public int GetGender(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT id FROM Lookup WHERE Value = @Enter And  Category = 'GENDER'";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Enter", Value);
            // execute the query and retrieve the results
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            // retrieve the integer data and convert it to int type
            int intValue = reader.GetInt32(0);
            //int userAge = reader.GetInt32(1);

            // use the retrieved integer data as needed
            // Console.WriteLine("User ID: {0}, User Age: {1}", userId, userAge);


            // close the database connection
            con.Close();
            return intValue;


        }
        public int GetDesignation(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT id FROM Lookup WHERE Value = @Enter And  Category = 'DESIGNATION'";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Enter", Value);
            // execute the query and retrieve the results
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            // retrieve the integer data and convert it to int type
            int intValue = reader.GetInt32(0);
            //int userAge = reader.GetInt32(1);

            // use the retrieved integer data as needed
            // Console.WriteLine("User ID: {0}, User Age: {1}", userId, userAge);


            // close the database connection
            con.Close();
            return intValue;
        }
        private void updateStudentButton_Click_Click(object sender, EventArgs e)
        {
            int gender = GetGender(genderComboBox.Text);
            int designation = GetDesignation(desComboBox.Text);

            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string idValueFromGrid = dgvAdvisors.Rows[rowIndex].Cells[0].Value.ToString();
            SqlCommand cm = new SqlCommand("UPDATE Advisor SET  Advisor.Designation = @Designation, Advisor.Salary = @Salary  WHERE Advisor.Id = @Id", con);

            cm.Parameters.AddWithValue("@Salary", salaryTextBox.Text);
            cm.Parameters.AddWithValue("@Id", int.Parse(idValueFromGrid));
            cm.Parameters.AddWithValue("@Designation", designation);
            cm.ExecuteNonQuery();

            cm = new SqlCommand("UPDATE Person SET Person.FirstName = @FirstName, Person.LastName = @LastName, Person.Contact = @Contact, Person.Email = @Email, Person.DateOfBirth = @DateOfBirth, Person.Gender = @Gender  WHERE Person.Id = @Id", con);
            cm.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
            cm.Parameters.AddWithValue("@Contact", contactTextBox.Text);
            cm.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
            cm.Parameters.AddWithValue("@Email", emailTextBox.Text);
            cm.Parameters.AddWithValue("@Id", int.Parse(idValueFromGrid));
            cm.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(dateOfBirthPicker.Text));
            cm.Parameters.AddWithValue("@Gender", gender);

            cm.ExecuteNonQuery();



            MessageBox.Show("rows updated.");
        }

        private void personBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Person ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdvisors.DataSource = dt;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMenu f1 = new AdminMenu();
            f1.Show();
        }
    }
}
