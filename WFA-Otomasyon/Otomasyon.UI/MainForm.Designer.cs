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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            Colorlbl = new Label();
            pnlMenu = new Panel();
            btnExpenses = new Button();
            ımageList1 = new ImageList(components);
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
            panel1.Controls.Add(Colorlbl);
            panel1.Controls.Add(pnlMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 165);
            panel1.TabIndex = 0;
            // 
            // Colorlbl
            // 
            Colorlbl.BackColor = Color.RoyalBlue;
            Colorlbl.Location = new Point(3, 170);
            Colorlbl.Name = "Colorlbl";
            Colorlbl.Size = new Size(9, 8);
            Colorlbl.TabIndex = 2;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(btnExpenses);
            pnlMenu.Controls.Add(btnTask);
            pnlMenu.Controls.Add(btnMessages);
            pnlMenu.Controls.Add(btnAtten);
            pnlMenu.Controls.Add(btnEmployee);
            pnlMenu.Controls.Add(btnDash);
            pnlMenu.Location = new Point(10, 107);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(654, 51);
            pnlMenu.TabIndex = 1;
            // 
            // btnExpenses
            // 
            btnExpenses.Dock = DockStyle.Left;
            btnExpenses.FlatAppearance.BorderSize = 0;
            btnExpenses.FlatStyle = FlatStyle.Flat;
            btnExpenses.ImageAlign = ContentAlignment.BottomCenter;
            btnExpenses.ImageKey = "EXPENSES.png";
            btnExpenses.ImageList = ımageList1;
            btnExpenses.Location = new Point(507, 0);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(103, 51);
            btnExpenses.TabIndex = 4;
            btnExpenses.Text = "EXPENSES";
            btnExpenses.TextAlign = ContentAlignment.TopCenter;
            btnExpenses.UseVisualStyleBackColor = true;
            btnExpenses.Click += btnExpenses_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "ATTENDANCE.png");
            ımageList1.Images.SetKeyName(1, "DASHBOARD.png");
            ımageList1.Images.SetKeyName(2, "EMPLOYEES.png");
            ımageList1.Images.SetKeyName(3, "EXPENSES.png");
            ımageList1.Images.SetKeyName(4, "FILES.png");
            ımageList1.Images.SetKeyName(5, "MESSAGES.png");
            ımageList1.Images.SetKeyName(6, "TASK PORTAL.png");
            // 
            // btnTask
            // 
            btnTask.Dock = DockStyle.Left;
            btnTask.FlatAppearance.BorderSize = 0;
            btnTask.FlatStyle = FlatStyle.Flat;
            btnTask.ImageAlign = ContentAlignment.BottomCenter;
            btnTask.ImageKey = "TASK PORTAL.png";
            btnTask.ImageList = ımageList1;
            btnTask.Location = new Point(404, 0);
            btnTask.Name = "btnTask";
            btnTask.Size = new Size(103, 51);
            btnTask.TabIndex = 3;
            btnTask.Text = "TASK PORTAL";
            btnTask.TextAlign = ContentAlignment.TopCenter;
            btnTask.UseVisualStyleBackColor = true;
            btnTask.Click += btnTask_Click;
            // 
            // btnMessages
            // 
            btnMessages.Dock = DockStyle.Left;
            btnMessages.FlatAppearance.BorderSize = 0;
            btnMessages.FlatStyle = FlatStyle.Flat;
            btnMessages.ImageAlign = ContentAlignment.BottomCenter;
            btnMessages.ImageKey = "MESSAGES.png";
            btnMessages.ImageList = ımageList1;
            btnMessages.Location = new Point(301, 0);
            btnMessages.Name = "btnMessages";
            btnMessages.Size = new Size(103, 51);
            btnMessages.TabIndex = 2;
            btnMessages.Text = "MESSAGES";
            btnMessages.TextAlign = ContentAlignment.TopCenter;
            btnMessages.UseVisualStyleBackColor = true;
            btnMessages.Click += btnMessages_Click;
            // 
            // btnAtten
            // 
            btnAtten.Dock = DockStyle.Left;
            btnAtten.FlatAppearance.BorderSize = 0;
            btnAtten.FlatStyle = FlatStyle.Flat;
            btnAtten.ImageAlign = ContentAlignment.BottomCenter;
            btnAtten.ImageKey = "ATTENDANCE.png";
            btnAtten.ImageList = ımageList1;
            btnAtten.Location = new Point(198, 0);
            btnAtten.Name = "btnAtten";
            btnAtten.Size = new Size(103, 51);
            btnAtten.TabIndex = 1;
            btnAtten.Text = "ATTENDANCE";
            btnAtten.TextAlign = ContentAlignment.TopCenter;
            btnAtten.UseVisualStyleBackColor = true;
            btnAtten.Click += btnAtten_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Dock = DockStyle.Left;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.ImageAlign = ContentAlignment.BottomCenter;
            btnEmployee.ImageKey = "EMPLOYEES.png";
            btnEmployee.ImageList = ımageList1;
            btnEmployee.Location = new Point(95, 0);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(103, 51);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "EMPLOYEE";
            btnEmployee.TextAlign = ContentAlignment.TopCenter;
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnDash
            // 
            btnDash.Dock = DockStyle.Left;
            btnDash.FlatAppearance.BorderSize = 0;
            btnDash.FlatStyle = FlatStyle.Flat;
            btnDash.ImageAlign = ContentAlignment.BottomCenter;
            btnDash.ImageKey = "DASHBOARD.png";
            btnDash.ImageList = ımageList1;
            btnDash.Location = new Point(0, 0);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(95, 51);
            btnDash.TabIndex = 0;
            btnDash.Text = "DASHBOARD";
            btnDash.TextAlign = ContentAlignment.TopCenter;
            btnDash.UseVisualStyleBackColor = true;
            btnDash.Click += btnDash_Click;
            // 
            // pnlScreen
            // 
            pnlScreen.Dock = DockStyle.Fill;
            pnlScreen.Location = new Point(0, 165);
            pnlScreen.Name = "pnlScreen";
            pnlScreen.Size = new Size(984, 522);
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
        private Label Colorlbl;
        private ImageList ımageList1;
    }
}