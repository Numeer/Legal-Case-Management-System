using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legal_Case
{
    public partial class Form5 : Form
    {
        private string connectionString;
        private string login_email;
        public Form5(string mail, string conn)
        {
            login_email = mail;
            connectionString = conn;
            InitializeComponent();
            Role.Items.Add("Attorney");
            Role.Items.Add("User");
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string fname = FirstName.Text.ToString();
                string lname = LastName.Text.ToString();
                string phn = PhNo.Text.ToString();
                string email = Email.Text.ToString();
                string country = Country.Text.ToString();
                string password = Password.Text.ToString();
                string role = Role.SelectedItem.ToString();
                int roleId = RoleId(role);
                int id = -1, rows = 0;
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            var query = @"Insert into [User] values (@firstname, @lastname, @contact, @email, @country, @password, @login, @attempts, @lock, @time);";
                            try
                            {
                                using (SqlCommand command = new SqlCommand(query, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@firstname", fname);
                                    command.Parameters.AddWithValue("@lastname", lname);
                                    command.Parameters.AddWithValue("@contact", phn);
                                    command.Parameters.AddWithValue("@email", email);
                                    command.Parameters.AddWithValue("@country", country);
                                    command.Parameters.AddWithValue("@password", password);
                                    command.Parameters.AddWithValue("@login", DBNull.Value);
                                    command.Parameters.AddWithValue("@attempts", DBNull.Value);
                                    command.Parameters.AddWithValue("@lock", DBNull.Value);
                                    command.Parameters.AddWithValue("@time", DBNull.Value);
                                    rows = command.ExecuteNonQuery();
                                }
                                if (rows > 0)
                                {
                                    rows = 0;
                                    try
                                    {
                                        var query2 = @"Select UserID from [User] where Email = @email";
                                        using (SqlCommand cmd = new(query2, connection, transaction))
                                        {
                                            cmd.Parameters.AddWithValue("@email", email);
                                            using (SqlDataReader reader = cmd.ExecuteReader())
                                            {
                                                if (reader.HasRows)
                                                {
                                                    reader.Read();
                                                    id = (int)reader["UserID"];

                                                }
                                            }
                                        }
                                        if (id != -1)
                                        {
                                            try
                                            {
                                                var query3 = @"INSERT INTO [UserRole] values (@userid, @roleid)";
                                                using (SqlCommand cmd = new SqlCommand(query3, connection, transaction))
                                                {
                                                    cmd.Parameters.AddWithValue("@userid", id);
                                                    cmd.Parameters.AddWithValue("@roleid", roleId);
                                                    rows = cmd.ExecuteNonQuery();
                                                    if (rows > 0)
                                                    {
                                                        transaction.Commit();
                                                        MessageBox.Show("User added successfully!");
                                                        this.Close();
                                                        Form2 form2 = new Form2(login_email, connectionString);
                                                        form2.Show();
                                                    }
                                                }
                                            }
                                            catch (SqlException ex)
                                            {
                                                MessageBox.Show("Error while assigning role to user" + ex.Message);
                                                Console.WriteLine("Error while assignng role: " + ex.Message);
                                                transaction.Rollback();
                                            }
                                        }
                                    }
                                    catch (SqlException ex)
                                    {
                                        MessageBox.Show("Error while reading ID from user" + ex.Message);
                                        Console.WriteLine("Error while reading ID: " + ex.Message);
                                    }
                                }
                            }
                            catch (SqlException ex)
                            {
                                Console.WriteLine("Error while inserting into user: " + ex.Message);
                                MessageBox.Show("Error while inserting into user" + ex.Message);
                                transaction.Rollback();
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error while starting transaction: " + ex.Message);
                            Console.WriteLine("Error while starting transaction: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while opening database: " + ex.Message);
                }
            }

        }
        public static int RoleId(string role)
        {
            if (role == "Attorney")
                return 2;
            else if (role == "User")
                return 3;
            else
                return -1;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
