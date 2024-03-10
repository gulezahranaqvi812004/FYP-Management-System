namespace WinFormsApp1
{
    partial class GroupEvaluation
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
            evaluationIdcomboBox = new ComboBox();
            groupIdComboBox = new ComboBox();
            evaluationDatePicker = new DateTimePicker();
            obtainedTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupEvaluationDGV = new DataGridView();
            addBtn = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)groupEvaluationDGV).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // evaluationIdcomboBox
            // 
            evaluationIdcomboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            evaluationIdcomboBox.FormattingEnabled = true;
            evaluationIdcomboBox.Location = new Point(294, 3);
            evaluationIdcomboBox.Name = "evaluationIdcomboBox";
            evaluationIdcomboBox.Size = new Size(885, 33);
            evaluationIdcomboBox.TabIndex = 0;
            // 
            // groupIdComboBox
            // 
            groupIdComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupIdComboBox.FormattingEnabled = true;
            groupIdComboBox.Location = new Point(294, 56);
            groupIdComboBox.Name = "groupIdComboBox";
            groupIdComboBox.Size = new Size(885, 33);
            groupIdComboBox.TabIndex = 1;
            // 
            // evaluationDatePicker
            // 
            evaluationDatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            evaluationDatePicker.Location = new Point(294, 109);
            evaluationDatePicker.Name = "evaluationDatePicker";
            evaluationDatePicker.Size = new Size(885, 31);
            evaluationDatePicker.TabIndex = 2;
            // 
            // obtainedTextBox
            // 
            obtainedTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            obtainedTextBox.Location = new Point(294, 162);
            obtainedTextBox.Name = "obtainedTextBox";
            obtainedTextBox.Size = new Size(885, 31);
            obtainedTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(285, 53);
            label1.TabIndex = 4;
            label1.Text = "Evaluation ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(3, 53);
            label2.Name = "label2";
            label2.Size = new Size(285, 53);
            label2.TabIndex = 5;
            label2.Text = "Group ID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(3, 106);
            label3.Name = "label3";
            label3.Size = new Size(285, 53);
            label3.TabIndex = 6;
            label3.Text = "Evaluation Date";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(3, 159);
            label4.Name = "label4";
            label4.Size = new Size(285, 54);
            label4.TabIndex = 7;
            label4.Text = "Obtained Marks";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupEvaluationDGV
            // 
            groupEvaluationDGV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupEvaluationDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            groupEvaluationDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            groupEvaluationDGV.Location = new Point(3, 3);
            groupEvaluationDGV.Name = "groupEvaluationDGV";
            groupEvaluationDGV.RowHeadersWidth = 62;
            groupEvaluationDGV.Size = new Size(1176, 185);
            groupEvaluationDGV.TabIndex = 8;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addBtn.BackColor = Color.FromArgb(155, 164, 181);
            addBtn.Font = new Font("Segoe UI", 11F);
            addBtn.Location = new Point(3, 3);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(387, 61);
            addBtn.TabIndex = 9;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clearBtn.BackColor = Color.FromArgb(155, 164, 181);
            clearBtn.Font = new Font("Segoe UI", 11F);
            clearBtn.Location = new Point(396, 3);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(387, 61);
            clearBtn.TabIndex = 12;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            exitBtn.BackColor = Color.FromArgb(155, 164, 181);
            exitBtn.Font = new Font("Segoe UI", 11F);
            exitBtn.Location = new Point(789, 3);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(390, 61);
            exitBtn.TabIndex = 13;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.6987953F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.30121F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(evaluationIdcomboBox, 1, 0);
            tableLayoutPanel1.Controls.Add(groupIdComboBox, 1, 1);
            tableLayoutPanel1.Controls.Add(evaluationDatePicker, 1, 2);
            tableLayoutPanel1.Controls.Add(obtainedTextBox, 1, 3);
            tableLayoutPanel1.Location = new Point(29, 99);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(1182, 213);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupEvaluationDGV, 0, 0);
            tableLayoutPanel2.Location = new Point(29, 329);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1182, 191);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3311119F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3311119F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3377762F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(addBtn, 0, 0);
            tableLayoutPanel3.Controls.Add(exitBtn, 2, 0);
            tableLayoutPanel3.Controls.Add(clearBtn, 1, 0);
            tableLayoutPanel3.Location = new Point(29, 536);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1182, 67);
            tableLayoutPanel3.TabIndex = 16;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Font = new Font("Segoe UI", 14F);
            tableLayoutPanel4.Location = new Point(29, 41);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1182, 47);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(155, 164, 181);
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(1176, 47);
            label5.TabIndex = 0;
            label5.Text = "Evaluate Groups";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GroupEvaluation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 246, 249);
            ClientSize = new Size(1243, 629);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "GroupEvaluation";
            Text = "GroupEvaluation";
            Load += GroupEvaluation_Load;
            ((System.ComponentModel.ISupportInitialize)groupEvaluationDGV).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox evaluationIdcomboBox;
        private ComboBox groupIdComboBox;
        private DateTimePicker evaluationDatePicker;
        private TextBox obtainedTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView groupEvaluationDGV;
        private Button addBtn;
        private Button clearBtn;
        private Button exitBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label5;
    }
}