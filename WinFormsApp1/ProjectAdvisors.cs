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
    public partial class ProjectAdvisors : Form
    {
        private int projectId;
        private bool isEditing = false;
        public ProjectAdvisors()
        {

            InitializeComponent();
            ProjectToComboBox();
            AdvisorToComboBox(mainAdvComboBox, "", "");
            AdvisorToComboBox(coAdvComboBox, "", "");
            AdvisorToComboBox(industryAdvComboBox, "", "");

        }
        private void ProjectToComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Title from Project P LEFT JOIN ProjectAdvisor PA ON P.Id=PA.ProjectId WHERE PA.AdvisorId IS NULL", con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            d.Fill(dt);
            projectComboBox.DataSource = dt.Tables[0].DefaultView;
            projectComboBox.DisplayMember = "Title";
        }
        private void AdvisorToComboBox(ComboBox cb, string adv1, string adv2)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT (P.FirstName+' '+P.LastName) AS Name FROM Advisor A JOIN Person P ON A.Id=P.Id WHERE (P.FirstName+' '+P.LastName)<>@name1 AND (P.FirstName+' '+P.LastName)<>@name2", con);
                cmd.Parameters.AddWithValue("@name1", adv1);
                cmd.Parameters.AddWithValue("@name2", adv2);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                cb.DataSource = dataSet.Tables[0].DefaultView;
                cb.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       
        private string GetProjectTitle(int Id)
        {
            string title = "";
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT Title FROM Project WHERE Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", Id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    title = reader["Title"].ToString();
                }
                reader.Close();
                return title;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
        private void GetProjectId(string title)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT Id FROM Project WHERE Title=@title", con);
                cmd.Parameters.AddWithValue("@title", title);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    projectId = int.Parse(reader["Id"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



        private int AdvisorIdFromDataBase(string Name)
        {
            int id = 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT P.Id FROM Person P JOIN Advisor A ON A.Id=P.Id WHERE LOWER(P.FirstName + ' ' + P.LastName) = LOWER(@Name)", con);
            cmd.Parameters.AddWithValue("@Name", Name.Trim());
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = int.Parse(reader["Id"].ToString());
            }
            reader.Close();
            return id;
        }

        private int GetAdvisorRole(string role)
        {
            int id = 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Lookup WHERE Value='" + role + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = int.Parse(reader["Id"].ToString());
            }
            reader.Close();
            return id;
        }

        private void AssignAdvisor(int role, int advisorId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO ProjectAdvisor VALUES (@AdvisorId, @ProjectId, @AdvisorRole, @AssignmentDate)", con);
                cmd.Parameters.AddWithValue("@ProjectId", projectId);
                cmd.Parameters.AddWithValue("@AdvisorId", advisorId);
                cmd.Parameters.AddWithValue("@AdvisorRole", role);
                cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveAdvisorToProject()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM ProjectAdvisor WHERE ProjectId=@projectId", con);
                cmd.Parameters.AddWithValue("@ProjectId", projectId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (projectComboBox.Text == string.Empty)
            {
                MessageBox.Show("Select a Project First");
                return;
            }
            else if (mainAdvComboBox.Text == string.Empty || coAdvComboBox.Text == string.Empty || industryAdvComboBox.Text == string.Empty)
            {
                MessageBox.Show("Select an Advisor to be assigned");
                return;
            }
            GetProjectId(projectComboBox.Text);
            RemoveAdvisorToProject();
            int mainId = AdvisorIdFromDataBase(mainAdvComboBox.Text);
            int coId = AdvisorIdFromDataBase(coAdvComboBox.Text);
            int inId = AdvisorIdFromDataBase(industryAdvComboBox.Text);
            // Check if the selected advisors are the same
            if (mainId == coId && coId == inId)
            {
                MessageBox.Show("The selected advisors cannot be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AssignAdvisor(GetAdvisorRole("Main Advisor"), mainId);
            AssignAdvisor(GetAdvisorRole("Co-Advisror"), coId);
            AssignAdvisor(GetAdvisorRole("Industry Advisor"), inId);
            MessageBox.Show("Advisors Assigned Successfully");
            /* bool value = true;
             int project = GetProject(mainAdvComboBox.Text);
             int adRole = GetAdvisorRole(coAdvComboBox.Text);

             if (CheckProjectALreadyExistForAdvisor(project))
             {
                 MessageBox.Show("This Project already assigned to an advisor.");
                 return;
             }
             if (availableProject(project))
             {
                 MessageBox.Show("This Project already assigned to an advisor.");
                 return;
             }
             if (value)
             {

                 assignAdvisor(int.Parse(projectComboBox.Text), project, adRole, assigmentDatePicker.Text);
                 MessageBox.Show("Successfully saved");
             }*/
        }
       

       
        public int GetProject(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT id FROM Project WHERE Title = @Enter";
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
        public bool availableProject(int projectName)
        {
            int m = GetProject(mainAdvComboBox.Text);
            bool status = false;
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Count(ProjectId) from GroupProject where ProjectId = @studentid", con);
            cmd.Parameters.AddWithValue("@studentid", m);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // MessageBox.Show("hello");
                int count = reader.GetInt32(0);
                if (count == 0)
                {
                    //MessageBox.Show("loo");
                    status = true;
                }
                else
                {
                    MessageBox.Show("Not available");
                }
                //   MessageBox.Show("HH");
            }
            // Create list to store retrieved data

            // Close reader and connection
            reader.Close();
            con.Close();
            return status;
        }
        private bool assignAdvisor(int advisorId, int projectId, int advisorRole, string assignDate)
        {



            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DateTime gco = Convert.ToDateTime(assignDate);
            SqlCommand cmd = new SqlCommand("INSERT INTO ProjectAdvisor (AdvisorId, ProjectId, AdvisorRole, AssignmentDate) " +
                "VALUES (@AdvisorId,@ProjectId,@AdvisorRole, @assignDate)", con);
            cmd.Parameters.AddWithValue("@AdvisorId", advisorId);
            cmd.Parameters.AddWithValue("@ProjectId", projectId);
            cmd.Parameters.AddWithValue("@AdvisorRole", advisorRole);
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
        private bool CheckProjectALreadyExistForAdvisor(int Project)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=ProjectA;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM ProjectAdvisor WHERE ProjectId= @ProjectId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProjectId", Project);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            /* var con = Configuration.getInstance().getConnection();
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             SqlCommand cmd = new SqlCommand("SELECT * FROM ProjectAdvisor ", con);
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             da.Fill(dt);
             advisorGroupDGV.DataSource = dt;*/
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT  MAX(P.Title) Title, MAX(CASE WHEN PA.AdvisorRole = 11 THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS MainAdvisor, MAX(CASE WHEN PA.AdvisorRole = 12 THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS CoAdvisor, MAX(CASE WHEN PA.AdvisorRole = 14 THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS IndustryAdvisor FROM  ProjectAdvisor PA INNER JOIN Advisor A ON PA.AdvisorId = A.Id JOIN Project P ON P.Id=PA.ProjectId JOIN Person ON Person.Id=A.Id GROUP BY PA.ProjectId", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            advisorGroupDGV.DataSource = dt.DefaultView;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            int project = GetProject(mainAdvComboBox.Text);
            int adRole = GetAdvisorRole(coAdvComboBox.Text);

            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cm = new SqlCommand("UPDATE ProjectAdvisor SET ProjectAdvisor.AdvisorRole= @AdvisorRole, ProjectAdvisor.AssignmentDate = @AssignmentDate WHERE ProjectAdvisor.AdvisorId= @AdvisorId AND ProjectAdvisor.ProjectId = @ProjectId ", con);

            cm.Parameters.AddWithValue("@AdvisorId", int.Parse(projectComboBox.Text));
            cm.Parameters.AddWithValue("@ProjectId", project);
            cm.Parameters.AddWithValue("@AdvisorRole", adRole);
            cm.Parameters.AddWithValue("@AssignmentDate", DateTime.Parse(assigmentDatePicker.Text));

            cm.ExecuteNonQuery();

            MessageBox.Show(" rows updated.");
        }

        private void advisorGroupDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Get the selected row
            DataGridViewRow row = advisorGroupDGV.Rows[e.RowIndex];

            // Populate the text boxes with the data
            assigmentDatePicker.Text = row.Cells["AssignmentDate"].Value.ToString();
            projectComboBox.Text = row.Cells["AdvisorId"].Value.ToString();
            mainAdvComboBox.Text = row.Cells["ProjectId"].Value.ToString();
            coAdvComboBox.Text = row.Cells["AdvisorRole"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            assignAdvisor f1 = new assignAdvisor();
            f1.Show();
        }

        private void advisorIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ProjectAdvisors_Load(object sender, EventArgs e)
        {

        }
    }
}
