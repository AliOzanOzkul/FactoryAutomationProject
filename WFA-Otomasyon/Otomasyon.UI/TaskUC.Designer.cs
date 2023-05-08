namespace Otomasyon.UI
{
    partial class TaskUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgEmployee = new DataGridView();
            dgManager = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtTaskName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpTarih = new DateTimePicker();
            rbMsg = new RichTextBox();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox2 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgManager).BeginInit();
            SuspendLayout();
            // 
            // dgEmployee
            // 
            dgEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgEmployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgEmployee.BackgroundColor = SystemColors.Control;
            dgEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmployee.Location = new Point(48, 65);
            dgEmployee.Name = "dgEmployee";
            dgEmployee.RowTemplate.Height = 25;
            dgEmployee.Size = new Size(484, 237);
            dgEmployee.TabIndex = 0;
            dgEmployee.CellClick += dgEmployee_CellClick;
            // 
            // dgManager
            // 
            dgManager.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgManager.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgManager.BackgroundColor = SystemColors.Control;
            dgManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgManager.Location = new Point(48, 352);
            dgManager.Name = "dgManager";
            dgManager.RowTemplate.Height = 25;
            dgManager.Size = new Size(897, 164);
            dgManager.TabIndex = 0;
            dgManager.CellClick += dgManager_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 34);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 1;
            label1.Text = "Search :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(48, 321);
            label2.Name = "label2";
            label2.Size = new Size(110, 17);
            label2.TabIndex = 1;
            label2.Text = "Manager In-Box:";
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(696, 93);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(249, 23);
            txtTaskName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(591, 95);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 1;
            label3.Text = "Task Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(591, 144);
            label4.Name = "label4";
            label4.Size = new Size(100, 17);
            label4.TabIndex = 1;
            label4.Text = "Task Message :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(591, 266);
            label5.Name = "label5";
            label5.Size = new Size(102, 17);
            label5.TabIndex = 1;
            label5.Text = "Task Deadline :";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(699, 266);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(246, 23);
            dtpTarih.TabIndex = 3;
            // 
            // rbMsg
            // 
            rbMsg.Location = new Point(699, 132);
            rbMsg.Name = "rbMsg";
            rbMsg.Size = new Size(246, 128);
            rbMsg.TabIndex = 4;
            rbMsg.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(591, 34);
            label6.Name = "label6";
            label6.Size = new Size(90, 17);
            label6.TabIndex = 1;
            label6.Text = "Search With :";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(713, 34);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Employee ID";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(851, 34);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(112, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Employee Name";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(422, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(599, 305);
            button1.Name = "button1";
            button1.Size = new Size(346, 33);
            button1.TabIndex = 6;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TaskUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(rbMsg);
            Controls.Add(dtpTarih);
            Controls.Add(textBox2);
            Controls.Add(txtTaskName);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgManager);
            Controls.Add(dgEmployee);
            Name = "TaskUC";
            Size = new Size(984, 529);
            Load += TaskUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgManager).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgEmployee;
        private DataGridView dgManager;
        private Label label1;
        private Label label2;
        private TextBox txtTaskName;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpTarih;
        private RichTextBox rbMsg;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox2;
        private Button button1;
    }
}
