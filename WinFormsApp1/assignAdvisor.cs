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
    public partial class assignAdvisor : Form
    {
        public assignAdvisor()
        {
            InitializeComponent();
            ViewAdvisoryBoard();
            AddEditButtonColumn();
        }
        public void ViewAdvisoryBoard()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT  MAX(P.Title) Title, MAX(CASE WHEN PA.AdvisorRole = 11 THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS MainAdvisor, MAX(CASE WHEN PA.AdvisorRole = 12 THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS CoAdvisor, MAX(CASE WHEN PA.AdvisorRole = 14 THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS IndustryAdvisor FROM  ProjectAdvisor PA INNER JOIN Advisor A ON PA.AdvisorId = A.Id JOIN Project P ON P.Id=PA.ProjectId JOIN Person ON Person.Id=A.Id GROUP BY PA.ProjectId", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AdvisorBoardDataGrid.DataSource = dt.DefaultView;
        }
        public void ViewAdvisor()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT FirstName, LastName, Contact, Email, Gender, Designation, Salary, FORMAT(DateOfBirth, 'dd-MM-yyyy') AS [DoB] FROM Person P JOIN Advisor A ON A.Id = P.Id", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                AdvisorBoardDataGrid.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error at view advisor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddEditButtonColumn()
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Name = "EditButtonColumn";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.DisplayIndex = AdvisorBoardDataGrid.Columns.Count; // Set the display index to move the column to the last position
            AdvisorBoardDataGrid.Columns.Add(editButtonColumn);
        }
        private void AdvisorBoardDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == AdvisorBoardDataGrid.Columns["EditButtonColumn"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = AdvisorBoardDataGrid.Rows[e.RowIndex];
                string firstName = selectedRow.Cells["FirstName"].Value.ToString();
                string lastName = selectedRow.Cells["LastName"].Value.ToString();
                string contact = selectedRow.Cells["Contact"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string genderId = selectedRow.Cells["Gender"].Value.ToString(); // Use alias instead of column name
                string designationId = selectedRow.Cells["Designation"].Value.ToString(); // Use alias instead of column name
                string salary = selectedRow.Cells["Salary"].Value.ToString();
                string dob = selectedRow.Cells["DoB"].Value.ToString(); // Use alias instead of column name
                int id = GetIdFromDatabase(firstName, lastName); // Assuming you have a method to retrieve ID

                // Retrieve designation and gender strings from lookup table
                string designation = GetDesignationFromId(designationId);
                string gender = GetGenderFromId(genderId);

                // Open the edit form with the retrieved data
                Advisor addAdvisorForm = new Advisor(firstName, lastName, contact, email, gender, designation, salary, dob, id);
                /*Menu menuForm = (Menu)this.ParentForm;
                menuForm.OpenChildForm(addAdvisorForm, sender);*/
                addAdvisorForm.Show();
            }
        }
        private string GetGenderFromId(string genderId)
        {
            string gender = "";
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT Value FROM Lookup WHERE Id = @Id AND Category = 'GENDER'", con);
                cmd.Parameters.AddWithValue("@Id", genderId);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    gender = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error at GetGenderFromId", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return gender;
        }

        private string GetDesignationFromId(string designationId)
        {
            string designation = "";
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT Value FROM Lookup WHERE Id = @Id AND Category = 'DESIGNATION'", con);
                cmd.Parameters.AddWithValue("@Id", designationId);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    designation = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error at GetDesignationFromId", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return designation;
        }



        private int GetIdFromDatabase(string firstName, string lastName)
        {
            int id = 0;
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT A.Id FROM Advisor A JOIN Person P ON A.Id = P.Id WHERE P.FirstName = @FirstName AND P.LastName = @LastName", con);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error at GetIdFromDatabase", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectAdvisors pd = new ProjectAdvisors();

            /*  Menu menuForm = (Menu)this.ParentForm;
              menuForm.OpenChildForm(AddAssignAdvisor, sender);*/
            pd.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminMenu form = new AdminMenu();
            this.Close();
            form.Show();
        }
    }
}
