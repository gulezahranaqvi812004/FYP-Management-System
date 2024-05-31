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
    public partial class GroupEvaluation : Form
    {
        public GroupEvaluation()
        {
            InitializeComponent();
            loaddata();
        }
        public void loaddata()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM GroupEvaluation ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            groupEvaluationDGV.DataSource = dt;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            bool value = true;
            int eval = GetEvaluation(evaluationIdcomboBox.Text);
            if (validations.CheckId(obtainedTextBox.Text))
            {
                //Obtained Marks are Valid.
            }
            else
            {
                MessageBox.Show("Obtained Marks are invalid");
                value = false;
                return;
            }
            /* if (EvaluationTotal(int.Parse(obtainedTextBox.Text)) > 50 )
             {
                 MessageBox.Show("Please enter correct digits");
                 value = false;
             }
             */
            if (value)
            {
                evaluation(int.Parse(groupIdComboBox.Text), eval, int.Parse(obtainedTextBox.Text), evaluationDatePicker.Text);
                MessageBox.Show("Successfully saved");
            }
            loaddata();
        }
        public int GetEvaluation(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT Id FROM Evaluation WHERE Name = @Enter";
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

        private bool evaluation(int groupId, int evaluationId, int obtMarks, string evaluationDate)
        {

            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DateTime gco = Convert.ToDateTime(evaluationDate);
            SqlCommand cmd = new SqlCommand("INSERT INTO GroupEvaluation (GroupId, EvaluationId, ObtainedMarks, EvaluationDate) " +
                "VALUES (@GroupId,@EvaluationId,@ObtainedMarks, @evaluationDate)", con);
            cmd.Parameters.AddWithValue("@GroupId", groupId);
            cmd.Parameters.AddWithValue("@EvaluationId", evaluationId);
            cmd.Parameters.AddWithValue("@ObtainedMarks", obtMarks);
            cmd.Parameters.AddWithValue("@evaluationDate", gco);


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
            SqlCommand cmd = new SqlCommand("SELECT * FROM GroupEvaluation ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            groupEvaluationDGV.DataSource = dt;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int eval = GetEvaluation(evaluationIdcomboBox.Text);
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cm = new SqlCommand("UPDATE GroupEvaluation SET GroupEvaluation.EvaluationDate = @EvaluationDate, GroupEvaluation.ObtainedMarks = @ObtainedMarks WHERE GroupEvaluation.GroupId = @GroupId AND GroupEvaluation.EvaluationId = @EvaluationId", con);

            cm.Parameters.AddWithValue("@GroupId", int.Parse(groupIdComboBox.Text));
            cm.Parameters.AddWithValue("@EvaluationId", eval);
            cm.Parameters.AddWithValue("@ObtainedMarks", int.Parse(obtainedTextBox.Text));
            cm.Parameters.AddWithValue("@EvaluationDate", DateTime.Parse(evaluationDatePicker.Text));

            cm.ExecuteNonQuery();

            MessageBox.Show(" rows updated.");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            obtainedTextBox.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMenu f1 = new AdminMenu();
            f1.Show();
        }

        private void GroupEvaluation_Load(object sender, EventArgs e)
        {
            EvaluationBoxValue();
            GroupBoxValue();
        }
        public void GroupBoxValue()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id from [Group]", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["Id"];
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            groupIdComboBox.DataSource = dataList;
        }

        public void EvaluationBoxValue()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id,Name from Evaluation", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["Name"];
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            evaluationIdcomboBox.DataSource = dataList;
        }

        private void evaluationIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
