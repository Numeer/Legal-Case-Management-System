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
            caseDescription.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            caseDescription.Location = new Point(165, 108);
            caseDescription.Multiline = true;
            caseDescription.Name = "caseDescription";
            caseDescription.ScrollBars = ScrollBars.Vertical;
            caseDescription.Size = new Size(550, 125);
            caseDescription.TabIndex = 2;
            caseDescription.Text = "CaseDescription";
            caseDescription.TextChanged += caseDescription_TextChanged;
            // 
            // statusText
            // 
            statusText.Location = new Point(165, 252);
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
            label2.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 108);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 5;
            label2.Text = "Case Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 252);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 6;
            label3.Text = "Case Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 304);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 7;
            label4.Text = "Case Progress";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 352);
            label5.Name = "label5";
            label5.Size = new Size(125, 23);
            label5.TabIndex = 8;
            label5.Text = "Case Documents";
            // 
            // luploadDate
            // 
            luploadDate.AutoSize = true;
            luploadDate.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            luploadDate.Location = new Point(31, 399);
            luploadDate.Name = "luploadDate";
            luploadDate.Size = new Size(97, 23);
            luploadDate.TabIndex = 9;
            luploadDate.Text = "Upload Date";
            // 
            // progressText
            // 
            progressText.Location = new Point(165, 307);
            progressText.Name = "progressText";
            progressText.Size = new Size(100, 23);
            progressText.TabIndex = 10;
            // 
            // documentText
            // 
            documentText.Location = new Point(165, 355);
            documentText.Name = "documentText";
            documentText.Size = new Size(100, 23);
            documentText.TabIndex = 11;
            // 
            // uploadText
            // 
            uploadText.Location = new Point(162, 402);
            uploadText.Name = "uploadText";
            uploadText.Size = new Size(100, 23);
            uploadText.TabIndex = 12;
            // 
            // Update
            // 
            Update.BackColor = Color.GreenYellow;
            Update.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Update.Location = new Point(162, 443);
            Update.Name = "Update";
            Update.Size = new Size(75, 34);
            Update.TabIndex = 13;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 603);
            Controls.Add(Update);
            Controls.Add(uploadText);
            Controls.Add(documentText);
            Controls.Add(progressText);
            Controls.Add(luploadDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(statusText);
            Controls.Add(caseDescription);
            Controls.Add(caseName);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
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
        private Button Update;
    }
}