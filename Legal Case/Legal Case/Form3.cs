using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legal_Case
{
    public partial class Form3 : Form
    {
        public Form3(DataTable caseDetails)
        {
            InitializeComponent();
            if (caseDetails.Rows.Count > 0)
            {
                caseName.Text = caseDetails.Rows[0]["CaseName"].ToString();
                caseDescription.Text = caseDetails.Rows[0]["Description"].ToString();

                documentDataGridView1.DataSource = caseDetails;
                documentDataGridView1.Columns["CaseName"].Visible = false;
                documentDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


    }
}
