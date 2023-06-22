namespace LibraryWinforms
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(520, 43);
            button1.Name = "button1";
            button1.Size = new Size(185, 72);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(536, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 124);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(63, 62);
            label1.Name = "label1";
            label1.Size = new Size(69, 27);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(63, 184);
            label2.Name = "label2";
            label2.Size = new Size(0, 27);
            label2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(361, 176);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(45, 35);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(194, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 33);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 176);
            label3.Name = "label3";
            label3.Size = new Size(271, 27);
            label3.TabIndex = 6;
            label3.Text = "Id of the book borrow";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(536, 303);
            label4.Name = "label4";
            label4.Size = new Size(143, 27);
            label4.TabIndex = 7;
            label4.Text = "Magik Book";
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(1084, 661);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "ReturnBook";
            Text = "ReturnBook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
    }
}