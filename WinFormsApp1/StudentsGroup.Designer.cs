namespace WinFormsApp1
{
    partial class StudentsGroup
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
            groupIdComboBox = new ComboBox();
            studentIdcomboBox = new ComboBox();
            statusComboBox = new ComboBox();
            assignmentDatePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            studentGroupDGV = new DataGridView();
            addBtn = new Button();
            showBtn = new Button();
            updateBtn = new Button();
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)studentGroupDGV).BeginInit();
            SuspendLayout();
            // 
            // groupIdComboBox
            // 
            groupIdComboBox.FormattingEnabled = true;
            groupIdComboBox.Location = new Point(185, 56);
            groupIdComboBox.Name = "groupIdComboBox";
            groupIdComboBox.Size = new Size(182, 33);
            groupIdComboBox.TabIndex = 0;
            // 
            // studentIdcomboBox
            // 
            studentIdcomboBox.FormattingEnabled = true;
            studentIdcomboBox.Location = new Point(185, 130);
            studentIdcomboBox.Name = "studentIdcomboBox";
            studentIdcomboBox.Size = new Size(182, 33);
            studentIdcomboBox.TabIndex = 1;
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(185, 190);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(182, 33);
            statusComboBox.TabIndex = 2;
            // 
            // assignmentDatePicker
            // 
            assignmentDatePicker.Location = new Point(185, 251);
            assignmentDatePicker.Name = "assignmentDatePicker";
            assignmentDatePicker.Size = new Size(300, 31);
            assignmentDatePicker.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 59);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 4;
            label1.Text = "Group ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 130);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 5;
            label2.Text = "Student";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 198);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 6;
            label3.Text = "Status Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 251);
            label4.Name = "label4";
            label4.Size = new Size(148, 25);
            label4.TabIndex = 7;
            label4.Text = "Assignment Date";
            // 
            // studentGroupDGV
            // 
            studentGroupDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGroupDGV.Location = new Point(509, 92);
            studentGroupDGV.Name = "studentGroupDGV";
            studentGroupDGV.RowHeadersWidth = 62;
            studentGroupDGV.Size = new Size(360, 225);
            studentGroupDGV.TabIndex = 8;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(100, 402);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(112, 34);
            addBtn.TabIndex = 9;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // showBtn
            // 
            showBtn.Location = new Point(271, 396);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(112, 34);
            showBtn.TabIndex = 10;
            showBtn.Text = "Show";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(468, 395);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(112, 34);
            updateBtn.TabIndex = 11;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(635, 390);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(112, 34);
            exitBtn.TabIndex = 12;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // StudentsGroup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 510);
            Controls.Add(exitBtn);
            Controls.Add(updateBtn);
            Controls.Add(showBtn);
            Controls.Add(addBtn);
            Controls.Add(studentGroupDGV);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(assignmentDatePicker);
            Controls.Add(statusComboBox);
            Controls.Add(studentIdcomboBox);
            Controls.Add(groupIdComboBox);
            Name = "StudentsGroup";
            Text = "StudentsGroup";
            ((System.ComponentModel.ISupportInitialize)studentGroupDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox groupIdComboBox;
        private ComboBox studentIdcomboBox;
        private ComboBox statusComboBox;
        private DateTimePicker assignmentDatePicker;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView studentGroupDGV;
        private Button addBtn;
        private Button showBtn;
        private Button updateBtn;
        private Button exitBtn;
    }
}