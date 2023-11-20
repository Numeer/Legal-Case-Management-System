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
        private bool admin;
        public Form3(String Email, DataTable caseDetails, int caseID, string connection, bool admin)
        {
            CaseId = caseID;
            connectionString = connection;
            email = Email;
            this.admin = admin;
            InitializeComponent();
            Status.Items.Add("Open");
            Status.Items.Add("In Progress");
            Status.Items.Add("Closed");
            if (caseDetails.Rows.Count > 0)
            {
                caseTitle.Text = caseDetails.Rows[0]["CaseName"].ToString();
                caseDescription.Text = caseDetails.Rows[0]["Description"].ToString();
                Status.Text = caseDetails.Rows[0]["Status"].ToString();
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
                        bool caseExistsInCaseTable = false;
                        bool caseExistsInDocumentTable = false;

                        using (SqlCommand command = new SqlCommand("SELECT CASEID FROM [Case] WHERE CaseID = @caseID", connection, transaction))
                        {
                            command.Parameters.AddWithValue("@caseID", caseID);
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                caseExistsInCaseTable = true;
                            }

                            reader.Close();
                        }

                        using (SqlCommand command = new SqlCommand("SELECT CaseID FROM [Document] WHERE CaseID = @caseID", connection, transaction))
                        {
                            command.Parameters.AddWithValue("@caseID", caseID);
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                caseExistsInDocumentTable = true;
                            }

                            reader.Close();
                        }

                        if (caseExistsInCaseTable)
                        {
                            using (SqlCommand command = new SqlCommand("UPDATE [Case] SET Status = @newStatus, Progress = @newProgress, Description = @newDescription WHERE CaseID = @caseID", connection, transaction))
                            {
                                command.Parameters.AddWithValue("@newStatus", newStatus);
                                command.Parameters.AddWithValue("@newProgress", newProgress);
                                command.Parameters.AddWithValue("@newDescription", newDescription);
                                command.Parameters.AddWithValue("@caseID", caseID);
                                command.ExecuteNonQuery();
                            }
                        }

                        if (caseExistsInDocumentTable)
                        {
                            using (SqlCommand command = new SqlCommand("UPDATE [Document] SET DocumentName = @newDocument, UploadDate = @newUpload WHERE CaseID = @caseID", connection, transaction))
                            {
                                command.Parameters.AddWithValue("@newDocument", newDocument);
                                command.Parameters.AddWithValue("@newUpload", newUpload);
                                command.Parameters.AddWithValue("@caseID", caseID);
                                command.ExecuteNonQuery();
                            }
                        }
                        else if (caseExistsInDocumentTable == false)
                        {
                            using (SqlCommand command = new SqlCommand("INSERT INTO [Document] (CaseID, DocumentName, UploadDate) VALUES (@caseID, @newDocument, GETDATE())", connection, transaction))
                            {
                                command.Parameters.AddWithValue("@caseID", caseID);
                                command.Parameters.AddWithValue("@newDocument", newDocument);
                                command.Parameters.AddWithValue("@newUpload", newUpload);
                                command.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                        transaction.Rollback();
                    }
                    finally
                    {
                        if (connection != null && connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int selectedCaseID = CaseId;
            string newStatus = Status.SelectedItem.ToString();
            string newProgress = progressText.Text;
            string newDescription = caseDescription.Text;
            string newDocument = documentText.Text;
            string newUpload = uploadText.Text;
            UpdateCaseDetails(selectedCaseID, newStatus, newProgress, newDescription, newDocument, newUpload);
            MessageBox.Show("Case details updated successfully.", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form2 form2 = new Form2(email, connectionString, admin);
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}