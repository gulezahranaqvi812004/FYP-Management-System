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
    public partial class editGroup : Form
    {
        private int groupId;
        private int projectId;
        private string projectTitle;
        private bool isEditing = false;
        public editGroup()
        {

            InitializeComponent();
            this.groupId = groupId;
            groupNameDisplayTextBlock.Text = "G-" + groupId;

            // Set default values
            projectId = 0;
            projectTitleTextBlock.Text = "Not Assigned";

            InitializeDataGridView();
            GetStudentsOfGroup();
            StudentToComboBox();
            ProjectToComboBox(excludeAssigned: true); // Update the combo box on initialization

        }
        private void ProjectToComboBox(bool excludeAssigned = false)
        {
            var con = Configuration.getInstance1().getConnection1();
            SqlCommand cmd = new SqlCommand("SELECT Title FROM Project", con);

            if (excludeAssigned)
            {
                cmd.CommandText += " WHERE Id NOT IN (SELECT ProjectId FROM GroupProject WHERE GroupId != @GroupId)";
                cmd.Parameters.AddWithValue("@GroupId", groupId);
            }

            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            d.Fill(dt);
            projectComboBox.DataSource = dt.Tables[0].DefaultView;
            projectComboBox.DisplayMember = "Title";
        }
        private void StudentToComboBox()
        {
            var con = Configuration.getInstance1().getConnection1();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT s.RegistrationNo FROM Student s LEFT JOIN (SELECT * FROM GroupStudent GS1 WHERE GS1.AssignmentDate = ( SELECT MAX(GS2.AssignmentDate) FROM GroupStudent GS2 WHERE GS2.StudentId = GS1.StudentId)) recent ON s.Id = recent.StudentID WHERE recent.Status = 4 OR recent.GroupID IS NULL", con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                studentComboBox.DataSource = dataSet.Tables[0].DefaultView;
                studentComboBox.DisplayMember = "RegistrationNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in student combo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private void InitializeDataGridView()
        {
            DataGridViewButtonColumn statusColumn = new DataGridViewButtonColumn();
            statusColumn.HeaderText = "Status";
            statusColumn.Name = "statusColumn";
            // statusColumn.Text = "Active";
            statusColumn.UseColumnTextForButtonValue = true;
            groupDetailsStudentDataGrid.Columns.Add(statusColumn);
        }

        private void GetStudentsOfGroup()
        {
            var con = Configuration.getInstance1().getConnection1();
            if (con == null) return;

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT CONCAT(P.FirstName ,' ',P.LastName) AS Name, S.RegistrationNo FROM GroupStudent AS GS JOIN Lookup AS L ON GS.Status = L.Id JOIN Student AS S ON S.Id = GS.StudentId JOIN Person AS P ON P.Id = S.Id WHERE GS.GroupId = @GroupId AND GS.Status = @Status", con);
                cmd.Parameters.AddWithValue("@GroupId", groupId);
                cmd.Parameters.AddWithValue("@Status", 3);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                groupDetailsStudentDataGrid.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private int GetStudentIdFromDatabase(string registrationNo)
        {
            int studentId = 0;
            var con = Configuration.getInstance1().getConnection1();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Id FROM Student WHERE RegistrationNo=@RegNo", con);
                cmd.Parameters.AddWithValue("@RegNo", registrationNo);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    studentId = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving student ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return studentId;
        }

        private void groupDetailsStudentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == groupDetailsStudentDataGrid.Columns["statusColumn"].Index && e.RowIndex >= 0)
            {
                string registrationNo = groupDetailsStudentDataGrid.Rows[e.RowIndex].Cells["RegistrationNo"].Value.ToString();
                int studentId = GetStudentIdFromDatabase(registrationNo);

                var con = Configuration.getInstance1().getConnection1();
                if (con == null) return;

                try
                {
                    // Remove student from the group
                    SqlCommand removeCmd = new SqlCommand("DELETE FROM GroupStudent WHERE StudentId=@StudentId AND GroupId=@GroupId", con);
                    removeCmd.Parameters.AddWithValue("@StudentId", studentId);
                    removeCmd.Parameters.AddWithValue("@GroupId", groupId);
                    removeCmd.ExecuteNonQuery();

                    // Add student back to the student combo
                    StudentToComboBox();

                    // Refresh the grid (without the status text)
                    GetStudentsOfGroup();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating student status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private int StudentIdFromDataBase()
        {
            int id = 0;
            var con = Configuration.getInstance1().getConnection1();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Student AS S WHERE S.RegistrationNo=@RegNo", con);
            cmd.Parameters.AddWithValue("@RegNo", studentComboBox.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = int.Parse(reader["Id"].ToString());
            }
            reader.Close();
            return id;
        }
        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            int stuId;
            if (studentComboBox.Text != string.Empty)
            {
                var con = Configuration.getInstance1().getConnection1();
                stuId = StudentIdFromDataBase();
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM GroupStudent WHERE StudentId=@StudentId AND GroupId=@GroupId; INSERT INTO GroupStudent VALUES (@GroupId, @StudentId,@Status,@Date)", con);
                    cmd.Parameters.AddWithValue("@StudentId", stuId);
                    cmd.Parameters.AddWithValue("@GroupId", groupId);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Status", 3);
                    cmd.ExecuteNonQuery();
                    studentComboBox.Text = string.Empty;

                    // Refresh the grid
                    GetStudentsOfGroup();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public editGroup(int groupId)
        {
            InitializeComponent();
            this.groupId = groupId;
            groupNameDisplayTextBlock.Text = "G-" + groupId;

            // Set default values
            projectId = 0;
            projectTitleTextBlock.Text = "Not Assigned";

            InitializeDataGridView();
            GetStudentsOfGroup();
            StudentToComboBox();
            ProjectToComboBox(excludeAssigned: true); // Update the combo box on initialization
        }
        public editGroup(int groupId, string projectTitle)
        {
            InitializeComponent();
            isEditing = true;
            this.groupId = groupId;
            this.projectTitle = projectTitle;
            projectId = 0;
            groupNameDisplayTextBlock.Text = "G-" + groupId;

            if (string.IsNullOrEmpty(projectTitle))
            {
                projectTitleTextBlock.Text = "Not Assigned";
            }
            else
            {
                projectTitleTextBlock.Text = projectTitle;
            }

            // Load active students for the selected group
            LoadActiveStudents();
            InitializeDataGridView();
            GetStudentsOfGroup();
            StudentToComboBox();
            ProjectToComboBox(excludeAssigned: true); // Update the combo box on initialization

        }
        private void LoadActiveStudents()
        {
            try
            {
                var con = Configuration.getInstance1().getConnection1();
                SqlCommand cmd = new SqlCommand("SELECT CONCAT(P.FirstName ,' ',P.LastName) AS Name, S.RegistrationNo FROM GroupStudent AS GS JOIN Lookup AS L ON GS.Status = L.Id JOIN Student AS S ON S.Id = GS.StudentId JOIN Person AS P ON P.Id = S.Id WHERE GS.GroupId = @GroupId AND GS.Status = @Status", con);
                cmd.Parameters.AddWithValue("@GroupId", groupId);
                cmd.Parameters.AddWithValue("@Status", 3);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                groupDetailsStudentDataGrid.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void editGroup_Load(object sender, EventArgs e)
        {

        }

        private void groupNameDisplayTextBlock_TextChanged(object sender, EventArgs e)
        {

        }

        private void projectTitleTextBlock_TextChanged(object sender, EventArgs e)
        {

        }

        private void projectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void assignProjectBtn_Click(object sender, EventArgs e)
        {
            if (projectComboBox.Text == string.Empty)
            {
                MessageBox.Show("You need To First Select a project to assign to this group", "Error", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GetProjectId(projectComboBox.Text);
            if (projectTitleTextBlock.Text == "Not Assigned" && !isEditing)
            {
                try
                {
                    var con = Configuration.getInstance1().getConnection1();
                    SqlCommand cmd = new SqlCommand("INSERT INTO GroupProject VALUES (@ProjectId, @GroupId, @Date)", con);
                    cmd.Parameters.AddWithValue("@ProjectId", projectId);
                    cmd.Parameters.AddWithValue("@GroupId", groupId);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    GetCurrentProjectAssigned();
                    ProjectToComboBox();
                    projectComboBox.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else if (isEditing || projectTitleTextBlock.Text == "Not Assigned")
            {
                try
                {
                    var con = Configuration.getInstance1().getConnection1();
                    SqlCommand cmd = new SqlCommand("UPDATE GroupProject SET ProjectId=@ProjectId,AssignmentDate=@Date WHERE GroupId=@GroupId", con);
                    cmd.Parameters.AddWithValue("@ProjectId", projectId);
                    cmd.Parameters.AddWithValue("@GroupId", groupId);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    GetCurrentProjectAssigned();
                    ProjectToComboBox();
                    projectComboBox.Text = string.Empty;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
        private void GetCurrentProjectAssigned()
        {
            var con = Configuration.getInstance1().getConnection1();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Title FROM Project AS P,GroupProject AS GP WHERE  P.Id=GP.ProjectId AND GP.GroupId=@GroupId", con);
                cmd.Parameters.AddWithValue("@GroupId", groupId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    projectTitleTextBlock.Text = reader["Title"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in get current project assigned: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private void GetProjectId(string title)
        {
            var con = Configuration.getInstance1().getConnection1();
            try
            {
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
                MessageBox.Show("Error in get project: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            StudInG studInG = new StudInG();
            this.Hide();
            studInG.Show ();
        }
    }
}
