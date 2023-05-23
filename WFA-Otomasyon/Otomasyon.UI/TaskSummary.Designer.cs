namespace Otomasyon.UI
{
    partial class TaskSummary
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
            rtbxPage = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            lblName = new Label();
            lblDeadLine = new Label();
            lblStarTime = new Label();
            SuspendLayout();
            // 
            // rtbxPage
            // 
            rtbxPage.Location = new Point(14, 99);
            rtbxPage.Margin = new Padding(3, 4, 3, 4);
            rtbxPage.Name = "rtbxPage";
            rtbxPage.ReadOnly = true;
            rtbxPage.Size = new Size(601, 326);
            rtbxPage.TabIndex = 1;
            rtbxPage.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 24);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 2;
            label2.Text = "NAME :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(335, 24);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 3;
            label1.Text = "START TIME :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 63);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 4;
            label3.Text = "DEAD LINE :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(90, 24);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 23);
            lblName.TabIndex = 5;
            // 
            // lblDeadLine
            // 
            lblDeadLine.AutoSize = true;
            lblDeadLine.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeadLine.Location = new Point(122, 63);
            lblDeadLine.Name = "lblDeadLine";
            lblDeadLine.Size = new Size(0, 23);
            lblDeadLine.TabIndex = 5;
            // 
            // lblStarTime
            // 
            lblStarTime.AutoSize = true;
            lblStarTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStarTime.Location = new Point(452, 24);
            lblStarTime.Name = "lblStarTime";
            lblStarTime.Size = new Size(0, 23);
            lblStarTime.TabIndex = 5;
            // 
            // TaskSummary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 438);
            Controls.Add(lblStarTime);
            Controls.Add(lblDeadLine);
            Controls.Add(lblName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(rtbxPage);
            Name = "TaskSummary";
            Text = "TaskSummary";
            Load += TaskSummary_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbxPage;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label lblName;
        private Label lblDeadLine;
        private Label lblStarTime;
    }
}