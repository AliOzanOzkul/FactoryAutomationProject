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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessagesUC));
            dgInBox = new DataGridView();
            dgPersonel = new DataGridView();
            rbMsg = new RichTextBox();
            btnSend = new Button();
            ımageList1 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            txtTopic = new TextBox();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgInBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPersonel).BeginInit();
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
            dgInBox.CellClick += dgInBox_CellClick;
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
            btnSend.ImageAlign = ContentAlignment.MiddleLeft;
            btnSend.ImageIndex = 0;
            btnSend.ImageList = ımageList1;
            btnSend.Location = new Point(528, 457);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(416, 40);
            btnSend.TabIndex = 2;
            btnSend.Text = "SEND MESSAGE";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "Send Message.png");
            ımageList1.Images.SetKeyName(1, "Delete Message.png");
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
            // textBox1
            // 
            textBox1.Location = new Point(651, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtTopic
            // 
            txtTopic.Location = new Point(651, 247);
            txtTopic.Name = "txtTopic";
            txtTopic.Size = new Size(257, 23);
            txtTopic.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(538, 248);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 3;
            label4.Text = "Topic :";
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 1;
            button1.ImageList = ımageList1;
            button1.Location = new Point(39, 457);
            button1.Name = "button1";
            button1.Size = new Size(416, 40);
            button1.TabIndex = 2;
            button1.Text = "DELETE MESSAGE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MessagesUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtTopic);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnSend);
            Controls.Add(rbMsg);
            Controls.Add(dgPersonel);
            Controls.Add(dgInBox);
            Name = "MessagesUC";
            Size = new Size(984, 529);
            Load += MessagesUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgInBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPersonel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgInBox;
        private DataGridView dgPersonel;
        private RichTextBox rbMsg;
        private Button btnSend;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox txtTopic;
        private Label label4;
        private ImageList ımageList1;
        private Button button1;
    }
}
