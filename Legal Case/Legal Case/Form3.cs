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

namespace Legal_Case
{
    public partial class Form3 : Form
    {
        private int CaseId;
        private string connectionString;
        private string email;
        public Form3(String Email, DataTable caseDetails, int caseID, string connection)
        {
            CaseId = caseID;
            connectionString = connection;
            email = Email;
            InitializeComponent();
            if (caseDetails.Rows.Count > 0)
            {
                caseName.Text = caseDetails.Rows[0]["CaseName"].ToString();
                caseDescription.Text = caseDetails.Rows[0]["Description"].ToString();
                statusText.Text = caseDetails.Rows[0]["Status"].ToString();
                progressText.Text = caseDetails.Rows[0]["Progress"].ToString();
                documentText.Text = caseDetails.Rows[0]["DocumentName"].ToString();
                uploadText.Text = caseDetails.Rows[0]["UploadDate"].ToString();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void UpdateCaseDetails(int caseID, string newStatus, string newProgress, string newDescription, string newDocument, string newUpload)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand("UPDATE [Case] SET Status = @newStatus, Progress = @newProgress, Description = @newDescription WHERE CaseID = @caseID", connection, transaction))
                        {
                            command.Parameters.AddWithValue("@newStatus", newStatus);
                            command.Parameters.AddWithValue("@newProgress", newProgress);
                            command.Parameters.AddWithValue("@newDescription", newDescription);
                            command.Parameters.AddWithValue("@caseID", caseID);
                            command.ExecuteNonQuery();
                        }

                        using (SqlCommand command = new SqlCommand("UPDATE [Document] SET DocumentName = @newDocument, UploadDate = @newUpload WHERE CaseID = @caseID", connection, transaction))
                        {
                            command.Parameters.AddWithValue("@newDocument", newDocument);
                            command.Parameters.AddWithValue("@newUpload", newUpload);
                            command.Parameters.AddWithValue("@caseID", caseID);
                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                        transaction.Rollback();
                    }
                }
            }

        }
        private void Update_Click(object sender, EventArgs e)
        {
            int selectedCaseID = CaseId;
            string newStatus = statusText.Text;
            string newProgress = progressText.Text;
            string newDescription = caseDescription.Text;
            string newDocument = documentText.Text;
            string newUpload = uploadText.Text;
            UpdateCaseDetails(selectedCaseID, newStatus, newProgress, newDescription, newDocument, newUpload);
            MessageBox.Show("Case details updated successfully.", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Form2 form2 = new Form2(email, connectionString);
            form2.Show();
        }

        private void caseDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void caseDescription_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}