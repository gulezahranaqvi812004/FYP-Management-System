using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentMenu st = new StudentMenu();
            this.Hide();
            st.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminMenu form1 = new AdminMenu();
            this.Hide();
            form1.Show();
        }
    }
}
