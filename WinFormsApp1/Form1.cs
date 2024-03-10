namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the ManageStudentsForm
            ManageStudentscs manageStudentsForm = new ManageStudentscs();

            // Show the ManageStudentsForm
            manageStudentsForm.Show();
            // this.Hide();
            /*   ManageStudentscs newForm = new ManageStudentscs();

               newForm.TopLevel = false;

              // Set the Parent property to the Panel control in the right pane of the SplitContainer
              splitContainer1.Panel2.Controls.Add(newForm);

              // Set the Dock property to Fill
              newForm.Dock = DockStyle.Fill;

              // Adjust the size of the new form to fit properly within the right pane
              newForm.ClientSize = new Size(splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);

              // Show the new form
              newForm.Show();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*s project = new s();

            project.Show();
            this.Hide();*/
            // Assuming you have a SplitContainer named splitContainer1
            // and a Panel named panel2 inside the SplitContainer

            // Create an instance of the form you want to open
            s form2 = new s();

            // Set TopLevel property to false to indicate that this form
            // will be embedded inside another control
            form2.TopLevel = false;

            // Set the Parent property of the form to the Panel inside the SplitContainer
            form2.Parent = splitContainer1.Panel2;

            // Adjust the size and location of the form to fit inside the Panel
            form2.Dock = DockStyle.Fill;

            // Show the form
            form2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageEvaluations project = new ManageEvaluations();

            project.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            assignAdvisor project = new assignAdvisor();

            project.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Groups project = new Groups();

            project.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StudInG project = new StudInG();

            project.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AssignProjects project = new AssignProjects();

            project.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Advisor advisorForm = new Advisor();

            advisorForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GroupEvaluation evaluation = new GroupEvaluation();

            evaluation.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Report r = new Report();

            r.Show();
            this.Hide();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
