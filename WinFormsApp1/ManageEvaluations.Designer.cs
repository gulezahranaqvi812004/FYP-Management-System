namespace WinFormsApp1
{
    partial class ManageEvaluations
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
            nameTxtBox = new TextBox();
            txtTotalMarks = new TextBox();
            txtTotalWeightage = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvEvaluation = new DataGridView();
            addEvalBtn = new Button();
            clearBtn = new Button();
            exitbtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEvaluation).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // nameTxtBox
            // 
            nameTxtBox.Dock = DockStyle.Fill;
            nameTxtBox.Font = new Font("Segoe UI", 11F);
            nameTxtBox.Location = new Point(163, 3);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(317, 37);
            nameTxtBox.TabIndex = 0;
            // 
            // txtTotalMarks
            // 
            txtTotalMarks.Dock = DockStyle.Fill;
            txtTotalMarks.Font = new Font("Segoe UI", 11F);
            txtTotalMarks.Location = new Point(163, 97);
            txtTotalMarks.Name = "txtTotalMarks";
            txtTotalMarks.Size = new Size(317, 37);
            txtTotalMarks.TabIndex = 1;
            // 
            // txtTotalWeightage
            // 
            txtTotalWeightage.Dock = DockStyle.Fill;
            txtTotalWeightage.Font = new Font("Segoe UI", 11F);
            txtTotalWeightage.Location = new Point(163, 191);
            txtTotalWeightage.Name = "txtTotalWeightage";
            txtTotalWeightage.Size = new Size(317, 37);
            txtTotalWeightage.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 94);
            label1.TabIndex = 3;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(3, 94);
            label2.Name = "label2";
            label2.Size = new Size(154, 94);
            label2.TabIndex = 4;
            label2.Text = "Total Marks";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(3, 188);
            label3.Name = "label3";
            label3.Size = new Size(154, 96);
            label3.TabIndex = 5;
            label3.Text = "Total Weightage";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvEvaluation
            // 
            dgvEvaluation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvaluation.Dock = DockStyle.Fill;
            dgvEvaluation.Location = new Point(3, 3);
            dgvEvaluation.Name = "dgvEvaluation";
            dgvEvaluation.RowHeadersWidth = 62;
            dgvEvaluation.Size = new Size(499, 278);
            dgvEvaluation.TabIndex = 6;
            // 
            // addEvalBtn
            // 
            addEvalBtn.BackColor = Color.FromArgb(155, 164, 181);
            addEvalBtn.Dock = DockStyle.Fill;
            addEvalBtn.Font = new Font("Segoe UI", 11F);
            addEvalBtn.Location = new Point(3, 3);
            addEvalBtn.Name = "addEvalBtn";
            addEvalBtn.Size = new Size(329, 63);
            addEvalBtn.TabIndex = 7;
            addEvalBtn.Text = "Add";
            addEvalBtn.UseVisualStyleBackColor = false;
            addEvalBtn.Click += addEvalBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(155, 164, 181);
            clearBtn.Dock = DockStyle.Fill;
            clearBtn.Font = new Font("Segoe UI", 11F);
            clearBtn.Location = new Point(338, 3);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(329, 63);
            clearBtn.TabIndex = 10;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.FromArgb(155, 164, 181);
            exitbtn.Dock = DockStyle.Fill;
            exitbtn.Font = new Font("Segoe UI", 11F);
            exitbtn.Location = new Point(673, 3);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(331, 63);
            exitbtn.TabIndex = 11;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += exitbtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3311119F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3311119F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3377762F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(addEvalBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(clearBtn, 1, 0);
            tableLayoutPanel1.Controls.Add(exitbtn, 2, 0);
            tableLayoutPanel1.Location = new Point(36, 435);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1007, 69);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dgvEvaluation, 0, 0);
            tableLayoutPanel2.Location = new Point(538, 138);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(505, 284);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(nameTxtBox, 1, 0);
            tableLayoutPanel3.Controls.Add(txtTotalWeightage, 1, 2);
            tableLayoutPanel3.Controls.Add(txtTotalMarks, 1, 1);
            tableLayoutPanel3.Location = new Point(36, 138);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(483, 284);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Location = new Point(36, 43);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1007, 83);
            tableLayoutPanel4.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(155, 164, 181);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(1001, 83);
            label4.TabIndex = 0;
            label4.Text = "Manage Evaluation";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageEvaluations
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1062, 542);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "ManageEvaluations";
            Text = "ManageEvaluations";
            ((System.ComponentModel.ISupportInitialize)dgvEvaluation).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox nameTxtBox;
        private TextBox txtTotalMarks;
        private TextBox txtTotalWeightage;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvEvaluation;
        private Button addEvalBtn;
        private Button clearBtn;
        private Button exitbtn;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
    }
}