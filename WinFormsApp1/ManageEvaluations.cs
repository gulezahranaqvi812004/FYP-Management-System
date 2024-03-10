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
        public ManageEvaluations()
        {
            InitializeComponent();
        }

        private void addEvalBtn_Click(object sender, EventArgs e)
        {

            bool value = true;


            if (validations.CheckFirstName(nameTxtBox.Text))
            {

            }
            else
            {
                MessageBox.Show("Name invalid");
                value = false;
            }
            if (validations.CheckId(totalmarksTextBox.Text))
            {

            }
            else
            {
                MessageBox.Show("Total Marks are invalid");
                value = false;
            }
            if (validations.CheckId(weightadeTxtBox.Text))
            {

            }
            else
            {
                MessageBox.Show("Total Weightage is invalid");
                value = false;
            }


            if (value)
            {

                insertEvaluation(nameTxtBox.Text, int.Parse(totalmarksTextBox.Text), int.Parse(weightadeTxtBox.Text));
                MessageBox.Show("Successfully saved");
            }

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
            cm.Parameters.AddWithValue("@TotalMarks", int.Parse(totalmarksTextBox.Text));
            cm.Parameters.AddWithValue("@TotalWeightage", int.Parse(weightadeTxtBox.Text));
            cm.Parameters.AddWithValue("@Id", int.Parse(idValueFromGrid));

            cm.ExecuteNonQuery();
            MessageBox.Show("rows updated.");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTxtBox.Text = "";
            totalmarksTextBox.Text = "";
            weightadeTxtBox.Text = "";
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMenu f1 = new AdminMenu();
            f1.Show();
        }
    }
}
