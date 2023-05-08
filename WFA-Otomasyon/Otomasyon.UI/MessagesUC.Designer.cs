namespace Otomasyon.UI
{
    partial class MessagesUC
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
            dgInBox = new DataGridView();
            dgPersonel = new DataGridView();
            dgTask = new DataGridView();
            rbMsg = new RichTextBox();
            btnSend = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgInBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPersonel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgTask).BeginInit();
            SuspendLayout();
            // 
            // dgInBox
            // 
            dgInBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgInBox.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgInBox.BackgroundColor = SystemColors.Control;
            dgInBox.BorderStyle = BorderStyle.None;
            dgInBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgInBox.Location = new Point(39, 39);
            dgInBox.Name = "dgInBox";
            dgInBox.RowTemplate.Height = 25;
            dgInBox.Size = new Size(416, 204);
            dgInBox.TabIndex = 0;
            dgInBox.CellDoubleClick += dgInBox_CellDoubleClick;
            // 
            // dgPersonel
            // 
            dgPersonel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPersonel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgPersonel.BackgroundColor = SystemColors.Control;
            dgPersonel.BorderStyle = BorderStyle.None;
            dgPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPersonel.Location = new Point(528, 39);
            dgPersonel.Name = "dgPersonel";
            dgPersonel.RowTemplate.Height = 25;
            dgPersonel.Size = new Size(416, 204);
            dgPersonel.TabIndex = 0;
            dgPersonel.CellClick += dgPersonel_CellClick;
            // 
            // dgTask
            // 
            dgTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTask.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgTask.BackgroundColor = SystemColors.Control;
            dgTask.BorderStyle = BorderStyle.None;
            dgTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTask.Location = new Point(39, 276);
            dgTask.Name = "dgTask";
            dgTask.RowTemplate.Height = 25;
            dgTask.Size = new Size(416, 204);
            dgTask.TabIndex = 0;
            // 
            // rbMsg
            // 
            rbMsg.Location = new Point(528, 276);
            rbMsg.Name = "rbMsg";
            rbMsg.Size = new Size(416, 180);
            rbMsg.TabIndex = 1;
            rbMsg.Text = "";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(528, 457);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(416, 23);
            btnSend.TabIndex = 2;
            btnSend.Text = "SEND MESSAGE";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 10);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 3;
            label1.Text = "In-Box:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(528, 10);
            label2.Name = "label2";
            label2.Size = new Size(117, 17);
            label2.TabIndex = 3;
            label2.Text = "Search Personnel:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 256);
            label3.Name = "label3";
            label3.Size = new Size(107, 17);
            label3.TabIndex = 3;
            label3.Text = "Incoming Tasks:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(651, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // MessagesUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(rbMsg);
            Controls.Add(dgPersonel);
            Controls.Add(dgTask);
            Controls.Add(dgInBox);
            Name = "MessagesUC";
            Size = new Size(984, 529);
            Load += MessagesUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgInBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPersonel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgInBox;
        private DataGridView dgPersonel;
        private DataGridView dgTask;
        private RichTextBox rbMsg;
        private Button btnSend;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
    }
}
