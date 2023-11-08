﻿using System;
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
        private string connectionString;
        public Form2(string userEmail, string String)
        {
            email = userEmail;
            connectionString = String;
            InitializeComponent();
            PopulateCaseData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update")
                    {
                        int selectedCaseID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CaseID"].Value);

                        if (HasPermission("UpdateCase"))
                        {
                            DataTable caseDetails = RetrieveCaseDetails(selectedCaseID);
                            Form3 form3 = new Form3(caseDetails, selectedCaseID, connectionString);
                            form3.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("You do not have permission to update cases.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
                    {
                        int selectedCaseID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CaseID"].Value);

                        if (HasPermission("DeleteCase"))
                        {
                            DataTable caseDetails = RetrieveCaseDetails(selectedCaseID);
                            MessageBox.Show("Case successfully deleted", "", MessageBoxButtons.OK);
                            //To be Implement :(
                        }
                        else
                        {
                            MessageBox.Show("You do not have permission to delete cases.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
        private DataTable RetrieveCaseDetails(int caseID)
        {
            string query = @"SELECT C.CaseName, C.Description, C.Status, C.Progress, D.DocumentName, D.UploadDate
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

            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.HeaderText = "Update";
            updateButtonColumn.Text = "Do";
            updateButtonColumn.UseColumnTextForButtonValue = true;
            updateButtonColumn.FlatStyle = FlatStyle.Popup;
            updateButtonColumn.DefaultCellStyle.BackColor = Color.DarkGray;
            updateButtonColumn.DefaultCellStyle.ForeColor = Color.White;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Do";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.FlatStyle = FlatStyle.Popup;
            deleteButtonColumn.DefaultCellStyle.BackColor = Color.DarkGray;
            deleteButtonColumn.DefaultCellStyle.ForeColor = Color.White;

            dataGridView1.Columns.Add(updateButtonColumn);
            dataGridView1.Columns.Add(deleteButtonColumn);
        }

        private bool HasPermission(string permissionName)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT COUNT(*) 
                        FROM [User] AS U
                        INNER JOIN [UserRole] AS UR ON U.UserID = UR.UserID
                        INNER JOIN [Role] AS R ON UR.RoleID = R.RoleID
                        INNER JOIN [RolePermissions] AS RP ON R.RoleID = RP.RoleID
                        INNER JOIN [Permissions] AS P ON RP.PermissionID = P.PermissionID
                        WHERE U.Email = @Email AND P.PermissionName = @PermissionName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PermissionName", permissionName);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}