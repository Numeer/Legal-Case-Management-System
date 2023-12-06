namespace Legal_Case
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            loginButton = new Button();
            passwordText = new TextBox();
            nameText = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            closeBtn = new Button();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.White;
            loginButton.FlatStyle = FlatStyle.Popup;
            loginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = SystemColors.ControlDarkDark;
            loginButton.Location = new Point(91, 225);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 41);
            loginButton.TabIndex = 6;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordText
            // 
            passwordText.AcceptsTab = true;
            passwordText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordText.BackColor = SystemColors.Control;
            passwordText.BorderStyle = BorderStyle.FixedSingle;
            passwordText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            passwordText.ForeColor = Color.FromArgb(64, 64, 64);
            passwordText.Location = new Point(72, 168);
            passwordText.MinimumSize = new Size(182, 39);
            passwordText.Name = "passwordText";
            passwordText.PlaceholderText = "  Password";
            passwordText.Size = new Size(182, 39);
            passwordText.TabIndex = 10;
            // 
            // nameText
            // 
            nameText.AcceptsTab = true;
            nameText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameText.BackColor = SystemColors.Control;
            nameText.BorderStyle = BorderStyle.FixedSingle;
            nameText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nameText.ForeColor = Color.FromArgb(64, 64, 64);
            nameText.Location = new Point(72, 110);
            nameText.MaximumSize = new Size(200, 200);
            nameText.MinimumSize = new Size(182, 39);
            nameText.Name = "nameText";
            nameText.PlaceholderText = "  Email ID";
            nameText.Size = new Size(182, 39);
            nameText.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(nameText);
            panel1.Controls.Add(passwordText);
            panel1.Location = new Point(28, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 281);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Linen;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(24, 168);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(0, 64, 64);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(348, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(333, 324);
            panel2.TabIndex = 12;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = SystemColors.ButtonHighlight;
            closeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeBtn.Location = new Point(774, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(26, 25);
            closeBtn.TabIndex = 13;
            closeBtn.Text = "x";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(122, 70);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(231, 324);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(closeBtn);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button loginButton;
        private TextBox passwordText;
        private TextBox nameText;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button closeBtn;
        private PictureBox pictureBox4;
    }
}