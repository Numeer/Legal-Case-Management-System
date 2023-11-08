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
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            closeBtn = new Button();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DarkSlateGray;
            loginButton.FlatStyle = FlatStyle.Popup;
            loginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = SystemColors.ControlLightLight;
            loginButton.Location = new Point(91, 195);
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
            passwordText.BackColor = Color.DarkSeaGreen;
            passwordText.BorderStyle = BorderStyle.None;
            passwordText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            passwordText.ForeColor = Color.FromArgb(64, 64, 64);
            passwordText.Location = new Point(72, 141);
            passwordText.MinimumSize = new Size(182, 39);
            passwordText.Name = "passwordText";
            passwordText.PlaceholderText = "  Password";
            passwordText.Size = new Size(182, 39);
            passwordText.TabIndex = 10;
            passwordText.TextChanged += passwordText_TextChanged;
            // 
            // nameText
            // 
            nameText.AcceptsTab = true;
            nameText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameText.BackColor = Color.DarkSeaGreen;
            nameText.BorderStyle = BorderStyle.None;
            nameText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nameText.ForeColor = Color.FromArgb(64, 64, 64);
            nameText.Location = new Point(72, 85);
            nameText.MaximumSize = new Size(200, 200);
            nameText.MinimumSize = new Size(182, 39);
            nameText.Name = "nameText";
            nameText.PlaceholderText = "  Email ID";
            nameText.Size = new Size(182, 39);
            nameText.TabIndex = 9;
            nameText.TextChanged += nameText_TextChanged;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(nameText);
            panel1.Controls.Add(passwordText);
            panel1.Location = new Point(35, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 252);
            panel1.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(24, 141);
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
            pictureBox2.Location = new Point(24, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Linen;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(126, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(390, 70);
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
            pictureBox4.Location = new Point(164, 70);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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