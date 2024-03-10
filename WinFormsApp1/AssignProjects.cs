﻿using System;
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
    public partial class AssignProjects : Form
    {
        public AssignProjects()
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM GroupProject ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            assignProjectDGV.DataSource = dt;
        }
        private void addStudentButton_Click(object sender, EventArgs e)
        {

            int project = GetProject(projectIdcomboBox.Text);


            assignProject(int.Parse(groupIdComboBox.Text), project, assigmentDatePicker.Text);
            MessageBox.Show("Successfully saved");
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
        private bool assignProject(int groupId, int projectId, string assignDate)
        {
            SqlConnection con = Configuration.getInstance().getConnection();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            // Check if the selected group is active
            SqlCommand checkCmd = new SqlCommand("SELECT Status FROM GroupStudent WHERE GroupId = @GroupId", con);
            checkCmd.Parameters.AddWithValue("@GroupId", groupId);

            /* int groupStatus = (int)checkCmd.ExecuteScalar();

             if (groupStatus != 3) // 3 represents active status
             {
                 MessageBox.Show("Cannot assign project to inactive group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 con.Close();
                 return false;
             }*/

            DateTime gco = Convert.ToDateTime(assignDate);
            SqlCommand cmd = new SqlCommand("INSERT INTO GroupProject (GroupId, ProjectId, AssignmentDate) " +
                "VALUES (@GroupId, @ProjectId, @assignDate)", con);
            cmd.Parameters.AddWithValue("@GroupId", groupId);
            cmd.Parameters.AddWithValue("@ProjectId", projectId);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM GroupProject ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            assignProjectDGV.DataSource = dt;
        }

        private void updateStudentButton_Click_Click(object sender, EventArgs e)
        {
            int project = GetProject(projectIdcomboBox.Text);
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cm = new SqlCommand("UPDATE GroupProject SET GroupProject.AssignmentDate = @AssignmentDate WHERE GroupProject.GroupId = @GroupId AND GroupProject.ProjectId = @ProjectId ", con);

            cm.Parameters.AddWithValue("@GroupId", int.Parse(groupIdComboBox.Text));
            cm.Parameters.AddWithValue("@ProjectId", project);
            cm.Parameters.AddWithValue("@AssignmentDate", DateTime.Parse(assigmentDatePicker.Text));

            var rowsAffected1 = cm.ExecuteNonQuery();

            MessageBox.Show(" rows updated.");
        }

        private void assignProjectDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected row
            DataGridViewRow row = assignProjectDGV.Rows[e.RowIndex];

            // Populate the text boxes with the data
            assigmentDatePicker.Text = row.Cells["AssignmentDate"].Value.ToString();
            groupIdComboBox.Text = row.Cells["GroupId"].Value.ToString();
            projectIdcomboBox.Text = row.Cells["ProjectId"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMenu f1 = new AdminMenu();
            f1.Show();
        }
    }
}
