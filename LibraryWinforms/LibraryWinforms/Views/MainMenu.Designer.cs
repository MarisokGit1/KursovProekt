namespace LibraryWinforms
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download1;
            pictureBox1.Location = new Point(602, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 115);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Monospac821 BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(533, 183);
            label1.Name = "label1";
            label1.Size = new Size(298, 23);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Marin's Library ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monospac821 BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(547, 206);
            label2.Name = "label2";
            label2.Size = new Size(274, 22);
            label2.TabIndex = 2;
            label2.Text = "State your business here";
            // 
            // button1
            // 
            button1.Font = new Font("Monospac821 BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(563, 247);
            button1.Name = "button1";
            button1.Size = new Size(211, 62);
            button1.TabIndex = 3;
            button1.Text = "Register a book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Monospac821 BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(563, 315);
            button4.Name = "button4";
            button4.Size = new Size(211, 62);
            button4.TabIndex = 6;
            button4.Text = "Borrow Book";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Monospac821 BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(563, 383);
            button2.Name = "button2";
            button2.Size = new Size(211, 62);
            button2.TabIndex = 7;
            button2.Text = "Return book";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(1097, 483);
            button3.Name = "button3";
            button3.Size = new Size(211, 62);
            button3.TabIndex = 8;
            button3.Text = "Register";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Monospac821 BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(563, 451);
            button5.Name = "button5";
            button5.Size = new Size(211, 62);
            button5.TabIndex = 9;
            button5.Text = "Turn off";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // MainMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.RosyBrown;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1320, 557);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library";
            Load += MainMenu_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button4;
        private Button button2;
        private Button button3;
        private Button button5;
    }
}