namespace LibraryWinforms
{
    partial class IssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            button1 = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(184, 185);
            button1.Name = "button1";
            button1.Size = new Size(221, 81);
            button1.TabIndex = 0;
            button1.Text = "Issue book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox3.Location = new Point(193, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(308, 33);
            textBox3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 6;
            label1.Text = "Book name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(12, 50);
            label5.Name = "label5";
            label5.Size = new Size(175, 25);
            label5.TabIndex = 10;
            label5.Text = "Client's First Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(553, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(526, 599);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(174, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(290, 23);
            comboBox1.TabIndex = 12;
            comboBox1.Click += IssueBook_Load;
            // 
            // IssueBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1180, 631);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IssueBook";
            Text = " Borrow Book";
            Load += IssueBook_Load_2;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void IssueBook_Load1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
    }
}