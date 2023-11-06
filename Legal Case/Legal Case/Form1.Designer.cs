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
            picture = new PictureBox();
            icon = new PictureBox();
            name = new Label();
            password = new Label();
            loginButton = new Button();
            nameText = new TextBox();
            passwordText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            SuspendLayout();
            // 
            // picture
            // 
            picture.Image = (Image)resources.GetObject("picture.Image");
            picture.Location = new Point(112, 12);
            picture.Name = "picture";
            picture.Size = new Size(236, 419);
            picture.SizeMode = PictureBoxSizeMode.AutoSize;
            picture.TabIndex = 0;
            picture.TabStop = false;
            // 
            // icon
            // 
            icon.BackColor = SystemColors.ButtonShadow;
            icon.BackgroundImageLayout = ImageLayout.None;
            icon.Image = (Image)resources.GetObject("icon.Image");
            icon.Location = new Point(477, 78);
            icon.Name = "icon";
            icon.Size = new Size(82, 70);
            icon.SizeMode = PictureBoxSizeMode.StretchImage;
            icon.TabIndex = 1;
            icon.TabStop = false;
            // 
            // name
            // 
            name.Location = new Point(376, 179);
            name.Name = "name";
            name.Size = new Size(80, 30);
            name.TabIndex = 2;
            name.Text = "Email";
            name.TextAlign = ContentAlignment.MiddleCenter;
            name.Click += name_Click;
            // 
            // password
            // 
            password.Location = new Point(376, 240);
            password.Name = "password";
            password.Size = new Size(80, 30);
            password.TabIndex = 3;
            password.Text = "Password";
            password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            loginButton.FlatStyle = FlatStyle.Popup;
            loginButton.Location = new Point(477, 305);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(90, 41);
            loginButton.TabIndex = 6;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
         
            // 
            // nameText
            // 
            nameText.AcceptsTab = true;
            nameText.BackColor = Color.FromArgb(64, 64, 64);
            nameText.BorderStyle = BorderStyle.FixedSingle;
            nameText.ForeColor = SystemColors.Info;
            nameText.Location = new Point(462, 179);
            nameText.Name = "nameText";
            nameText.Size = new Size(184, 23);
            nameText.TabIndex = 10;
            nameText.TextChanged += nameText_TextChanged;
            // 
            // passwordText
            // 
            passwordText.AcceptsTab = true;
            passwordText.BackColor = Color.FromArgb(64, 64, 64);
            passwordText.BorderStyle = BorderStyle.FixedSingle;
            passwordText.ForeColor = SystemColors.Info;
            passwordText.Location = new Point(462, 247);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(184, 23);
            passwordText.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordText);
            Controls.Add(nameText);
            Controls.Add(loginButton);
            Controls.Add(password);
            Controls.Add(name);
            Controls.Add(icon);
            Controls.Add(picture);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picture;
        private PictureBox icon;
        private Label name;
        private Label password;
        private Button loginButton;
        private TextBox nameText;
        private TextBox passwordText;
    }
}