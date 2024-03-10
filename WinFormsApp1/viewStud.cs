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
    public partial class viewStud : Form
    {
        private string connectionString;
        private string registrationNumber;
        private bool loadAssignedProjects;
        private int groupId;
        private int totalMarks;
        private int obtainedMarks;
        public viewStud()
        {

            InitializeComponent();

        }
        public viewStud(string registrationNumber, bool loadAssignedProjects = false, bool loadEvaluations = false, bool LoadAdvisor = false)
        {
            InitializeComponent();
            this.registrationNumber = registrationNumber;
            this.loadAssignedProjects = loadAssignedProjects; // Set the loadAssignedProjects field
            connectionString = Configuration.getInstance().getConnection().ConnectionString;

            if (loadAssignedProjects)
            {
                LoadAssignedProjects(); // Load assigned projects
            }
            else if (loadEvaluations)

            {
                SetEvaluationCriteria(groupId, totalMarks, obtainedMarks);
                LoadEvaluations(); // Load evaluations
            }
            else if (LoadAdvisor)

            {

                loadAdvisor(); // Load evaluations
            }
            else
            {
                LoadStudentData(); // Load student data
            }
        }
        private void LoadStudentData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT p.FirstName, p.LastName, p.Contact, p.Email, 
                   CONVERT(nvarchar(50), l.Value) AS Gender
            FROM Student s
            INNER JOIN Person p ON s.Id = p.Id
            INNER JOIN Lookup l ON p.Gender = l.Id
            WHERE s.RegistrationNo = @registrationNumber";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@registrationNumber", registrationNumber);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                StudentdataGridView.DataSource = table;
            }
        }

        private void viewStud_Load(object sender, EventArgs e)
        {

        }
        private void LoadAssignedProjects()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT 
      'G-' + CONVERT(nvarchar(50), G.Id) AS GroupId, -- Combine 'G-' with converted ID
      P.Title,
      P.Description
    FROM 
      [ProjectA].[dbo].[Project] P
    JOIN 
      [ProjectA].[dbo].[GroupProject] GP ON P.Id = GP.ProjectId
    JOIN 
      [ProjectA].[dbo].[Group] G ON GP.GroupId = G.Id
    JOIN 
      [ProjectA].[dbo].[GroupStudent] GS ON G.Id = GS.GroupId
    JOIN 
      [ProjectA].[dbo].[Student] S ON GS.StudentId = S.Id
    WHERE 
      S.RegistrationNo = @registrationNumber";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@registrationNumber", registrationNumber);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);



                StudentdataGridView.DataSource = table;
            }
        }

        private void LoadEvaluations()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            E.Name AS EvaluationName,
            GE.ObtainedMarks,
            E.TotalMarks,
            E.TotalWeightage
        FROM 
            [ProjectA].[dbo].[GroupEvaluation] GE
        JOIN 
            [ProjectA].[dbo].[Evaluation] E ON GE.EvaluationId = E.Id
        JOIN 
            [ProjectA].[dbo].[Group] G ON GE.GroupId = G.Id
        JOIN 
            [ProjectA].[dbo].[GroupStudent] GS ON G.Id = GS.GroupId
        JOIN 
            [ProjectA].[dbo].[Student] S ON GS.StudentId = S.Id
        WHERE 
            S.RegistrationNo = @registrationNumber";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@registrationNumber", registrationNumber);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Display data in your desired way, e.g., DataGridView
                StudentdataGridView.DataSource = table;
            }
        }

        // Function to set group ID, total marks, and obtained marks
        private void SetEvaluationCriteria(int groupId, int totalMarks, int obtainedMarks)
        {
            this.groupId = groupId;
            this.totalMarks = totalMarks;
            this.obtainedMarks = obtainedMarks;
        }
        private void loadAdvisor()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
SELECT 
    P.FirstName AS AdvisorFirstName,
    P.LastName AS AdvisorLastName,
    P.Contact AS AdvisorContact,
    P.Email AS AdvisorEmail,
    LR.Value AS AdvisorRole
FROM 
    [ProjectA].[dbo].[ProjectAdvisor] PA
INNER JOIN [ProjectA].[dbo].[Person] P ON PA.AdvisorId = P.Id
INNER JOIN [ProjectA].[dbo].[Advisor] A ON PA.AdvisorId = A.Id
INNER JOIN [ProjectA].[dbo].[Lookup] LR ON PA.AdvisorRole = LR.Id
WHERE 
    PA.ProjectId IN (
        SELECT G.Id
        FROM [ProjectA].[dbo].[Group] G
        INNER JOIN [ProjectA].[dbo].[GroupStudent] GS ON G.Id = GS.GroupId
        INNER JOIN [ProjectA].[dbo].[Student] S ON GS.StudentId = S.Id
        WHERE S.RegistrationNo = @registrationNumber
    )";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@registrationNumber", registrationNumber);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Set the advisor data to a suitable DataGridView or other control
                // Assuming you have a designated DataGridView for advisors:
                StudentdataGridView.DataSource = table;
            }
        }
        private void StudentdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentMenu vs=new StudentMenu();
            vs.Show();
        }
    }
}
