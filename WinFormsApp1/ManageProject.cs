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
    public partial class s : Form
    {
        int rowIndex;
        public s()
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Project ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdvisors.DataSource = dt;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            bool value = true;


            if (validations.CheckString(descritionTxtBox.Text))
            {

            }
            else
            {
                MessageBox.Show("Description is invalid");
                value = false;
            }
            if (validations.CheckString(titleTextBox.Text))
            {

            }
            else
            {
                MessageBox.Show("Title is invalid");
                value = false;
            }


            if (value)
            {

                insertProject(descritionTxtBox.Text, titleTextBox.Text);
                loaddata();
                MessageBox.Show("Successfully saved");

            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Project ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdvisors.DataSource = dt;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string idValueFromGrid = dgvAdvisors.Rows[rowIndex].Cells[0].Value.ToString();
            SqlCommand cm = new SqlCommand("UPDATE Project SET  Project.Description = @Description, Project.Title = @Title  WHERE Project.Id = @Id", con);

            cm.Parameters.AddWithValue("@Description", descritionTxtBox.Text);
            cm.Parameters.AddWithValue("@Id", int.Parse(idValueFromGrid));
            cm.Parameters.AddWithValue("@Title", titleTextBox.Text);

            cm.ExecuteNonQuery();
            MessageBox.Show("rows updated.");
        }
        private bool insertProject(string description, string title)
        {

            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO Project (Title, Description) " +
                "OUTPUT INSERTED.ID " +
                 "VALUES (@Title, @Description)", con);
            cmd.Parameters.AddWithValue("@Description", description);
            cmd.Parameters.AddWithValue("@Title", title);


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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            descritionTxtBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMenu f1 = new AdminMenu();
            f1.Show();
        }
    }
}
