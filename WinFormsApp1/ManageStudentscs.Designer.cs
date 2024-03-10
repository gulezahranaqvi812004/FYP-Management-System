namespace WinFormsApp1
{
    partial class ManageStudentscs
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
            studentDataGridView = new DataGridView();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            genderComboBox = new ComboBox();
            dateOfBirthPicker = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            contactTextBox = new TextBox();
            label6 = new Label();
            emailTextBox = new TextBox();
            addStudentButton = new Button();
            regNoTextBox = new TextBox();
            label7 = new Label();
            showStudentButton_Click = new Button();
            personBtn = new Button();
            clearBtn = new Button();
            logoutBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label8 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            updateStudentButton_Click = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // studentDataGridView
            // 
            studentDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDataGridView.Location = new Point(3, 80);
            studentDataGridView.Name = "studentDataGridView";
            studentDataGridView.RowHeadersWidth = 62;
            studentDataGridView.Size = new Size(600, 249);
            studentDataGridView.TabIndex = 0;
            studentDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Dock = DockStyle.Fill;
            firstNameTextBox.Location = new Point(238, 65);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(230, 31);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Dock = DockStyle.Fill;
            lastNameTextBox.Location = new Point(238, 127);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(230, 31);
            lastNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(241, 246, 249);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(3, 62);
            label1.Name = "label1";
            label1.Size = new Size(229, 62);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(241, 246, 249);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(3, 124);
            label2.Name = "label2";
            label2.Size = new Size(229, 62);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(241, 246, 249);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(3, 186);
            label3.Name = "label3";
            label3.Size = new Size(229, 62);
            label3.TabIndex = 5;
            label3.Text = "Gender";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // genderComboBox
            // 
            genderComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Male", "Female" });
            genderComboBox.Location = new Point(238, 189);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(230, 33);
            genderComboBox.TabIndex = 6;
            // 
            // dateOfBirthPicker
            // 
            dateOfBirthPicker.Dock = DockStyle.Fill;
            dateOfBirthPicker.Location = new Point(238, 251);
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.Size = new Size(230, 31);
            dateOfBirthPicker.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(241, 246, 249);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(3, 248);
            label4.Name = "label4";
            label4.Size = new Size(229, 62);
            label4.TabIndex = 8;
            label4.Text = "Date of Birth";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(241, 246, 249);
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(3, 310);
            label5.Name = "label5";
            label5.Size = new Size(229, 62);
            label5.TabIndex = 9;
            label5.Text = "Contact";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contactTextBox
            // 
            contactTextBox.Dock = DockStyle.Fill;
            contactTextBox.Location = new Point(238, 313);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.Size = new Size(230, 31);
            contactTextBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(241, 246, 249);
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(3, 372);
            label6.Name = "label6";
            label6.Size = new Size(229, 67);
            label6.TabIndex = 11;
            label6.Text = "Email";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailTextBox
            // 
            emailTextBox.Dock = DockStyle.Fill;
            emailTextBox.Location = new Point(238, 375);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(230, 31);
            emailTextBox.TabIndex = 12;
            // 
            // addStudentButton
            // 
            addStudentButton.BackColor = Color.FromArgb(155, 164, 181);
            addStudentButton.Dock = DockStyle.Fill;
            addStudentButton.Font = new Font("Segoe UI", 11F);
            addStudentButton.Location = new Point(3, 3);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(194, 39);
            addStudentButton.TabIndex = 13;
            addStudentButton.Text = "Add";
            addStudentButton.UseVisualStyleBackColor = false;
            addStudentButton.Click += button1_Click;
            // 
            // regNoTextBox
            // 
            regNoTextBox.Dock = DockStyle.Fill;
            regNoTextBox.Location = new Point(238, 3);
            regNoTextBox.Name = "regNoTextBox";
            regNoTextBox.Size = new Size(230, 31);
            regNoTextBox.TabIndex = 14;
            regNoTextBox.WordWrap = false;
            regNoTextBox.TextChanged += regNoTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(241, 246, 249);
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(229, 62);
            label7.TabIndex = 15;
            label7.Text = "Reg No";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // showStudentButton_Click
            // 
            showStudentButton_Click.BackColor = Color.FromArgb(155, 164, 181);
            showStudentButton_Click.Dock = DockStyle.Fill;
            showStudentButton_Click.Font = new Font("Segoe UI", 11F);
            showStudentButton_Click.Location = new Point(203, 3);
            showStudentButton_Click.Name = "showStudentButton_Click";
            showStudentButton_Click.Size = new Size(194, 39);
            showStudentButton_Click.TabIndex = 16;
            showStudentButton_Click.Text = "Show Students";
            showStudentButton_Click.UseVisualStyleBackColor = false;
            showStudentButton_Click.Click += showStudentButton_Click_Click;
            // 
            // personBtn
            // 
            personBtn.BackColor = Color.FromArgb(155, 164, 181);
            personBtn.Dock = DockStyle.Fill;
            personBtn.Font = new Font("Segoe UI", 11F);
            personBtn.Location = new Point(403, 3);
            personBtn.Name = "personBtn";
            personBtn.Size = new Size(194, 39);
            personBtn.TabIndex = 18;
            personBtn.Text = "Show person";
            personBtn.UseVisualStyleBackColor = false;
            personBtn.Click += personBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(155, 164, 181);
            clearBtn.Dock = DockStyle.Fill;
            clearBtn.Font = new Font("Segoe UI", 11F);
            clearBtn.Location = new Point(203, 48);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(194, 39);
            clearBtn.TabIndex = 19;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.FromArgb(155, 164, 181);
            logoutBtn.Dock = DockStyle.Fill;
            logoutBtn.Font = new Font("Segoe UI", 11F);
            logoutBtn.Location = new Point(403, 48);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(194, 39);
            logoutBtn.TabIndex = 20;
            logoutBtn.Text = "Exit";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label7, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(regNoTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(emailTextBox, 1, 6);
            tableLayoutPanel1.Controls.Add(label6, 0, 6);
            tableLayoutPanel1.Controls.Add(contactTextBox, 1, 5);
            tableLayoutPanel1.Controls.Add(firstNameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(dateOfBirthPicker, 1, 4);
            tableLayoutPanel1.Controls.Add(lastNameTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(genderComboBox, 1, 3);
            tableLayoutPanel1.Location = new Point(26, 125);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(471, 439);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(studentDataGridView, 0, 1);
            tableLayoutPanel2.Controls.Add(label8, 0, 0);
            tableLayoutPanel2.Location = new Point(526, 126);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.2282677F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 53.21618F));
            tableLayoutPanel2.Size = new Size(606, 332);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(600, 77);
            label8.TabIndex = 1;
            label8.Text = "Data";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(addStudentButton, 0, 0);
            tableLayoutPanel3.Controls.Add(showStudentButton_Click, 1, 0);
            tableLayoutPanel3.Controls.Add(personBtn, 2, 0);
            tableLayoutPanel3.Controls.Add(logoutBtn, 2, 1);
            tableLayoutPanel3.Controls.Add(updateStudentButton_Click, 0, 1);
            tableLayoutPanel3.Controls.Add(clearBtn, 1, 1);
            tableLayoutPanel3.Location = new Point(531, 474);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(600, 90);
            tableLayoutPanel3.TabIndex = 23;
            // 
            // updateStudentButton_Click
            // 
            updateStudentButton_Click.BackColor = Color.FromArgb(155, 164, 181);
            updateStudentButton_Click.Dock = DockStyle.Fill;
            updateStudentButton_Click.Font = new Font("Segoe UI", 11F);
            updateStudentButton_Click.Location = new Point(3, 48);
            updateStudentButton_Click.Name = "updateStudentButton_Click";
            updateStudentButton_Click.Size = new Size(194, 39);
            updateStudentButton_Click.TabIndex = 17;
            updateStudentButton_Click.Text = "Update";
            updateStudentButton_Click.UseVisualStyleBackColor = false;
            updateStudentButton_Click.Click += updateStudentButton_Click_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label9, 0, 0);
            tableLayoutPanel4.Location = new Point(26, 38);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1104, 63);
            tableLayoutPanel4.TabIndex = 24;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(155, 164, 181);
            label9.Font = new Font("Segoe UI", 14F);
            label9.ForeColor = Color.FromArgb(33, 42, 62);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(1098, 63);
            label9.TabIndex = 0;
            label9.Text = "Manage Students";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageStudentscs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1152, 576);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1174, 632);
            Name = "ManageStudentscs";
            Text = "ManageStudentscs";
            Load += ManageStudentscs_Load;
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView studentDataGridView;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox genderComboBox;
        private DateTimePicker dateOfBirthPicker;
        private Label label4;
        private Label label5;
        private TextBox contactTextBox;
        private Label label6;
        private TextBox emailTextBox;
        private Button addStudentButton;
        private TextBox regNoTextBox;
        private Label label7;
        private Button showStudentButton_Click;
        private Button personBtn;
        private Button clearBtn;
        private Button logoutBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label9;
        private Button updateStudentButton_Click;
    }
}