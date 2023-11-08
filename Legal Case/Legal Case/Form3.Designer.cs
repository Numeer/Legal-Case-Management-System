namespace Legal_Case
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            caseName = new Label();
            caseDescription = new TextBox();
            statusText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            luploadDate = new Label();
            progressText = new TextBox();
            documentText = new TextBox();
            uploadText = new TextBox();
            Update = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // caseName
            // 
            caseName.AutoSize = true;
            caseName.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            caseName.Location = new Point(165, 61);
            caseName.Name = "caseName";
            caseName.Size = new Size(97, 24);
            caseName.TabIndex = 1;
            caseName.Text = "CaseName";
            // 
            // caseDescription
            // 
            caseDescription.BackColor = Color.WhiteSmoke;
            caseDescription.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            caseDescription.Location = new Point(71, 264);
            caseDescription.Multiline = true;
            caseDescription.Name = "caseDescription";
            caseDescription.PlaceholderText = "  Case Details";
            caseDescription.ScrollBars = ScrollBars.Both;
            caseDescription.Size = new Size(316, 202);
            caseDescription.TabIndex = 2;
            caseDescription.TextChanged += caseDescription_TextChanged_1;
            // 
            // statusText
            // 
            statusText.Location = new Point(46, 56);
            statusText.Name = "statusText";
            statusText.Size = new Size(100, 23);
            statusText.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 62);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 4;
            label1.Text = "Case Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(71, 221);
            label2.Name = "label2";
            label2.Size = new Size(162, 29);
            label2.TabIndex = 5;
            label2.Text = "Case Description";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(20, 30);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 6;
            label3.Text = "Case Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(20, 210);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 7;
            label4.Text = "Case Progress";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 64, 64);
            label5.Location = new Point(20, 84);
            label5.Name = "label5";
            label5.Size = new Size(125, 23);
            label5.TabIndex = 8;
            label5.Text = "Case Documents";
            // 
            // luploadDate
            // 
            luploadDate.AutoSize = true;
            luploadDate.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            luploadDate.ForeColor = Color.FromArgb(0, 64, 64);
            luploadDate.Location = new Point(20, 148);
            luploadDate.Name = "luploadDate";
            luploadDate.Size = new Size(97, 23);
            luploadDate.TabIndex = 9;
            luploadDate.Text = "Upload Date";
            // 
            // progressText
            // 
            progressText.Location = new Point(46, 236);
            progressText.Name = "progressText";
            progressText.Size = new Size(127, 23);
            progressText.TabIndex = 10;
            // 
            // documentText
            // 
            documentText.Location = new Point(46, 113);
            documentText.Name = "documentText";
            documentText.Size = new Size(127, 23);
            documentText.TabIndex = 11;
            // 
            // uploadText
            // 
            uploadText.Location = new Point(46, 174);
            uploadText.Name = "uploadText";
            uploadText.Size = new Size(111, 23);
            uploadText.TabIndex = 12;
            // 
            // Update
            // 
            Update.BackColor = Color.FromArgb(0, 64, 64);
            Update.BackgroundImageLayout = ImageLayout.Center;
            Update.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Update.ForeColor = Color.White;
            Update.Location = new Point(35, 286);
            Update.Name = "Update";
            Update.Size = new Size(180, 44);
            Update.TabIndex = 13;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(777, 0);
            button1.Name = "button1";
            button1.Size = new Size(24, 23);
            button1.TabIndex = 16;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(statusText);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(documentText);
            panel1.Controls.Add(luploadDate);
            panel1.Controls.Add(Update);
            panel1.Controls.Add(uploadText);
            panel1.Controls.Add(progressText);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(472, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 361);
            panel1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 64, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(42, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(382, 122);
            textBox1.TabIndex = 18;
            textBox1.Text = "Discover your user profile: Explore your account information, preferences, and more. Your personalized user details are just a click away.";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 603);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(caseDescription);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(caseName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label caseName;
        private TextBox caseDescription;
        private TextBox statusText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label luploadDate;
        private TextBox progressText;
        private TextBox documentText;
        private TextBox uploadText;
        private new Button Update;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Panel panel1;
        private TextBox textBox1;
    }
}