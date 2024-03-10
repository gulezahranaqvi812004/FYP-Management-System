namespace WinFormsApp1
{
    partial class Report
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
            reportDGV = new DataGridView();
            report1 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button5 = new Button();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)reportDGV).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // reportDGV
            // 
            reportDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            reportDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportDGV.Dock = DockStyle.Fill;
            reportDGV.Location = new Point(3, 3);
            reportDGV.Name = "reportDGV";
            reportDGV.RowHeadersWidth = 62;
            reportDGV.Size = new Size(916, 391);
            reportDGV.TabIndex = 0;
            // 
            // report1
            // 
            report1.BackColor = Color.FromArgb(155, 164, 181);
            report1.Dock = DockStyle.Fill;
            report1.Location = new Point(3, 3);
            report1.Name = "report1";
            report1.Size = new Size(179, 82);
            report1.TabIndex = 1;
            report1.Text = "Advisors And Project";
            report1.UseVisualStyleBackColor = false;
            report1.Click += report1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(155, 164, 181);
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(188, 3);
            button1.Name = "button1";
            button1.Size = new Size(179, 82);
            button1.TabIndex = 2;
            button1.Text = "Student And Advisor";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(155, 164, 181);
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(373, 3);
            button2.Name = "button2";
            button2.Size = new Size(179, 82);
            button2.TabIndex = 3;
            button2.Text = "Student Not in group";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(155, 164, 181);
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(558, 3);
            button3.Name = "button3";
            button3.Size = new Size(179, 82);
            button3.TabIndex = 4;
            button3.Text = "Mark Sheet";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(155, 164, 181);
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(743, 3);
            button4.Name = "button4";
            button4.Size = new Size(182, 82);
            button4.TabIndex = 5;
            button4.Text = "Students in each Group";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.85859F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.1414137F));
            tableLayoutPanel1.Controls.Add(button5, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(88, 39);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(928, 56);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(155, 164, 181);
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(799, 3);
            button5.Name = "button5";
            button5.Size = new Size(126, 50);
            button5.TabIndex = 9;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(57, 72, 103);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.FromArgb(241, 246, 249);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(790, 56);
            label1.TabIndex = 0;
            label1.Text = "View data";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(reportDGV, 0, 0);
            tableLayoutPanel2.Location = new Point(91, 101);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(922, 397);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(report1, 0, 0);
            tableLayoutPanel3.Controls.Add(button1, 1, 0);
            tableLayoutPanel3.Controls.Add(button2, 2, 0);
            tableLayoutPanel3.Controls.Add(button4, 4, 0);
            tableLayoutPanel3.Controls.Add(button3, 3, 0);
            tableLayoutPanel3.Location = new Point(88, 504);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(928, 88);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1121, 628);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Report";
            Text = "Report";
            ((System.ComponentModel.ISupportInitialize)reportDGV).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView reportDGV;
        private Button report1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button5;
        private Label label1;
    }
}