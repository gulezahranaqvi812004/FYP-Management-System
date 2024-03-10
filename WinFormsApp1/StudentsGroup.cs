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
    public partial class StudentsGroup : Form
    {
        public StudentsGroup()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMenu form1 = new AdminMenu();
            form1.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool value = true;
            int status = GetStatusId(statusComboBox.Text);
            if (statusComboBox.Text == "Active")
            {

            }
            else
            {
                MessageBox.Show("Student is InACtive. You can't add in group");
                value = false;
            }
            if (CheckStudentAlreadyExistInGroup(studentIdcomboBox.Text))
            {
                MessageBox.Show("Student already exists in group");
                return;
            }
            if (CheckSTudentCountInGroup(int.Parse(groupIdComboBox.Text)) == 3)
            {
                MessageBox.Show("Group has already 3 members.");
                return;
            }

            if (value)
            {

                insertStudentInGroup(int.Parse(groupIdComboBox.Text), int.Parse(studentIdcomboBox.Text), status, assignmentDatePicker.Text);
                MessageBox.Show("Successfully saved");

            }
        }
        private bool CheckStudentAlreadyExistInGroup(string Student)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=ProjectA;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM GroupStudent WHERE StudentId = @StudentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentId", Student);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        private int CheckSTudentCountInGroup(int groupId)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=ProjectA;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM GroupStudent  WHERE GroupId = @GroupId AND STATUS = 3 ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GroupId", groupId);
                int count = (int)command.ExecuteScalar();
                return count;
            }
        }

        private bool insertStudentInGroup(int groupId, int studentId, int status, string assignDate)
        {
            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DateTime gco = Convert.ToDateTime(assignDate);
            SqlCommand cmd = new SqlCommand("INSERT INTO GroupStudent (GroupId, StudentId, Status, AssignmentDate) " +
                "VALUES (@GroupId,@StudentId,@Status, @assignDate)", con);
            cmd.Parameters.AddWithValue("@GroupId", groupId);
            cmd.Parameters.AddWithValue("@StudentId", studentId);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@assignDate", gco);


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

        private void showBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM GroupStudent WHERE STATUS = 3 ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentGroupDGV.DataSource = dt;
        }
        public int GetStatusId(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT id FROM Lookup WHERE Value = @Enter And  Category = 'STATUS'";
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
        private void updateBtn_Click(object sender, EventArgs e)
        {
            int status = GetStatusId(statusComboBox.Text);
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            // Get group ID and inactive status
            int groupId = int.Parse(groupIdComboBox.Text);

            // Update all group student IDs with inactive status
            SqlCommand cm = new SqlCommand("UPDATE GroupStudent SET Status = @Status WHERE GroupId = @GroupId AND StudentId = @StudentId ", con);
            cm.Parameters.AddWithValue("@GroupId", groupId);
            cm.Parameters.AddWithValue("@StudentId", int.Parse(studentIdcomboBox.Text));
            cm.Parameters.AddWithValue("@Status", status);
            var rowsAffected = cm.ExecuteNonQuery();
            MessageBox.Show(rowsAffected.ToString() + " rows updated.");


            con.Close();
        }
    }
}
