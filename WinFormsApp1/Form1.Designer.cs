namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            button1 = new Button();
            flowLayoutPanel10 = new FlowLayoutPanel();
            button10 = new Button();
            flowLayoutPanel9 = new FlowLayoutPanel();
            button9 = new Button();
            flowLayoutPanel8 = new FlowLayoutPanel();
            button8 = new Button();
            flowLayoutPanel7 = new FlowLayoutPanel();
            button7 = new Button();
            flowLayoutPanel6 = new FlowLayoutPanel();
            button6 = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            button5 = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 119);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel10);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel2);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel1.Controls.Add(button10);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel9);
            splitContainer1.Panel1.Controls.Add(button9);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel8);
            splitContainer1.Panel1.Controls.Add(button8);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel7);
            splitContainer1.Panel1.Controls.Add(button7);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel6);
            splitContainer1.Panel1.Controls.Add(button6);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel5);
            splitContainer1.Panel1.Controls.Add(button5);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel4);
            splitContainer1.Panel1.Controls.Add(button4);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1169, 744);
            splitContainer1.SplitterDistance = 367;
            splitContainer1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(81, 159);
            button1.Name = "button1";
            button1.Size = new Size(198, 34);
            button1.TabIndex = 1;
            button1.Text = "Manage Students";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.BackgroundImage = Properties.Resources.apprentice;
            flowLayoutPanel10.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel10.Location = new Point(25, 623);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(40, 34);
            flowLayoutPanel10.TabIndex = 8;
            // 
            // button10
            // 
            button10.Location = new Point(81, 623);
            button10.Name = "button10";
            button10.Size = new Size(198, 34);
            button10.TabIndex = 10;
            button10.Text = "Generate Report";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.BackgroundImage = Properties.Resources.apprentice;
            flowLayoutPanel9.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel9.Location = new Point(25, 570);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(40, 34);
            flowLayoutPanel9.TabIndex = 7;
            // 
            // button9
            // 
            button9.Location = new Point(81, 570);
            button9.Name = "button9";
            button9.Size = new Size(198, 34);
            button9.TabIndex = 9;
            button9.Text = "Mark Evaluation";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.BackgroundImage = Properties.Resources.apprentice;
            flowLayoutPanel8.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel8.Location = new Point(25, 500);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(40, 34);
            flowLayoutPanel8.TabIndex = 6;
            // 
            // button8
            // 
            button8.Location = new Point(81, 500);
            button8.Name = "button8";
            button8.Size = new Size(198, 34);
            button8.TabIndex = 8;
            button8.Text = "Manage Advisors";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.BackgroundImage = Properties.Resources.apprentice;
            flowLayoutPanel7.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel7.Location = new Point(25, 443);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(40, 34);
            flowLayoutPanel7.TabIndex = 5;
            // 
            // button7
            // 
            button7.Location = new Point(81, 443);
            button7.Name = "button7";
            button7.Size = new Size(198, 34);
            button7.TabIndex = 7;
            button7.Text = "Assign Projects";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.BackgroundImage = Properties.Resources.apprentice;
            flowLayoutPanel6.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel6.Location = new Point(25, 384);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(40, 34);
            flowLayoutPanel6.TabIndex = 4;
            // 
            // button6
            // 
            button6.Location = new Point(81, 384);
            button6.Name = "button6";
            button6.Size = new Size(198, 34);
            button6.TabIndex = 6;
            button6.Text = "Group Formation";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BackgroundImage = Properties.Resources.apprentice;
            flowLayoutPanel5.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel5.Location = new Point(25, 327);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(40, 34);
            flowLayoutPanel5.TabIndex = 3;
            // 
            // button5
            // 
            button5.Location = new Point(81, 327);
            button5.Name = "button5";
            button5.Size = new Size(198, 34);
            button5.TabIndex = 5;
            button5.Text = "Group Date";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackgroundImage = Properties.Resources.apprentice;
            flowLayoutPanel4.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel4.Location = new Point(25, 266);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(40, 34);
            flowLayoutPanel4.TabIndex = 2;
            // 
            // button4
            // 
            button4.Location = new Point(81, 266);
            button4.Name = "button4";
            button4.Size = new Size(198, 34);
            button4.TabIndex = 4;
            button4.Text = "Assign Advisor";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(81, 212);
            button3.Name = "button3";
            button3.Size = new Size(198, 34);
            button3.TabIndex = 3;
            button3.Text = "Manage Evaluations";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel3.BackgroundImage");
            flowLayoutPanel3.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel3.Location = new Point(25, 212);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(40, 34);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel2.BackgroundImage");
            flowLayoutPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel2.Location = new Point(25, 110);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(40, 34);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(81, 114);
            button2.Name = "button2";
            button2.Size = new Size(198, 34);
            button2.TabIndex = 2;
            button2.Text = "Manage Projects";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImage = Properties.Resources.apprentice;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.Location = new Point(25, 159);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(40, 34);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 744);
            Controls.Add(splitContainer1);
            Controls.Add(label1);
            MinimumSize = new Size(1191, 800);
            Name = "Form1";
            Text = "Main Form";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private SplitContainer splitContainer1;
        private Button button2;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button button5;
        private FlowLayoutPanel flowLayoutPanel6;
        private Button button6;
        private FlowLayoutPanel flowLayoutPanel7;
        private Button button7;
        private FlowLayoutPanel flowLayoutPanel8;
        private Button button8;
        private Button button9;
        private FlowLayoutPanel flowLayoutPanel9;
        private FlowLayoutPanel flowLayoutPanel10;
        private Button button10;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
