namespace WinFormsApp1
{
    partial class Advisor
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
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            genderComboBox = new ComboBox();
            dateOfBirthPicker = new DateTimePicker();
            contactTextBox = new TextBox();
            emailTextBox = new TextBox();
            salaryTextBox = new TextBox();
            desComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dgvAdvisors = new DataGridView();
            addStudentButton = new Button();
            showAdvisorBtn = new Button();
            updateStudentButton_Click = new Button();
            personBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label8 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAdvisors).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Dock = DockStyle.Fill;
            firstNameTextBox.Location = new Point(231, 3);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(336, 31);
            firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Dock = DockStyle.Fill;
            lastNameTextBox.Location = new Point(801, 3);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(339, 31);
            lastNameTextBox.TabIndex = 1;
            // 
            // genderComboBox
            // 
            genderComboBox.Dock = DockStyle.Fill;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(231, 52);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(336, 33);
            genderComboBox.TabIndex = 2;
            // 
            // dateOfBirthPicker
            // 
            dateOfBirthPicker.Dock = DockStyle.Fill;
            dateOfBirthPicker.Location = new Point(801, 52);
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.Size = new Size(339, 31);
            dateOfBirthPicker.TabIndex = 3;
            // 
            // contactTextBox
            // 
            contactTextBox.Dock = DockStyle.Fill;
            contactTextBox.Location = new Point(231, 101);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.Size = new Size(336, 31);
            contactTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.Dock = DockStyle.Fill;
            emailTextBox.Location = new Point(801, 101);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(339, 31);
            emailTextBox.TabIndex = 5;
            // 
            // salaryTextBox
            // 
            salaryTextBox.Dock = DockStyle.Fill;
            salaryTextBox.Location = new Point(231, 150);
            salaryTextBox.Name = "salaryTextBox";
            salaryTextBox.Size = new Size(336, 31);
            salaryTextBox.TabIndex = 6;
            // 
            // desComboBox
            // 
            desComboBox.Dock = DockStyle.Fill;
            desComboBox.FormattingEnabled = true;
            desComboBox.Location = new Point(801, 150);
            desComboBox.Name = "desComboBox";
            desComboBox.Size = new Size(339, 33);
            desComboBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 49);
            label1.TabIndex = 8;
            label1.Text = "First Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(573, 0);
            label2.Name = "label2";
            label2.Size = new Size(222, 49);
            label2.TabIndex = 9;
            label2.Text = "Last Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(3, 49);
            label3.Name = "label3";
            label3.Size = new Size(222, 49);
            label3.TabIndex = 10;
            label3.Text = "Gender";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(573, 49);
            label4.Name = "label4";
            label4.Size = new Size(222, 49);
            label4.TabIndex = 11;
            label4.Text = "Date Of Birth";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(3, 98);
            label5.Name = "label5";
            label5.Size = new Size(222, 49);
            label5.TabIndex = 12;
            label5.Text = "Contact";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(573, 98);
            label6.Name = "label6";
            label6.Size = new Size(222, 49);
            label6.TabIndex = 13;
            label6.Text = "Email";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(3, 147);
            label7.Name = "label7";
            label7.Size = new Size(222, 50);
            label7.TabIndex = 14;
            label7.Text = "Salary";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvAdvisors
            // 
            dgvAdvisors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdvisors.Dock = DockStyle.Fill;
            dgvAdvisors.Location = new Point(3, 3);
            dgvAdvisors.Name = "dgvAdvisors";
            dgvAdvisors.RowHeadersWidth = 62;
            dgvAdvisors.Size = new Size(1140, 225);
            dgvAdvisors.TabIndex = 15;
            dgvAdvisors.CellContentClick += dgvAdvisors_CellContentClick;
            // 
            // addStudentButton
            // 
            addStudentButton.BackColor = Color.FromArgb(155, 164, 181);
            addStudentButton.Dock = DockStyle.Fill;
            addStudentButton.Font = new Font("Segoe UI", 11F);
            addStudentButton.Location = new Point(3, 3);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(184, 60);
            addStudentButton.TabIndex = 16;
            addStudentButton.Text = "Add";
            addStudentButton.UseVisualStyleBackColor = false;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // showAdvisorBtn
            // 
            showAdvisorBtn.BackColor = Color.FromArgb(155, 164, 181);
            showAdvisorBtn.Dock = DockStyle.Fill;
            showAdvisorBtn.Font = new Font("Segoe UI", 11F);
            showAdvisorBtn.Location = new Point(193, 3);
            showAdvisorBtn.Name = "showAdvisorBtn";
            showAdvisorBtn.Size = new Size(184, 60);
            showAdvisorBtn.TabIndex = 17;
            showAdvisorBtn.Text = "Show Advisor";
            showAdvisorBtn.UseVisualStyleBackColor = false;
            showAdvisorBtn.Click += showAdvisorBtn_Click;
            // 
            // updateStudentButton_Click
            // 
            updateStudentButton_Click.BackColor = Color.FromArgb(155, 164, 181);
            updateStudentButton_Click.Dock = DockStyle.Fill;
            updateStudentButton_Click.Font = new Font("Segoe UI", 11F);
            updateStudentButton_Click.Location = new Point(383, 3);
            updateStudentButton_Click.Name = "updateStudentButton_Click";
            updateStudentButton_Click.Size = new Size(184, 60);
            updateStudentButton_Click.TabIndex = 18;
            updateStudentButton_Click.Text = "Update";
            updateStudentButton_Click.UseVisualStyleBackColor = false;
            updateStudentButton_Click.Click += updateStudentButton_Click_Click;
            // 
            // personBtn
            // 
            personBtn.BackColor = Color.FromArgb(155, 164, 181);
            personBtn.Dock = DockStyle.Fill;
            personBtn.Font = new Font("Segoe UI", 11F);
            personBtn.Location = new Point(573, 3);
            personBtn.Name = "personBtn";
            personBtn.Size = new Size(184, 60);
            personBtn.TabIndex = 19;
            personBtn.Text = "Show Person";
            personBtn.UseVisualStyleBackColor = false;
            personBtn.Click += personBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(155, 164, 181);
            clearBtn.Dock = DockStyle.Fill;
            clearBtn.Font = new Font("Segoe UI", 11F);
            clearBtn.Location = new Point(763, 3);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(184, 60);
            clearBtn.TabIndex = 20;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(155, 164, 181);
            exitBtn.Dock = DockStyle.Fill;
            exitBtn.Font = new Font("Segoe UI", 11F);
            exitBtn.Location = new Point(953, 3);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(187, 60);
            exitBtn.TabIndex = 21;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(label8, 2, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(firstNameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(lastNameTextBox, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(genderComboBox, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 1);
            tableLayoutPanel1.Controls.Add(desComboBox, 3, 3);
            tableLayoutPanel1.Controls.Add(dateOfBirthPicker, 3, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(salaryTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(contactTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(label6, 2, 2);
            tableLayoutPanel1.Controls.Add(emailTextBox, 3, 2);
            tableLayoutPanel1.Location = new Point(42, 113);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(1143, 197);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(573, 147);
            label8.Name = "label8";
            label8.Size = new Size(222, 50);
            label8.TabIndex = 23;
            label8.Text = "Description";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Controls.Add(addStudentButton, 0, 0);
            tableLayoutPanel2.Controls.Add(showAdvisorBtn, 1, 0);
            tableLayoutPanel2.Controls.Add(clearBtn, 4, 0);
            tableLayoutPanel2.Controls.Add(updateStudentButton_Click, 2, 0);
            tableLayoutPanel2.Controls.Add(personBtn, 3, 0);
            tableLayoutPanel2.Controls.Add(exitBtn, 5, 0);
            tableLayoutPanel2.Location = new Point(45, 565);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1143, 66);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(dgvAdvisors, 0, 0);
            tableLayoutPanel3.Location = new Point(42, 327);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1146, 231);
            tableLayoutPanel3.TabIndex = 24;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label9, 0, 0);
            tableLayoutPanel4.Location = new Point(42, 23);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1143, 75);
            tableLayoutPanel4.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(155, 164, 181);
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(1137, 75);
            label9.TabIndex = 0;
            label9.Text = "Add Advisor";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Advisor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1222, 645);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Advisor";
            Text = "Advisor";
            Load += Advisor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdvisors).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private ComboBox genderComboBox;
        private DateTimePicker dateOfBirthPicker;
        private TextBox contactTextBox;
        private TextBox emailTextBox;
        private TextBox salaryTextBox;
        private ComboBox desComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dgvAdvisors;
        private Button addStudentButton;
        private Button showAdvisorBtn;
        private Button updateStudentButton_Click;
        private Button personBtn;
        private Button clearBtn;
        private Button exitBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label9;
    }
}