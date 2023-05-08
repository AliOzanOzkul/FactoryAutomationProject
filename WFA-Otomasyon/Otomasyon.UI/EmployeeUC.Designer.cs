namespace Otomasyon.UI
{
    partial class EmployeeUC
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
            textBox1 = new TextBox();
            txtId = new TextBox();
            txtPhoneNo = new TextBox();
            txtSalary = new TextBox();
            txtName = new TextBox();
            txtIdentityNo = new TextBox();
            txtLastName = new TextBox();
            txtDOB = new TextBox();
            cbDepartman = new ComboBox();
            cbGender = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            cbInsurance = new ComboBox();
            textBox7 = new TextBox();
            pictureBox1 = new PictureBox();
            btnPic = new Button();
            dataGridView1 = new DataGridView();
            btnPrint = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnExpenses = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(492, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(54, 81);
            txtId.Name = "txtId";
            txtId.Size = new Size(121, 23);
            txtId.TabIndex = 1;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(54, 144);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(121, 23);
            txtPhoneNo.TabIndex = 1;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(54, 201);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(121, 23);
            txtSalary.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(237, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 1;
            // 
            // txtIdentityNo
            // 
            txtIdentityNo.Location = new Point(237, 144);
            txtIdentityNo.Name = "txtIdentityNo";
            txtIdentityNo.Size = new Size(121, 23);
            txtIdentityNo.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(425, 81);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(121, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(425, 144);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(121, 23);
            txtDOB.TabIndex = 1;
            // 
            // cbDepartman
            // 
            cbDepartman.FormattingEnabled = true;
            cbDepartman.Location = new Point(237, 201);
            cbDepartman.Name = "cbDepartman";
            cbDepartman.Size = new Size(121, 23);
            cbDepartman.TabIndex = 2;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(425, 201);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 23);
            cbGender.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(54, 241);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 28);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(237, 241);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 28);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(425, 241);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 28);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cbInsurance
            // 
            cbInsurance.FormattingEnabled = true;
            cbInsurance.Location = new Point(827, 81);
            cbInsurance.Name = "cbInsurance";
            cbInsurance.Size = new Size(121, 23);
            cbInsurance.TabIndex = 2;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(827, 144);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(121, 23);
            textBox7.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(630, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 196);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnPic
            // 
            btnPic.Location = new Point(630, 241);
            btnPic.Name = "btnPic";
            btnPic.Size = new Size(144, 28);
            btnPic.TabIndex = 3;
            btnPic.Text = "Add Picture";
            btnPic.UseVisualStyleBackColor = true;
            btnPic.Click += btnPic_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(932, 182);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(30, 484);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(932, 23);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 61);
            label1.Name = "label1";
            label1.Size = new Size(86, 17);
            label1.TabIndex = 7;
            label1.Text = "Employee ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(237, 61);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(425, 61);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 7;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(54, 124);
            label4.Name = "label4";
            label4.Size = new Size(101, 17);
            label4.TabIndex = 7;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(237, 124);
            label5.Name = "label5";
            label5.Size = new Size(110, 17);
            label5.TabIndex = 7;
            label5.Text = "Identity Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(425, 124);
            label6.Name = "label6";
            label6.Size = new Size(36, 17);
            label6.TabIndex = 7;
            label6.Text = "DOB";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(54, 181);
            label7.Name = "label7";
            label7.Size = new Size(46, 17);
            label7.TabIndex = 7;
            label7.Text = "Salary";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(237, 181);
            label8.Name = "label8";
            label8.Size = new Size(77, 17);
            label8.TabIndex = 7;
            label8.Text = "Departman";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(425, 181);
            label9.Name = "label9";
            label9.Size = new Size(52, 17);
            label9.TabIndex = 7;
            label9.Text = "Gender";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(827, 61);
            label10.Name = "label10";
            label10.Size = new Size(133, 17);
            label10.TabIndex = 7;
            label10.Text = "Insurance Company ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(829, 124);
            label11.Name = "label11";
            label11.Size = new Size(121, 17);
            label11.TabIndex = 7;
            label11.Text = "Insurance Expense";
            // 
            // btnExpenses
            // 
            btnExpenses.Location = new Point(827, 241);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(121, 28);
            btnExpenses.TabIndex = 3;
            btnExpenses.Text = "Add Expenses";
            btnExpenses.UseVisualStyleBackColor = true;
            btnExpenses.Click += btnExpenses_Click;
            // 
            // EmployeeUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnPrint);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(btnExpenses);
            Controls.Add(btnPic);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cbInsurance);
            Controls.Add(cbGender);
            Controls.Add(cbDepartman);
            Controls.Add(txtSalary);
            Controls.Add(textBox7);
            Controls.Add(txtDOB);
            Controls.Add(txtIdentityNo);
            Controls.Add(txtPhoneNo);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(textBox1);
            Name = "EmployeeUC";
            Size = new Size(984, 529);
            Load += EmployeeUC_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox txtId;
        private TextBox txtPhoneNo;
        private TextBox txtSalary;
        private TextBox txtName;
        private TextBox txtIdentityNo;
        private TextBox txtLastName;
        private TextBox txtDOB;
        private ComboBox cbDepartman;
        private ComboBox cbGender;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cbInsurance;
        private TextBox textBox7;
        private PictureBox pictureBox1;
        private Button btnPic;
        private DataGridView dataGridView1;
        private Button btnPrint;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnExpenses;
    }
}
