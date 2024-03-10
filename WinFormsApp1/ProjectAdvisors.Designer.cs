namespace WinFormsApp1
{
    partial class ProjectAdvisors
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
            projectComboBox = new ComboBox();
            mainAdvComboBox = new ComboBox();
            coAdvComboBox = new ComboBox();
            assigmentDatePicker = new DateTimePicker();
            addBtn = new Button();
            showBtn = new Button();
            updateBtn = new Button();
            clearBtn = new Button();
            button1 = new Button();
            advisorGroupDGV = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            industryAdvComboBox = new ComboBox();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)advisorGroupDGV).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // projectComboBox
            // 
            projectComboBox.Dock = DockStyle.Fill;
            projectComboBox.Font = new Font("Segoe UI", 11F);
            projectComboBox.FormattingEnabled = true;
            projectComboBox.Location = new Point(221, 4);
            projectComboBox.Margin = new Padding(4);
            projectComboBox.Name = "projectComboBox";
            projectComboBox.Size = new Size(354, 38);
            projectComboBox.TabIndex = 1;
            projectComboBox.SelectedIndexChanged += advisorIdComboBox_SelectedIndexChanged;
            // 
            // mainAdvComboBox
            // 
            mainAdvComboBox.Dock = DockStyle.Fill;
            mainAdvComboBox.Font = new Font("Segoe UI", 11F);
            mainAdvComboBox.FormattingEnabled = true;
            mainAdvComboBox.Location = new Point(221, 67);
            mainAdvComboBox.Margin = new Padding(4);
            mainAdvComboBox.Name = "mainAdvComboBox";
            mainAdvComboBox.Size = new Size(354, 38);
            mainAdvComboBox.TabIndex = 2;
            // 
            // coAdvComboBox
            // 
            coAdvComboBox.Dock = DockStyle.Fill;
            coAdvComboBox.Font = new Font("Segoe UI", 11F);
            coAdvComboBox.FormattingEnabled = true;
            coAdvComboBox.Location = new Point(221, 130);
            coAdvComboBox.Margin = new Padding(4);
            coAdvComboBox.Name = "coAdvComboBox";
            coAdvComboBox.Size = new Size(354, 38);
            coAdvComboBox.TabIndex = 3;
            // 
            // assigmentDatePicker
            // 
            assigmentDatePicker.Dock = DockStyle.Fill;
            assigmentDatePicker.Font = new Font("Segoe UI", 11F);
            assigmentDatePicker.Location = new Point(221, 256);
            assigmentDatePicker.Margin = new Padding(4);
            assigmentDatePicker.Name = "assigmentDatePicker";
            assigmentDatePicker.Size = new Size(354, 37);
            assigmentDatePicker.TabIndex = 4;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(155, 164, 181);
            addBtn.Dock = DockStyle.Fill;
            addBtn.Location = new Point(4, 4);
            addBtn.Margin = new Padding(4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(215, 49);
            addBtn.TabIndex = 5;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // showBtn
            // 
            showBtn.BackColor = Color.FromArgb(155, 164, 181);
            showBtn.Dock = DockStyle.Fill;
            showBtn.Location = new Point(450, 4);
            showBtn.Margin = new Padding(4);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(215, 49);
            showBtn.TabIndex = 6;
            showBtn.Text = "Show";
            showBtn.UseVisualStyleBackColor = false;
            showBtn.Click += showBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(155, 164, 181);
            updateBtn.Dock = DockStyle.Fill;
            updateBtn.Location = new Point(227, 4);
            updateBtn.Margin = new Padding(4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(215, 49);
            updateBtn.TabIndex = 7;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(155, 164, 181);
            clearBtn.Dock = DockStyle.Fill;
            clearBtn.Location = new Point(673, 4);
            clearBtn.Margin = new Padding(4);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(215, 49);
            clearBtn.TabIndex = 8;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(155, 164, 181);
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(896, 4);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(218, 49);
            button1.TabIndex = 9;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // advisorGroupDGV
            // 
            advisorGroupDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advisorGroupDGV.Dock = DockStyle.Fill;
            advisorGroupDGV.Location = new Point(4, 4);
            advisorGroupDGV.Margin = new Padding(4);
            advisorGroupDGV.Name = "advisorGroupDGV";
            advisorGroupDGV.RowHeadersWidth = 62;
            advisorGroupDGV.Size = new Size(520, 309);
            advisorGroupDGV.TabIndex = 10;
            advisorGroupDGV.CellContentClick += advisorGroupDGV_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(209, 63);
            label1.TabIndex = 11;
            label1.Text = "Project ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(4, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(209, 63);
            label2.TabIndex = 12;
            label2.Text = "Main Advisor";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(4, 126);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(209, 63);
            label3.TabIndex = 13;
            label3.Text = "Co Advisor ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(4, 252);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(209, 65);
            label4.TabIndex = 14;
            label4.Text = "Assignment Date";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // industryAdvComboBox
            // 
            industryAdvComboBox.Dock = DockStyle.Fill;
            industryAdvComboBox.Font = new Font("Segoe UI", 11F);
            industryAdvComboBox.FormattingEnabled = true;
            industryAdvComboBox.Location = new Point(221, 193);
            industryAdvComboBox.Margin = new Padding(4);
            industryAdvComboBox.Name = "industryAdvComboBox";
            industryAdvComboBox.Size = new Size(354, 38);
            industryAdvComboBox.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(4, 189);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(209, 63);
            label5.TabIndex = 16;
            label5.Text = "Industry Advisor ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(projectComboBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(mainAdvComboBox, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(assigmentDatePicker, 1, 4);
            tableLayoutPanel1.Controls.Add(coAdvComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(industryAdvComboBox, 1, 3);
            tableLayoutPanel1.Location = new Point(29, 131);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(579, 317);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(advisorGroupDGV, 0, 0);
            tableLayoutPanel2.Location = new Point(615, 131);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(528, 317);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(addBtn, 0, 0);
            tableLayoutPanel3.Controls.Add(updateBtn, 1, 0);
            tableLayoutPanel3.Controls.Add(showBtn, 2, 0);
            tableLayoutPanel3.Controls.Add(clearBtn, 3, 0);
            tableLayoutPanel3.Controls.Add(button1, 4, 0);
            tableLayoutPanel3.Location = new Point(25, 479);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1118, 57);
            tableLayoutPanel3.TabIndex = 19;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Location = new Point(29, 26);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1114, 83);
            tableLayoutPanel4.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(155, 164, 181);
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(1108, 83);
            label6.TabIndex = 0;
            label6.Text = "Manage Advisors";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProjectAdvisors
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1155, 569);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "ProjectAdvisors";
            Text = "ProjectAdvisors";
            Load += ProjectAdvisors_Load;
            ((System.ComponentModel.ISupportInitialize)advisorGroupDGV).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox projectComboBox;
        private ComboBox mainAdvComboBox;
        private ComboBox coAdvComboBox;
        private DateTimePicker assigmentDatePicker;
        private Button addBtn;
        private Button showBtn;
        private Button updateBtn;
        private Button clearBtn;
        private Button button1;
        private DataGridView advisorGroupDGV;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox industryAdvComboBox;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label6;
    }
}