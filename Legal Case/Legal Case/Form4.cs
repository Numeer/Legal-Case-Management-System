﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Legal_Case
{
    public partial class Form4 : Form
    {
        private string Email;
        private string connectionString;
        private bool admin;
        public Form4(string email, string connection, bool admin)
        {
            InitializeComponent();
            Email = email;
            connectionString = connection;
            this.admin = admin;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT CONCAT(FirstName,' ',LastName,'    ','(ID: ',U.UserID,')') FROM [User] U JOIN [UserRole] R on U.UserID = R.UserID WHERE R.RoleID = 2", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                CaseAttroney.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }

            this.admin = admin;
        }

        private void Create_Case()
        {
            string title = CaseTitle.Text.ToString();
            string description = CaseDescription.Text.ToString();
            string attorney = CaseAttroney.SelectedItem.ToString();
            Match match = Regex.Match(attorney, @"\bID: (\d+)\b");
            int attorneyID = 0;
            if (match.Success)
            {
                string userIdString = match.Groups[1].Value;
                if (int.TryParse(userIdString, out attorneyID))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = @"INSERT INTO [CASE] VALUES(@name, @description, @attorney, @status, @progress)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", title);
                            cmd.Parameters.AddWithValue("@description", description);
                            cmd.Parameters.AddWithValue("@attorney", attorneyID);
                            cmd.Parameters.AddWithValue("@status", "Open");
                            cmd.Parameters.AddWithValue("@progress", 0);
                            cmd.ExecuteNonQuery();
                        }

                        string status = "";
                        int id = 0;
                        string query2 = @"SELECT CaseID, Status FROM [Case] WHERE CaseName = @name AND Description = @description AND AssignedAttorneyID = @attorney";
                        using (SqlCommand cmd = new SqlCommand(query2, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", title);
                            cmd.Parameters.AddWithValue("@description", description);
                            cmd.Parameters.AddWithValue("@attorney", attorneyID);
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                id = reader.GetInt32(0);
                                status = reader.GetString(1);
                            }
                            reader.Close();
                        }
                        if (status == "Open")
                            status = "Not Started";
                        else if (status == "Closed")
                            status = "Completed";
                        string query3 = @"INSERT INTO [Task] VALUES(@caseId, @description, @attorney, @deadline, @status)";
                        using (SqlCommand cmd = new SqlCommand(query3, conn))
                        {
                            cmd.Parameters.AddWithValue("@caseId", id);
                            cmd.Parameters.AddWithValue("@description", description);
                            cmd.Parameters.AddWithValue("@attorney", attorneyID);
                            cmd.Parameters.AddWithValue("@deadline", DateTime.Now.AddMonths(6));
                            cmd.Parameters.AddWithValue("@status", status);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Case successfully created", "", MessageBoxButtons.OK);
                        }
                        this.Close();
                        Form2 form2 = new Form2(Email, connectionString, admin);
                        form2.Show();
                    }
                }
            }
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Create_Case();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
