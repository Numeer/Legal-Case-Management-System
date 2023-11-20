namespace Legal_Case
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            FirstName = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            AddUser = new Button();
            Role = new ComboBox();
            Password = new TextBox();
            Country = new TextBox();
            Email = new TextBox();
            PhNo = new TextBox();
            LastName = new TextBox();
            label1 = new Label();
            Close = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // FirstName
            // 
            FirstName.Location = new Point(21, 71);
            FirstName.Multiline = true;
            FirstName.Name = "FirstName";
            FirstName.PlaceholderText = "  first name";
            FirstName.Size = new Size(176, 32);
            FirstName.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(116, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 308);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(283, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(AddUser);
            panel2.Controls.Add(Role);
            panel2.Controls.Add(Password);
            panel2.Controls.Add(Country);
            panel2.Controls.Add(Email);
            panel2.Controls.Add(PhNo);
            panel2.Controls.Add(LastName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(FirstName);
            panel2.Location = new Point(154, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 426);
            panel2.TabIndex = 2;
            // 
            // AddUser
            // 
            AddUser.BackColor = Color.SandyBrown;
            AddUser.BackgroundImageLayout = ImageLayout.None;
            AddUser.FlatStyle = FlatStyle.Popup;
            AddUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddUser.ForeColor = Color.FromArgb(64, 64, 64);
            AddUser.Location = new Point(60, 342);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(137, 36);
            AddUser.TabIndex = 8;
            AddUser.Text = "Add";
            AddUser.UseVisualStyleBackColor = false;
            AddUser.Click += AddUser_Click;
            // 
            // Role
            // 
            Role.ForeColor = SystemColors.WindowFrame;
            Role.FormattingEnabled = true;
            Role.Location = new Point(21, 297);
            Role.Name = "Role";
            Role.Size = new Size(160, 23);
            Role.TabIndex = 7;
            Role.Text = "  Role";
            // 
            // Password
            // 
            Password.Location = new Point(21, 257);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.PlaceholderText = "  Password";
            Password.Size = new Size(151, 34);
            Password.TabIndex = 6;
            // 
            // Country
            // 
            Country.Location = new Point(21, 220);
            Country.Multiline = true;
            Country.Name = "Country";
            Country.PlaceholderText = "  Country";
            Country.Size = new Size(162, 31);
            Country.TabIndex = 5;
            // 
            // Email
            // 
            Email.Location = new Point(21, 187);
            Email.Multiline = true;
            Email.Name = "Email";
            Email.PlaceholderText = "  Email";
            Email.Size = new Size(176, 27);
            Email.TabIndex = 4;
            // 
            // PhNo
            // 
            PhNo.Location = new Point(21, 144);
            PhNo.Multiline = true;
            PhNo.Name = "PhNo";
            PhNo.PlaceholderText = "  Contact No";
            PhNo.Size = new Size(151, 37);
            PhNo.TabIndex = 3;
            // 
            // LastName
            // 
            LastName.Location = new Point(21, 109);
            LastName.Multiline = true;
            LastName.Name = "LastName";
            LastName.PlaceholderText = "  last name";
            LastName.Size = new Size(176, 29);
            LastName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(60, 19);
            label1.Name = "label1";
            label1.Size = new Size(121, 36);
            label1.TabIndex = 1;
            label1.Text = "Add User";
            label1.Click += label1_Click;
            // 
            // Close
            // 
            Close.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Close.Location = new Point(776, -1);
            Close.Name = "Close";
            Close.Size = new Size(26, 23);
            Close.TabIndex = 3;
            Close.Text = "x";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Close);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox FirstName;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox PhNo;
        private TextBox LastName;
        private TextBox Email;
        private TextBox Password;
        private TextBox Country;
        private Button AddUser;
        private ComboBox Role;
        private Button Close;
        private PictureBox pictureBox1;
    }
}