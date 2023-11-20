namespace Legal_Case
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            CloseBtn = new Button();
            panel2 = new Panel();
            label1 = new Label();
            CaseTitle = new TextBox();
            CreateBtn = new Button();
            label3 = new Label();
            CaseDescription = new TextBox();
            CaseAttroney = new ComboBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.White;
            CloseBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CloseBtn.Location = new Point(776, 0);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(24, 22);
            CloseBtn.TabIndex = 1;
            CloseBtn.Text = "x";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(CaseTitle);
            panel2.Controls.Add(CreateBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(CaseDescription);
            panel2.Controls.Add(CaseAttroney);
            panel2.Controls.Add(label2);
            panel2.ForeColor = Color.FromArgb(0, 64, 64);
            panel2.Location = new Point(457, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 283);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "CASE TITLE";
            // 
            // CaseTitle
            // 
            CaseTitle.AcceptsTab = true;
            CaseTitle.BackColor = Color.Azure;
            CaseTitle.BorderStyle = BorderStyle.FixedSingle;
            CaseTitle.ForeColor = Color.FromArgb(0, 64, 64);
            CaseTitle.Location = new Point(31, 37);
            CaseTitle.Name = "CaseTitle";
            CaseTitle.Size = new Size(161, 23);
            CaseTitle.TabIndex = 1;
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.DarkSlateGray;
            CreateBtn.BackgroundImageLayout = ImageLayout.None;
            CreateBtn.FlatStyle = FlatStyle.Flat;
            CreateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateBtn.ForeColor = Color.FromArgb(224, 224, 224);
            CreateBtn.Location = new Point(96, 241);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(93, 34);
            CreateBtn.TabIndex = 7;
            CreateBtn.Text = "Done";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(17, 63);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 6;
            label3.Text = "CASE ATTORNEY";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CaseDescription
            // 
            CaseDescription.BackColor = Color.Azure;
            CaseDescription.BorderStyle = BorderStyle.FixedSingle;
            CaseDescription.ForeColor = Color.FromArgb(64, 64, 64);
            CaseDescription.Location = new Point(31, 125);
            CaseDescription.Multiline = true;
            CaseDescription.Name = "CaseDescription";
            CaseDescription.Size = new Size(222, 110);
            CaseDescription.TabIndex = 4;
            // 
            // CaseAttroney
            // 
            CaseAttroney.BackColor = Color.Azure;
            CaseAttroney.DropDownHeight = 1000;
            CaseAttroney.ForeColor = Color.FromArgb(0, 64, 64);
            CaseAttroney.FormattingEnabled = true;
            CaseAttroney.IntegralHeight = false;
            CaseAttroney.ItemHeight = 15;
            CaseAttroney.Location = new Point(31, 81);
            CaseAttroney.MaxDropDownItems = 20;
            CaseAttroney.Name = "CaseAttroney";
            CaseAttroney.Size = new Size(196, 23);
            CaseAttroney.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(17, 107);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 3;
            label2.Text = "CASE DESCRIPTION";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(409, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkSeaGreen;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Showcard Gothic", 25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 64, 64);
            textBox1.Location = new Point(291, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 49);
            textBox1.TabIndex = 11;
            textBox1.Text = "Add Case";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(CloseBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CloseBtn;
        private Panel panel2;
        private Label label1;
        private TextBox CaseTitle;
        private Button CreateBtn;
        private Label label3;
        private TextBox CaseDescription;
        private ComboBox CaseAttroney;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}