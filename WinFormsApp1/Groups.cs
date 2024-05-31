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
    public partial class Groups : Form
    {
        int rowIndex;
        public Groups()
        {
            InitializeComponent();
            DisplayGroups();
        }
        private bool insertGroup(String groupCreatedOn)
        {
            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DateTime gco = Convert.ToDateTime(groupCreatedOn);

            SqlCommand cmd = new SqlCommand("INSERT INTO [Group] (Created_On) " +
                 "OUTPUT INSERTED.ID " +
                 "VALUES (@groupCreatedOn)", con);

            cmd.Parameters.AddWithValue("@groupCreatedOn", gco);


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

        private void addGroupBtn_Click(object sender, EventArgs e)
        {
            /* insertGroup(groupDatePicker.Text);
             MessageBox.Show("Successfully saved");*/
            try
            {
                int id = 0;
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Group](Created_On) VALUES(@date); SELECT Id FROM [Group] ORDER BY Id Desc", con);
                cmd.Parameters.AddWithValue("@date", DateTime.Today);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id = int.Parse(reader["Id"].ToString());
                }
                reader.Close();
                MessageBox.Show("Group G-" + id + " Created Successfully");
                editGroup EditGroup = new editGroup(id);
                /* Menu menuForm = (Menu)this.ParentForm;
                 menuForm.OpenChildForm(EditGroup, sender);*/
                this.Hide();
                EditGroup.Show();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DisplayGroups();

        }
        public void DisplayGroups()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT CONCAT('G-',G.Id) AS GroupId,P.Id AS ProjectId,P.Title,COUNT(GS.StudentId) AS GStudent,(SELECT FORMAT(G.Created_On, 'dd-MM-yyyy')) AS Created_On FROM [Group] AS G LEFT JOIN GroupProject AS GP ON G.Id=GP.GroupId LEFT JOIN GroupStudent AS GS ON GS.GroupId=G.Id LEFT JOIN Project AS P ON GP.ProjectId=P.Id WHERE GS.Status=3 GROUP BY G.Id,P.Id,P.Title,G.Created_On", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                groupDataGridView.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void groupDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected row
            DataGridViewRow row = groupDataGridView.Rows[e.RowIndex];

            // Populate the text boxes with the data
            rowIndex = e.RowIndex;
            groupDatePicker.Text = row.Cells["Created_On"].Value.ToString();
            /* id = Convert.ToInt32(row.Cells["Id"].Value);
             idTxtbox.Text = id.ToString();*/
        }

        private void showGroupBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Group] ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            groupDataGridView.DataSource = dt;
        }

        private void updateGroupBtn_Click(object sender, EventArgs e)
        {


            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string idValueFromGrid = groupDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            SqlCommand cm = new SqlCommand("UPDATE [Group] SET [Group].Created_On = @Created_On WHERE [Group].Id = @Id", con);

            cm.Parameters.AddWithValue("@Id", int.Parse(idValueFromGrid));
            cm.Parameters.AddWithValue("@Created_On", DateTime.Parse(groupDatePicker.Text));

            var rowsAffected1 = cm.ExecuteNonQuery();

            MessageBox.Show(" rows updated.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMenu f1=new AdminMenu();
            f1.Show();
        }
    }
}
