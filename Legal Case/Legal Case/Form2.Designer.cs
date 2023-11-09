namespace Legal_Case
{
    partial class Form2
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            AddCaseBtn = new Button();
            Logout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(305, 66);
            label1.Name = "label1";
            label1.Size = new Size(549, 28);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Legal Case Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new Font("Microsoft Tai Le", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle9.SelectionBackColor = Color.DarkGray;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.Gray;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.ColumnHeadersHeight = 27;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(345, 245);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.Transparent;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(457, 178);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 520);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = Color.WhiteSmoke;
            textBox1.Location = new Point(356, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(410, 18);
            textBox1.TabIndex = 3;
            textBox1.Text = "CaseSync: Where Legal Matters Unfold";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(64, 64, 64);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.WhiteSmoke;
            textBox2.Location = new Point(427, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 16);
            textBox2.TabIndex = 4;
            textBox2.Text = "A way to hope and light; representing demo cases.";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(849, 0);
            button1.Name = "button1";
            button1.Size = new Size(27, 23);
            button1.TabIndex = 5;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(64, 64, 64);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.ForeColor = SystemColors.Info;
            textBox3.Location = new Point(367, 165);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(399, 74);
            textBox3.TabIndex = 6;
            textBox3.Text = "Welcome to our Legal Case Management System – your comprehensive solution for efficiently managing legal cases, simplifying document workflows, and streamlining communication.";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // AddCaseBtn
            // 
            AddCaseBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddCaseBtn.ForeColor = Color.FromArgb(64, 64, 64);
            AddCaseBtn.Location = new Point(506, 439);
            AddCaseBtn.Name = "AddCaseBtn";
            AddCaseBtn.Size = new Size(125, 37);
            AddCaseBtn.TabIndex = 7;
            AddCaseBtn.Text = "Add new Case";
            AddCaseBtn.UseVisualStyleBackColor = true;
            AddCaseBtn.Click += AddCaseBtn_Click;
            // 
            // Logout
            // 
            Logout.BackColor = Color.FromArgb(224, 224, 224);
            Logout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Logout.ForeColor = Color.FromArgb(64, 64, 64);
            Logout.Location = new Point(521, 496);
            Logout.Name = "Logout";
            Logout.Size = new Size(91, 28);
            Logout.TabIndex = 8;
            Logout.Text = "LOGOUT";
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(876, 631);
            Controls.Add(Logout);
            Controls.Add(AddCaseBtn);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private Button AddCaseBtn;
        private Button Logout;
    }
}