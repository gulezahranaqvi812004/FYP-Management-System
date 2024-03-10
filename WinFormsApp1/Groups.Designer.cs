namespace WinFormsApp1
{
    partial class Groups
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
            groupDataGridView = new DataGridView();
            groupDatePicker = new DateTimePicker();
            addGroupBtn = new Button();
            showGroupBtn = new Button();
            updateGroupBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)groupDataGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupDataGridView
            // 
            groupDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            groupDataGridView.Dock = DockStyle.Fill;
            groupDataGridView.Location = new Point(3, 3);
            groupDataGridView.Name = "groupDataGridView";
            groupDataGridView.RowHeadersWidth = 62;
            groupDataGridView.Size = new Size(1026, 233);
            groupDataGridView.TabIndex = 0;
            groupDataGridView.CellContentClick += groupDataGridView_CellContentClick;
            // 
            // groupDatePicker
            // 
            groupDatePicker.Dock = DockStyle.Fill;
            groupDatePicker.Font = new Font("Segoe UI", 11F);
            groupDatePicker.Location = new Point(3, 91);
            groupDatePicker.Name = "groupDatePicker";
            groupDatePicker.Size = new Size(1026, 37);
            groupDatePicker.TabIndex = 1;
            // 
            // addGroupBtn
            // 
            addGroupBtn.BackColor = Color.FromArgb(155, 164, 181);
            addGroupBtn.Dock = DockStyle.Fill;
            addGroupBtn.Font = new Font("Segoe UI", 11F);
            addGroupBtn.Location = new Point(3, 3);
            addGroupBtn.Name = "addGroupBtn";
            addGroupBtn.Size = new Size(252, 88);
            addGroupBtn.TabIndex = 2;
            addGroupBtn.Text = "Add";
            addGroupBtn.UseVisualStyleBackColor = false;
            addGroupBtn.Click += addGroupBtn_Click;
            // 
            // showGroupBtn
            // 
            showGroupBtn.BackColor = Color.FromArgb(155, 164, 181);
            showGroupBtn.Dock = DockStyle.Fill;
            showGroupBtn.Font = new Font("Segoe UI", 11F);
            showGroupBtn.Location = new Point(261, 3);
            showGroupBtn.Name = "showGroupBtn";
            showGroupBtn.Size = new Size(252, 88);
            showGroupBtn.TabIndex = 3;
            showGroupBtn.Text = "Display";
            showGroupBtn.UseVisualStyleBackColor = false;
            showGroupBtn.Click += showGroupBtn_Click;
            // 
            // updateGroupBtn
            // 
            updateGroupBtn.BackColor = Color.FromArgb(155, 164, 181);
            updateGroupBtn.Dock = DockStyle.Fill;
            updateGroupBtn.Font = new Font("Segoe UI", 11F);
            updateGroupBtn.Location = new Point(519, 3);
            updateGroupBtn.Name = "updateGroupBtn";
            updateGroupBtn.Size = new Size(252, 88);
            updateGroupBtn.TabIndex = 4;
            updateGroupBtn.Text = "Update";
            updateGroupBtn.UseVisualStyleBackColor = false;
            updateGroupBtn.Click += updateGroupBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupDataGridView, 0, 0);
            tableLayoutPanel1.Location = new Point(36, 195);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1032, 239);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(button1, 3, 0);
            tableLayoutPanel2.Controls.Add(addGroupBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(updateGroupBtn, 2, 0);
            tableLayoutPanel2.Controls.Add(showGroupBtn, 1, 0);
            tableLayoutPanel2.Location = new Point(33, 456);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1035, 94);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(155, 164, 181);
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(777, 3);
            button1.Name = "button1";
            button1.Size = new Size(255, 88);
            button1.TabIndex = 7;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(groupDatePicker, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Location = new Point(36, 35);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 58.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 41.6666679F));
            tableLayoutPanel3.Size = new Size(1032, 152);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(155, 164, 181);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1026, 88);
            label1.TabIndex = 2;
            label1.Text = "View Groups";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Groups
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1095, 580);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Groups";
            Text = "Groups";
            ((System.ComponentModel.ISupportInitialize)groupDataGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView groupDataGridView;
        private DateTimePicker groupDatePicker;
        private Button addGroupBtn;
        private Button showGroupBtn;
        private Button updateGroupBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
    }
}