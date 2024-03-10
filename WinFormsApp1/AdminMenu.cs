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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageStudentscs form = new ManageStudentscs();
            this.Hide();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            s f = new s();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudInG form = new StudInG();
            this.Hide();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GroupEvaluation form = new GroupEvaluation();
            this.Hide();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            assignAdvisor form = new assignAdvisor();
            this.Hide();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ManageEvaluations form = new ManageEvaluations();
            this.Hide();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AssignProjects form = new AssignProjects();
            this.Hide();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Groups form = new Groups();
            this.Hide();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            this.Hide();
            rp.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pdfReports form = new pdfReports();
            this.Hide();
            form.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
