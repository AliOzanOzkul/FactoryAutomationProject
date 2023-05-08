namespace Otomasyon.UI
{
    partial class MainForm
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
            panel1 = new Panel();
            pnlMenu = new Panel();
            btnExpenses = new Button();
            btnTask = new Button();
            btnMessages = new Button();
            btnAtten = new Button();
            btnEmployee = new Button();
            btnDash = new Button();
            pnlScreen = new Panel();
            panel1.SuspendLayout();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(pnlMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 158);
            panel1.TabIndex = 0;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(btnExpenses);
            pnlMenu.Controls.Add(btnTask);
            pnlMenu.Controls.Add(btnMessages);
            pnlMenu.Controls.Add(btnAtten);
            pnlMenu.Controls.Add(btnEmployee);
            pnlMenu.Controls.Add(btnDash);
            pnlMenu.Location = new Point(12, 120);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(654, 38);
            pnlMenu.TabIndex = 1;
            // 
            // btnExpenses
            // 
            btnExpenses.Dock = DockStyle.Left;
            btnExpenses.FlatAppearance.BorderSize = 0;
            btnExpenses.FlatStyle = FlatStyle.Flat;
            btnExpenses.Location = new Point(507, 0);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(103, 38);
            btnExpenses.TabIndex = 4;
            btnExpenses.Text = "EXPENSES";
            btnExpenses.UseVisualStyleBackColor = true;
            btnExpenses.Click += btnExpenses_Click;
            // 
            // btnTask
            // 
            btnTask.Dock = DockStyle.Left;
            btnTask.FlatAppearance.BorderSize = 0;
            btnTask.FlatStyle = FlatStyle.Flat;
            btnTask.Location = new Point(404, 0);
            btnTask.Name = "btnTask";
            btnTask.Size = new Size(103, 38);
            btnTask.TabIndex = 3;
            btnTask.Text = "TASK PORTAL";
            btnTask.UseVisualStyleBackColor = true;
            btnTask.Click += btnTask_Click;
            // 
            // btnMessages
            // 
            btnMessages.Dock = DockStyle.Left;
            btnMessages.FlatAppearance.BorderSize = 0;
            btnMessages.FlatStyle = FlatStyle.Flat;
            btnMessages.Location = new Point(301, 0);
            btnMessages.Name = "btnMessages";
            btnMessages.Size = new Size(103, 38);
            btnMessages.TabIndex = 2;
            btnMessages.Text = "MESSAGES";
            btnMessages.UseVisualStyleBackColor = true;
            btnMessages.Click += btnMessages_Click;
            // 
            // btnAtten
            // 
            btnAtten.Dock = DockStyle.Left;
            btnAtten.FlatAppearance.BorderSize = 0;
            btnAtten.FlatStyle = FlatStyle.Flat;
            btnAtten.Location = new Point(198, 0);
            btnAtten.Name = "btnAtten";
            btnAtten.Size = new Size(103, 38);
            btnAtten.TabIndex = 1;
            btnAtten.Text = "ATTENDANCE";
            btnAtten.UseVisualStyleBackColor = true;
            btnAtten.Click += btnAtten_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Dock = DockStyle.Left;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Location = new Point(95, 0);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(103, 38);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "EMPLOYEE";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnDash
            // 
            btnDash.Dock = DockStyle.Left;
            btnDash.FlatAppearance.BorderSize = 0;
            btnDash.FlatStyle = FlatStyle.Flat;
            btnDash.Location = new Point(0, 0);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(95, 38);
            btnDash.TabIndex = 0;
            btnDash.Text = "DASHBOARD";
            btnDash.UseVisualStyleBackColor = true;
            btnDash.Click += btnDash_Click;
            // 
            // pnlScreen
            // 
            pnlScreen.Dock = DockStyle.Fill;
            pnlScreen.Location = new Point(0, 158);
            pnlScreen.Name = "pnlScreen";
            pnlScreen.Size = new Size(984, 529);
            pnlScreen.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 687);
            Controls.Add(pnlScreen);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 726);
            MinimumSize = new Size(1000, 726);
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlScreen;
        private Button btnEmployee;
        private Button btnDash;
        private Panel pnlMenu;
        private Button btnExpenses;
        private Button btnTask;
        private Button btnMessages;
        private Button btnAtten;
    }
}