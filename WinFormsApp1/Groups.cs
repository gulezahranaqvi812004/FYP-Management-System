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
            insertGroup(groupDatePicker.Text);
            MessageBox.Show("Successfully saved");
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
