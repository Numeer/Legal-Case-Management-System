using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Legal_Case
{
    public partial class Form2 : Form
    {
        private string email;
        public Form2(string userEmail)
        {
            email = userEmail;
            InitializeComponent();
            PopulateCaseData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["CaseName"].Index)
            {
                int selectedCaseID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CaseID"].Value);

                DataTable caseDetails = RetrieveCaseDetails(selectedCaseID);

                Form3 form3 = new Form3(caseDetails);
                form3.Show();
            }

        }
        private DataTable RetrieveCaseDetails(int caseID)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\LCMS\\Legal Case\\Legal Case\\Database1.mdf\";Integrated Security=True";
            string query = @"SELECT C.CaseName, C.Description, D.DocumentName, D.UploadDate
                     FROM [Case] AS C
                     LEFT JOIN [Document] AS D ON C.CaseID = D.CaseID
                     WHERE C.CaseID = @CaseID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CaseID", caseID);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        private DataTable RetrieveCaseData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\LCMS\\Legal Case\\Legal Case\\Database1.mdf\";Integrated Security=True";
            string query = @"SELECT C.CaseID, C.CaseName, C.Status, C.Progress
                             FROM [Case] AS C
                             INNER JOIN [User] AS U ON C.AssignedAttorneyID = U.UserID
                             WHERE U.Email = @Email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        private void PopulateCaseData()
        {
            DataTable caseData = RetrieveCaseData();

            dataGridView1.DataSource = caseData;
        }

    }
}
