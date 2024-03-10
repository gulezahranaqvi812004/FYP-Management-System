namespace WinFormsApp1
{
    partial class editGroup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupNameDisplayTextBlock = new TextBox();
            projectTitleTextBlock = new TextBox();
            projectComboBox = new ComboBox();
            studentComboBox = new ComboBox();
            assignProjectBtn = new Button();
            addStudentBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupDetailsStudentDataGrid = new DataGridView();
            exit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)groupDetailsStudentDataGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupNameDisplayTextBlock
            // 
            groupNameDisplayTextBlock.Dock = DockStyle.Fill;
            groupNameDisplayTextBlock.Font = new Font("Segoe UI", 11F);
            groupNameDisplayTextBlock.Location = new Point(3, 3);
            groupNameDisplayTextBlock.Name = "groupNameDisplayTextBlock";
            groupNameDisplayTextBlock.PlaceholderText = "Project ID";
            groupNameDisplayTextBlock.Size = new Size(112, 37);
            groupNameDisplayTextBlock.TabIndex = 0;
            groupNameDisplayTextBlock.TextChanged += groupNameDisplayTextBlock_TextChanged;
            // 
            // projectTitleTextBlock
            // 
            projectTitleTextBlock.Dock = DockStyle.Fill;
            projectTitleTextBlock.Font = new Font("Segoe UI", 11F);
            projectTitleTextBlock.Location = new Point(239, 3);
            projectTitleTextBlock.Name = "projectTitleTextBlock";
            projectTitleTextBlock.Size = new Size(112, 37);
            projectTitleTextBlock.TabIndex = 1;
            projectTitleTextBlock.TextChanged += projectTitleTextBlock_TextChanged;
            // 
            // projectComboBox
            // 
            projectComboBox.Dock = DockStyle.Fill;
            projectComboBox.Font = new Font("Segoe UI", 11F);
            projectComboBox.FormattingEnabled = true;
            projectComboBox.Location = new Point(475, 3);
            projectComboBox.Name = "projectComboBox";
            projectComboBox.Size = new Size(112, 38);
            projectComboBox.TabIndex = 2;
            projectComboBox.SelectedIndexChanged += projectComboBox_SelectedIndexChanged;
            // 
            // studentComboBox
            // 
            studentComboBox.Dock = DockStyle.Fill;
            studentComboBox.Font = new Font("Segoe UI", 11F);
            studentComboBox.FormattingEnabled = true;
            studentComboBox.Location = new Point(829, 3);
            studentComboBox.Name = "studentComboBox";
            studentComboBox.Size = new Size(112, 38);
            studentComboBox.TabIndex = 3;
            // 
            // assignProjectBtn
            // 
            assignProjectBtn.BackColor = Color.FromArgb(155, 164, 181);
            assignProjectBtn.Dock = DockStyle.Fill;
            assignProjectBtn.Location = new Point(593, 3);
            assignProjectBtn.Name = "assignProjectBtn";
            assignProjectBtn.Size = new Size(112, 63);
            assignProjectBtn.TabIndex = 4;
            assignProjectBtn.Text = "+";
            assignProjectBtn.UseVisualStyleBackColor = false;
            assignProjectBtn.Click += assignProjectBtn_Click;
            // 
            // addStudentBtn
            // 
            addStudentBtn.BackColor = Color.FromArgb(155, 164, 181);
            addStudentBtn.Dock = DockStyle.Fill;
            addStudentBtn.Location = new Point(947, 3);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(120, 63);
            addStudentBtn.TabIndex = 5;
            addStudentBtn.Text = "+";
            addStudentBtn.UseVisualStyleBackColor = false;
            addStudentBtn.Click += addStudentBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(121, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 69);
            label1.TabIndex = 6;
            label1.Text = "Project Title";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(357, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 69);
            label2.TabIndex = 7;
            label2.Text = "Select Project";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(711, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 69);
            label3.TabIndex = 8;
            label3.Text = "Select Student ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupDetailsStudentDataGrid
            // 
            groupDetailsStudentDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            groupDetailsStudentDataGrid.Dock = DockStyle.Fill;
            groupDetailsStudentDataGrid.Location = new Point(3, 3);
            groupDetailsStudentDataGrid.Name = "groupDetailsStudentDataGrid";
            groupDetailsStudentDataGrid.RowHeadersWidth = 62;
            groupDetailsStudentDataGrid.Size = new Size(1064, 164);
            groupDetailsStudentDataGrid.TabIndex = 9;
            groupDetailsStudentDataGrid.CellContentClick += groupDetailsStudentDataGrid_CellContentClick;
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            exit.BackColor = Color.FromArgb(155, 164, 181);
            exit.Location = new Point(894, 3);
            exit.Name = "exit";
            exit.Size = new Size(173, 80);
            exit.TabIndex = 10;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupDetailsStudentDataGrid, 0, 0);
            tableLayoutPanel1.Location = new Point(48, 174);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1070, 170);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 9;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.Controls.Add(groupNameDisplayTextBlock, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(projectTitleTextBlock, 2, 0);
            tableLayoutPanel2.Controls.Add(addStudentBtn, 8, 0);
            tableLayoutPanel2.Controls.Add(label3, 6, 0);
            tableLayoutPanel2.Controls.Add(label2, 3, 0);
            tableLayoutPanel2.Controls.Add(projectComboBox, 4, 0);
            tableLayoutPanel2.Controls.Add(studentComboBox, 7, 0);
            tableLayoutPanel2.Controls.Add(assignProjectBtn, 5, 0);
            tableLayoutPanel2.Location = new Point(48, 371);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1070, 69);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.Controls.Add(exit, 1, 0);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Location = new Point(48, 68);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1070, 86);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(57, 72, 103);
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.FromArgb(241, 246, 249);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(885, 86);
            label4.TabIndex = 11;
            label4.Text = "Manage Groups";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editGroup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1159, 498);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "editGroup";
            Text = "editGroup";
            Load += editGroup_Load;
            ((System.ComponentModel.ISupportInitialize)groupDetailsStudentDataGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox groupNameDisplayTextBlock;
        private TextBox projectTitleTextBlock;
        private ComboBox projectComboBox;
        private ComboBox studentComboBox;
        private Button assignProjectBtn;
        private Button addStudentBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView groupDetailsStudentDataGrid;
        private Button exit;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
    }
}