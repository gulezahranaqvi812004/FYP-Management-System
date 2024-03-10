namespace WinFormsApp1
{
    partial class AssignProjects
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
            projectIdcomboBox = new ComboBox();
            groupIdComboBox = new ComboBox();
            assigmentDatePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            assignProjectDGV = new DataGridView();
            addStudentButton = new Button();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)assignProjectDGV).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // projectIdcomboBox
            // 
            projectIdcomboBox.Dock = DockStyle.Fill;
            projectIdcomboBox.FormattingEnabled = true;
            projectIdcomboBox.Location = new Point(3, 68);
            projectIdcomboBox.Name = "projectIdcomboBox";
            projectIdcomboBox.Size = new Size(350, 33);
            projectIdcomboBox.TabIndex = 0;
            // 
            // groupIdComboBox
            // 
            groupIdComboBox.Dock = DockStyle.Fill;
            groupIdComboBox.FormattingEnabled = true;
            groupIdComboBox.Location = new Point(3, 198);
            groupIdComboBox.Name = "groupIdComboBox";
            groupIdComboBox.Size = new Size(350, 33);
            groupIdComboBox.TabIndex = 1;
            // 
            // assigmentDatePicker
            // 
            assigmentDatePicker.Dock = DockStyle.Fill;
            assigmentDatePicker.Location = new Point(3, 328);
            assigmentDatePicker.Name = "assigmentDatePicker";
            assigmentDatePicker.Size = new Size(350, 31);
            assigmentDatePicker.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(350, 65);
            label1.TabIndex = 3;
            label1.Text = "Project ID";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(3, 130);
            label2.Name = "label2";
            label2.Size = new Size(350, 65);
            label2.TabIndex = 4;
            label2.Text = "Group ID";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(3, 260);
            label3.Name = "label3";
            label3.Size = new Size(350, 65);
            label3.TabIndex = 5;
            label3.Text = "Assignment Date";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // assignProjectDGV
            // 
            assignProjectDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            assignProjectDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assignProjectDGV.Dock = DockStyle.Fill;
            assignProjectDGV.Location = new Point(3, 3);
            assignProjectDGV.Name = "assignProjectDGV";
            assignProjectDGV.RowHeadersWidth = 62;
            assignProjectDGV.Size = new Size(573, 386);
            assignProjectDGV.TabIndex = 6;
            assignProjectDGV.CellContentClick += assignProjectDGV_CellContentClick;
            // 
            // addStudentButton
            // 
            addStudentButton.BackColor = Color.FromArgb(155, 164, 181);
            addStudentButton.Dock = DockStyle.Fill;
            addStudentButton.Location = new Point(3, 3);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(473, 80);
            addStudentButton.TabIndex = 7;
            addStudentButton.Text = "Add";
            addStudentButton.UseVisualStyleBackColor = false;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(155, 164, 181);
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(482, 3);
            button1.Name = "button1";
            button1.Size = new Size(473, 80);
            button1.TabIndex = 10;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(projectIdcomboBox, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(groupIdComboBox, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(assigmentDatePicker, 0, 5);
            tableLayoutPanel1.Location = new Point(65, 148);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(356, 391);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(assignProjectDGV, 0, 0);
            tableLayoutPanel2.Location = new Point(441, 148);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(579, 392);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(addStudentButton, 0, 0);
            tableLayoutPanel3.Controls.Add(button1, 1, 0);
            tableLayoutPanel3.Location = new Point(65, 562);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(958, 86);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Location = new Point(65, 47);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(958, 80);
            tableLayoutPanel4.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(57, 72, 103);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.FromArgb(241, 246, 249);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(952, 80);
            label4.TabIndex = 0;
            label4.Text = "Assign Project";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AssignProjects
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1087, 677);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1109, 733);
            Name = "AssignProjects";
            Text = "AssignProjects";
            ((System.ComponentModel.ISupportInitialize)assignProjectDGV).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox projectIdcomboBox;
        private ComboBox groupIdComboBox;
        private DateTimePicker assigmentDatePicker;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView assignProjectDGV;
        private Button addStudentButton;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
    }
}