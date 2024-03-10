namespace WinFormsApp1
{
    partial class assignAdvisor
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
            tableLayoutPanel1 = new TableLayoutPanel();
            AdvisorBoardDataGrid = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            add_Btn = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdvisorBoardDataGrid).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(AdvisorBoardDataGrid, 0, 0);
            tableLayoutPanel1.Location = new Point(77, 117);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(883, 233);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // AdvisorBoardDataGrid
            // 
            AdvisorBoardDataGrid.AllowUserToAddRows = false;
            AdvisorBoardDataGrid.AllowUserToDeleteRows = false;
            AdvisorBoardDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdvisorBoardDataGrid.Dock = DockStyle.Fill;
            AdvisorBoardDataGrid.Location = new Point(3, 3);
            AdvisorBoardDataGrid.Name = "AdvisorBoardDataGrid";
            AdvisorBoardDataGrid.ReadOnly = true;
            AdvisorBoardDataGrid.RowHeadersWidth = 62;
            AdvisorBoardDataGrid.Size = new Size(877, 227);
            AdvisorBoardDataGrid.TabIndex = 0;
            AdvisorBoardDataGrid.CellContentClick += AdvisorBoardDataGrid_CellContentClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(add_Btn, 0, 0);
            tableLayoutPanel2.Location = new Point(791, 367);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(169, 53);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // add_Btn
            // 
            add_Btn.BackColor = Color.FromArgb(155, 164, 181);
            add_Btn.Dock = DockStyle.Fill;
            add_Btn.Location = new Point(3, 3);
            add_Btn.Name = "add_Btn";
            add_Btn.Size = new Size(163, 47);
            add_Btn.TabIndex = 0;
            add_Btn.Text = "Assign Advisor";
            add_Btn.UseVisualStyleBackColor = false;
            add_Btn.Click += add_Btn_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.82792F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.1720886F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(button2, 1, 0);
            tableLayoutPanel3.Location = new Point(74, 17);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(883, 74);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(57, 72, 103);
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.FromArgb(241, 246, 249);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(690, 74);
            label1.TabIndex = 0;
            label1.Text = "Advisors";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(155, 164, 181);
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(699, 3);
            button2.Name = "button2";
            button2.Size = new Size(181, 68);
            button2.TabIndex = 1;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // assignAdvisor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1046, 447);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "assignAdvisor";
            Text = "assignAdvisor";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AdvisorBoardDataGrid).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView AdvisorBoardDataGrid;
        private TableLayoutPanel tableLayoutPanel2;
        private Button add_Btn;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Button button2;
    }
}