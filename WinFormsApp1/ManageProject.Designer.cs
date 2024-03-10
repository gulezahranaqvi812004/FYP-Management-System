namespace WinFormsApp1
{
    partial class s
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
            dgvAdvisors = new DataGridView();
            titleTextBox = new TextBox();
            descritionTxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            addBtn = new Button();
            clearBtn = new Button();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAdvisors).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAdvisors
            // 
            dgvAdvisors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAdvisors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdvisors.Dock = DockStyle.Fill;
            dgvAdvisors.Location = new Point(3, 3);
            dgvAdvisors.Name = "dgvAdvisors";
            dgvAdvisors.RowHeadersWidth = 62;
            dgvAdvisors.Size = new Size(427, 211);
            dgvAdvisors.TabIndex = 0;
            // 
            // titleTextBox
            // 
            titleTextBox.Dock = DockStyle.Fill;
            titleTextBox.Font = new Font("Segoe UI", 11F);
            titleTextBox.Location = new Point(278, 3);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.PlaceholderText = "Enter project title";
            titleTextBox.Size = new Size(269, 37);
            titleTextBox.TabIndex = 1;
            // 
            // descritionTxtBox
            // 
            descritionTxtBox.Dock = DockStyle.Fill;
            descritionTxtBox.Font = new Font("Segoe UI", 11F);
            descritionTxtBox.Location = new Point(278, 111);
            descritionTxtBox.Name = "descritionTxtBox";
            descritionTxtBox.PlaceholderText = "Enter project description";
            descritionTxtBox.Size = new Size(269, 37);
            descritionTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(269, 108);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(3, 108);
            label2.Name = "label2";
            label2.Size = new Size(269, 109);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(155, 164, 181);
            addBtn.Dock = DockStyle.Fill;
            addBtn.Font = new Font("Segoe UI", 11F);
            addBtn.Location = new Point(3, 3);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(497, 61);
            addBtn.TabIndex = 5;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(155, 164, 181);
            clearBtn.Dock = DockStyle.Fill;
            clearBtn.Font = new Font("Segoe UI", 11F);
            clearBtn.Location = new Point(506, 3);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(497, 61);
            clearBtn.TabIndex = 8;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(155, 164, 181);
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(897, 3);
            button1.Name = "button1";
            button1.Size = new Size(92, 69);
            button1.TabIndex = 9;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(titleTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(descritionTxtBox, 1, 1);
            tableLayoutPanel1.Location = new Point(37, 159);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(550, 217);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(addBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(clearBtn, 1, 0);
            tableLayoutPanel2.Location = new Point(34, 396);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1006, 67);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(dgvAdvisors, 0, 0);
            tableLayoutPanel3.Location = new Point(610, 159);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(433, 217);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.19243F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.807573F));
            tableLayoutPanel4.Controls.Add(button1, 1, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Location = new Point(37, 41);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(992, 75);
            tableLayoutPanel4.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(155, 164, 181);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(888, 75);
            label3.TabIndex = 10;
            label3.Text = "Manage Projects";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // s
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1055, 523);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "s";
            Text = "ManageProjects";
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

        private DataGridView dgvAdvisors;
        private TextBox titleTextBox;
        private TextBox descritionTxtBox;
        private Label label1;
        private Label label2;
        private Button addBtn;
        private Button clearBtn;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
    }
}