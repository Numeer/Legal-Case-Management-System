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
            label2 = new Label();
            CaseAttroney = new ComboBox();
            CaseDescription = new TextBox();
            label3 = new Label();
            CreateBtn = new Button();
            CaseTitle = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
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
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(CaseTitle);
            panel2.Controls.Add(CreateBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(CaseDescription);
            panel2.Controls.Add(CaseAttroney);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(251, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 283);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(17, 107);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 3;
            label2.Text = "CASE DESCRIPTION";
            // 
            // CaseAttroney
            // 
            CaseAttroney.BackColor = Color.FromArgb(224, 224, 224);
            CaseAttroney.ForeColor = Color.FromArgb(64, 64, 64);
            CaseAttroney.FormattingEnabled = true;
            CaseAttroney.Location = new Point(31, 81);
            CaseAttroney.MaxDropDownItems = 10;
            CaseAttroney.Name = "CaseAttroney";
            CaseAttroney.Size = new Size(196, 23);
            CaseAttroney.TabIndex = 5;
            // 
            // CaseDescription
            // 
            CaseDescription.BackColor = Color.FromArgb(224, 224, 224);
            CaseDescription.BorderStyle = BorderStyle.FixedSingle;
            CaseDescription.ForeColor = Color.FromArgb(64, 64, 64);
            CaseDescription.Location = new Point(31, 125);
            CaseDescription.Multiline = true;
            CaseDescription.Name = "CaseDescription";
            CaseDescription.Size = new Size(222, 110);
            CaseDescription.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(17, 63);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 6;
            label3.Text = "CASE ATTORNEY";
            label3.TextAlign = ContentAlignment.MiddleCenter;
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
            // CaseTitle
            // 
            CaseTitle.AcceptsTab = true;
            CaseTitle.BackColor = Color.FromArgb(224, 224, 224);
            CaseTitle.BorderStyle = BorderStyle.FixedSingle;
            CaseTitle.ForeColor = Color.FromArgb(64, 64, 64);
            CaseTitle.Location = new Point(31, 37);
            CaseTitle.Name = "CaseTitle";
            CaseTitle.Size = new Size(161, 23);
            CaseTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "CASE TITLE";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(CloseBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
    }
}