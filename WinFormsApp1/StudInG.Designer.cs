namespace WinFormsApp1
{
    partial class StudInG
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
            GroupDataGrid = new DataGridView();
            createGroupBtn = new Button();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)GroupDataGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // GroupDataGrid
            // 
            GroupDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GroupDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GroupDataGrid.Location = new Point(52, 142);
            GroupDataGrid.Name = "GroupDataGrid";
            GroupDataGrid.RowHeadersWidth = 62;
            GroupDataGrid.Size = new Size(861, 337);
            GroupDataGrid.TabIndex = 0;
            GroupDataGrid.CellContentClick += GroupDataGrid_CellContentClick;
            // 
            // createGroupBtn
            // 
            createGroupBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            createGroupBtn.BackColor = Color.FromArgb(155, 164, 181);
            createGroupBtn.Location = new Point(637, 489);
            createGroupBtn.Name = "createGroupBtn";
            createGroupBtn.Size = new Size(276, 55);
            createGroupBtn.TabIndex = 1;
            createGroupBtn.Text = "Create Group";
            createGroupBtn.UseVisualStyleBackColor = false;
            createGroupBtn.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(155, 164, 181);
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(734, 3);
            button1.Name = "button1";
            button1.Size = new Size(124, 50);
            button1.TabIndex = 2;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(49, 61);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(861, 56);
            tableLayoutPanel1.TabIndex = 3;
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
            label1.Size = new Size(725, 56);
            label1.TabIndex = 3;
            label1.Text = "Group Formation";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudInG
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(964, 574);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(createGroupBtn);
            Controls.Add(GroupDataGrid);
            Name = "StudInG";
            Text = "StudInG";
            ((System.ComponentModel.ISupportInitialize)GroupDataGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GroupDataGrid;
        private Button createGroupBtn;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
    }
}