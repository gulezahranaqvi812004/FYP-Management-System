using DocumentFormat.OpenXml.Office2010.Excel;
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
    public partial class ManageEvaluations : Form
    {
        int rowIndex;
        int id;
        private bool isEditing = false;
        public ManageEvaluations()
        {
            InitializeComponent();
            loadData();
        }
        private bool Validation1(bool isInserting)
        {
            string title = nameTxtBox.Text;

            // Validate if title contains at least one alphabet
            bool titleValid = title.Any(char.IsLetter);

            if (!titleValid)
            {
                MessageBox.Show("Evaluation Title must contain at least one Alphabet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Calculate total weightage
            int totalWeightage = CalculateTotalWeightage();

            if (totalWeightage >= 100)
            {
                MessageBox.Show("Total weightage is already 100. Cannot add more evaluations.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Skip name check if updating
            if (isInserting)
            {
                titleValid = !validations.ValidationInDatabase("SELECT Name FROM Evaluation WHERE Name='" + title + "' AND Id<>" + id);

                if (!titleValid)
                {
                    MessageBox.Show("There already exists one Evaluation With the same name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }


        private int CalculateTotalWeightage()
        {
            int totalWeightage = 0;
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT SUM(TotalWeightage) FROM Evaluation", con);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalWeightage = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total weightage: " + ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return totalWeightage;
        }
        private void addEvalBtn_Click(object sender, EventArgs e)
        {
            if (nameTxtBox.Text == "")
            {
                MessageBox.Show("Please Select Name of the Evaluation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTotalMarks.Text == "")
            {
                MessageBox.Show("Please Select Total Marks of the Evaluation " + nameTxtBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTotalWeightage.Text == "")
            {
                MessageBox.Show("Please Select Total Weightahe of the Evaluation " + nameTxtBox.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (Validation1(false) && isEditing)
            {
                try
                {
                    using (var con = Configuration.getInstance().getConnection())
                    {
                        SqlCommand updateCommand = new SqlCommand("UPDATE Evaluation SET Name = @Name, TotalMarks = @TotalMarks, TotalWeightage = @TotalWeightage WHERE Id = @Id", con);
                        updateCommand.Parameters.AddWithValue("@Name", nameTxtBox.Text);
                        int totalMarks = int.Parse(txtTotalMarks.Text);
                        int totalWeightage = int.Parse(txtTotalWeightage.Text);

                        updateCommand.Parameters.AddWithValue("@TotalMarks", totalMarks);
                        updateCommand.Parameters.AddWithValue("@TotalWeightage", totalWeightage);
                        updateCommand.Parameters.AddWithValue("@Id", id);

                        updateCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Record updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (Validation1(true) && !isEditing)
            {
                try
                {
                    using (var con = Configuration.getInstance().getConnection())
                    {
                        // Insert new row
                        SqlCommand insertCommand = new SqlCommand("INSERT INTO Evaluation(Name, TotalMarks, TotalWeightage) VALUES (@Name, @TotalMarks, @TotalWeightage)", con);
                        insertCommand.Parameters.AddWithValue("@Name", nameTxtBox.Text);
                        int totalMarks = int.Parse(txtTotalMarks.Text);
                        int totalWeightage = int.Parse(txtTotalWeightage.Text);

                        insertCommand.Parameters.AddWithValue("@TotalMarks", totalMarks);
                        insertCommand.Parameters.AddWithValue("@TotalWeightage", totalWeightage);

                        insertCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("New evaluation added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding new evaluation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            loadData();

        }
        private bool insertEvaluation(string name, int totalMarks, int weightage)
        {

            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO Evaluation (Name, TotalMarks, TotalWeightage) " +
                 "OUTPUT INSERTED.ID " +
                 "VALUES (@Name,@TotalMarks, @TotalWeightage)", con);

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@TotalMarks", totalMarks);
            cmd.Parameters.AddWithValue("@TotalWeightage", weightage);


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
        private void loadData()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Evaluation ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEvaluation.DataSource = dt;
        }
        private void showEvalBtn_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Evaluation ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEvaluation.DataSource = dt;
        }

        private void updateEvalBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string idValueFromGrid = dgvEvaluation.Rows[rowIndex].Cells[0].Value.ToString();
            SqlCommand cm = new SqlCommand("UPDATE Evaluation SET  Evaluation.Name = @Name, Evaluation.TotalMarks= @TotalMarks, Evaluation.TotalWeightage= @TotalWeightage  WHERE Evaluation.Id = @Id", con);

            cm.Parameters.AddWithValue("@Name", nameTxtBox.Text);
            cm.Parameters.AddWithValue("@TotalMarks", int.Parse(txtTotalMarks.Text));
            cm.Parameters.AddWithValue("@TotalWeightage", int.Parse(txtTotalWeightage.Text));
            cm.Parameters.AddWithValue("@Id", int.Parse(idValueFromGrid));

            cm.ExecuteNonQuery();
            MessageBox.Show("rows updated.");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTxtBox.Text = "";
            txtTotalMarks.Text = "";
            txtTotalWeightage.Text = "";
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMenu f1 = new AdminMenu();
            f1.Show();
        }
    }
}
