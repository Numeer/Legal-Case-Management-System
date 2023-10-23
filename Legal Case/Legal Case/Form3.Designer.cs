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
            documentDataGridView1 = new DataGridView();
            caseName = new Label();
            caseDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)documentDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // documentDataGridView1
            // 
            documentDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            documentDataGridView1.Location = new Point(130, 220);
            documentDataGridView1.Name = "documentDataGridView1";
            documentDataGridView1.RowTemplate.Height = 25;
            documentDataGridView1.Size = new Size(550, 130);
            documentDataGridView1.TabIndex = 0;
            // 
            // caseName
            // 
            caseName.AutoSize = true;
            caseName.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point);
            caseName.Location = new Point(130, 46);
            caseName.Name = "caseName";
            caseName.Size = new Size(145, 35);
            caseName.TabIndex = 1;
            caseName.Text = "CaseName";
            // 
            // caseDescription
            // 
            caseDescription.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            caseDescription.Location = new Point(130, 107);
            caseDescription.Multiline = true;
            caseDescription.Name = "caseDescription";
            caseDescription.ScrollBars = ScrollBars.Vertical;
            caseDescription.Size = new Size(550, 68);
            caseDescription.TabIndex = 2;
            caseDescription.Text = "CaseDescription";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 603);
            Controls.Add(caseDescription);
            Controls.Add(caseName);
            Controls.Add(documentDataGridView1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)documentDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView documentDataGridView1;
        private Label caseName;
        private TextBox caseDescription;
    }
}