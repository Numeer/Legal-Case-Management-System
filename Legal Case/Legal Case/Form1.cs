using System.Data;
using System.Data.SqlClient;

namespace Legal_Case
{
    public partial class Form1 : Form
    {
        private string connectionString;
        private int userID = 0;
        private bool admin = false;

        public Form1()
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Legal-Case-Management-System\\Legal Case\\Legal Case\\Database1.mdf\";Integrated Security=True";
            //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Gold\\LCMS\\Legal-Case-Management-System\\Legal Case\\Legal Case\\Database1.mdf\";Integrated Security=True";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = nameText.Text;
            string password = passwordText.Text;

            if (!CheckLock(email, password))
            {
                bool isValidUser = ValidateUser(email, password);

                if (isValidUser)
                {
                    MessageBox.Show("Login successful!");
                    ResetLoginAttempts();
                    CheckIfAdmin();
                    SetLastLogin();
                    Form2 form2 = new Form2(email, connectionString,admin);
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.");
                    IncrementLoginAttempts();
                }
            }
        }

        private bool CheckLock(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT [UserId],[PasswordAttempts],[IsLocked],[LockedTime] from [User] where [Email] = @Email";
                using (SqlCommand cmd = new SqlCommand(query1, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userID = (int)reader["UserId"];
                            int passwordAttempts = (int)reader["PasswordAttempts"];
                            bool isLocked = (bool)reader["IsLocked"];

                            if (isLocked)
                            {
                                DateTime now = DateTime.UtcNow;
                                if (reader["LockedTime"] != DBNull.Value && (now - (DateTime)reader["LockedTime"]) >= TimeSpan.FromMinutes(30))
                                {
                                    reader.Close();
                                    if (UnlockAccount())
                                    {
                                        return false;
                                    }
                                }
                                else
                                {
                                    reader.Close();
                                    LockAccount();
                                    MessageBox.Show("Your account is locked! Please try again after 30 minutes.");
                                    return true;
                                }
                            }
                            else if (passwordAttempts >= 5)
                            {
                                reader.Close();
                                LockAccount();
                                MessageBox.Show("Your account is locked! Please try again after 30 minutes.");
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
        }


        private void LockAccount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DateTime now = DateTime.UtcNow;
                DateTime lockedTime = now.AddMinutes(30);
                string updateQuery = "UPDATE [User] SET [IsLocked] = 1, [LockedTime] = @lockedTime WHERE [UserId] = @userID";

                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@lockedTime", lockedTime);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private bool UnlockAccount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE [User] SET [IsLocked] = 0, [LockedTime] = NULL WHERE [UserId] = @userID";
                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


        private bool ValidateUser(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM [User] WHERE [Email] = @Email AND [Password] = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    int result = (int)command.ExecuteScalar();
                    return result > 0;
                }
            }
        }


        private void IncrementLoginAttempts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE [User] SET [PasswordAttempts] = [PasswordAttempts] + 1 WHERE [userID] = @userID";
                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void ResetLoginAttempts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string resetQuery = "UPDATE [User] SET [PasswordAttempts] = 0";
                using (SqlCommand cmd = new SqlCommand(resetQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void CheckIfAdmin()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string adminQuery = "Select [r].[RoleName] from [Role] AS r INNER JOIN [UserRole] as UR ON r.RoleID = UR.RoleID where UR.UserId = @userID";
                using (SqlCommand cmd = new SqlCommand(adminQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = (string)reader["RoleName"];
                            if (name == "Admin")
                            {
                                admin = true;
                            }
                        }
                    }
                }
            }
        }
        
        
        private void SetLastLogin()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string resetQuery = "UPDATE [User] SET [LastLoggedIn] = @last where [UserId] = @userId";
                DateTime time = DateTime.Now;
                using (SqlCommand cmd = new SqlCommand(resetQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@last", time);
                    cmd.Parameters.AddWithValue("@userId", userID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


    }
}