namespace WinFormsApp1
{
    partial class viewStud
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
            StudentdataGridView = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentdataGridView).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(StudentdataGridView, 0, 0);
            tableLayoutPanel1.Location = new Point(70, 122);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(973, 401);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // StudentdataGridView
            // 
            StudentdataGridView.AllowUserToAddRows = false;
            StudentdataGridView.AllowUserToDeleteRows = false;
            StudentdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentdataGridView.Dock = DockStyle.Fill;
            StudentdataGridView.Location = new Point(3, 3);
            StudentdataGridView.Name = "StudentdataGridView";
            StudentdataGridView.ReadOnly = true;
            StudentdataGridView.RowHeadersWidth = 62;
            StudentdataGridView.Size = new Size(967, 395);
            StudentdataGridView.TabIndex = 0;
            StudentdataGridView.CellContentClick += StudentdataGridView_CellContentClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.92308F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0769234F));
            tableLayoutPanel2.Controls.Add(button1, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(70, 48);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(970, 58);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(155, 164, 181);
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 8.25F);
            button1.Location = new Point(749, 3);
            button1.Name = "button1";
            button1.Size = new Size(218, 52);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(155, 164, 181);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(740, 58);
            label1.TabIndex = 1;
            label1.Text = "View Students";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // viewStud
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1116, 557);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "viewStud";
            Text = "viewStud";
            Load += viewStud_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentdataGridView).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView StudentdataGridView;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Label label1;
    }
}