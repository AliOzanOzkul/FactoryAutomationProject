namespace Otomasyon.UI
{
    partial class AttenceUC
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            btnPrint = new Button();
            pnlButton = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlButton.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(305, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(658, 340);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(658, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(0, 21);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(919, 34);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "PRINT";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // pnlButton
            // 
            pnlButton.Controls.Add(btnPrint);
            pnlButton.Location = new Point(44, 458);
            pnlButton.Name = "pnlButton";
            pnlButton.Size = new Size(919, 63);
            pnlButton.TabIndex = 3;
            // 
            // AttenceUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlButton);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "AttenceUC";
            Size = new Size(984, 529);
            Load += AttenceUC_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlButton.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button btnPrint;
        private Panel pnlButton;
    }
}
