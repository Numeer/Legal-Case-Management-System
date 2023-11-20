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
            caseDescription = new TextBox();
            statusText = new TextBox();
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
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            caseName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // caseDescription
            // 
            caseDescription.BackColor = Color.WhiteSmoke;
            caseDescription.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            caseDescription.Location = new Point(20, 297);
            caseDescription.Multiline = true;
            caseDescription.Name = "caseDescription";
            caseDescription.PlaceholderText = "  Case Details";
            caseDescription.ScrollBars = ScrollBars.Both;
            caseDescription.Size = new Size(207, 163);
            caseDescription.TabIndex = 2;
            // 
            // statusText
            // 
            statusText.Location = new Point(20, 84);
            statusText.Multiline = true;
            statusText.Name = "statusText";
            statusText.Size = new Size(157, 26);
            statusText.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(20, 271);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 5;
            label2.Text = "Case Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(20, 58);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 6;
            label3.Text = "Case Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(20, 219);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 7;
            label4.Text = "Case Progress";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(20, 113);
            label5.Name = "label5";
            label5.Size = new Size(125, 23);
            label5.TabIndex = 8;
            label5.Text = "Case Documents";
            // 
            // luploadDate
            // 
            luploadDate.AutoSize = true;
            luploadDate.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            luploadDate.ForeColor = Color.FromArgb(64, 64, 64);
            luploadDate.Location = new Point(20, 165);
            luploadDate.Name = "luploadDate";
            luploadDate.Size = new Size(97, 23);
            luploadDate.TabIndex = 9;
            luploadDate.Text = "Upload Date";
            // 
            // progressText
            // 
            progressText.Location = new Point(20, 245);
            progressText.Multiline = true;
            progressText.Name = "progressText";
            progressText.Size = new Size(157, 23);
            progressText.TabIndex = 10;
            // 
            // documentText
            // 
            documentText.Location = new Point(20, 139);
            documentText.Multiline = true;
            documentText.Name = "documentText";
            documentText.Size = new Size(195, 26);
            documentText.TabIndex = 11;
            // 
            // uploadText
            // 
            uploadText.Location = new Point(20, 191);
            uploadText.Multiline = true;
            uploadText.Name = "uploadText";
            uploadText.Size = new Size(195, 25);
            uploadText.TabIndex = 12;
            // 
            // Update
            // 
            Update.BackColor = Color.FromArgb(64, 64, 64);
            Update.BackgroundImageLayout = ImageLayout.Center;
            Update.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Update.ForeColor = Color.White;
            Update.Location = new Point(48, 466);
            Update.Name = "Update";
            Update.Size = new Size(152, 44);
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
            pictureBox1.Size = new Size(802, 203);
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
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(caseName);
            panel1.Controls.Add(caseDescription);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(statusText);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(documentText);
            panel1.Controls.Add(luploadDate);
            panel1.Controls.Add(Update);
            panel1.Controls.Add(uploadText);
            panel1.Controls.Add(progressText);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(472, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 525);
            panel1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gray;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(88, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(341, 357);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.Font = new Font("Rockwell Extra Bold", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Menu;
            textBox1.Location = new Point(88, 37);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 98);
            textBox1.TabIndex = 19;
            textBox1.Text = "                               Update     Case";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // caseName
            // 
            caseName.Location = new Point(20, 32);
            caseName.Name = "caseName";
            caseName.Size = new Size(160, 23);
            caseName.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(20, 8);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 15;
            label1.Text = "Case Title";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 603);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox caseDescription;
        private TextBox statusText;
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
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private TextBox caseName;
        private Label label1;
    }
}