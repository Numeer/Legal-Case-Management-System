using System.Data;
using System.Data.SqlClient;

namespace Legal_Case
{
    public partial class Form1 : Form
    {
        private string connectionString;
        private SqlConnection connection;
        private int userID = 0;

        public Form1()
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\LCMS\\Legal Case\\Legal Case\\Database1.mdf\";Integrated Security=True";
            //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Gold\\LCMS\\Legal-Case-Management-System\\Legal Case\\Legal Case\\Database1.mdf\";Integrated Security=True";
            InitializeComponent();
            connection = new SqlConnection(connectionString);

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
                    Form2 form2 = new Form2(email, connectionString);
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
            try
            {
                connection.Open();
                string query1 = "SELECT [UserId],[PasswordAttempts],[IsLocked],[LockedTime] from [User] where [Email] = @Email";
                using (SqlCommand cmd = new SqlCommand(query1, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    SqlDataReader reader = cmd.ExecuteReader();

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

                return false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void LockAccount()
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
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
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private bool UnlockAccount()
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string updateQuery = "UPDATE [User] SET [IsLocked] = 0, [LockedTime] = NULL WHERE [UserId] = @userID";
                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if(rowsAffected>0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private bool ValidateUser(string email, string password)
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string query = "SELECT COUNT(*) FROM [User] WHERE [Email] = @Email AND [Password] = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    int result = (int)command.ExecuteScalar();
                    return result > 0;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void IncrementLoginAttempts()
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string updateQuery = "UPDATE [User] SET [PasswordAttempts] = [PasswordAttempts] + 1 WHERE [userID] = @userID";
                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("userID", userID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void ResetLoginAttempts()
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string resetQuery = "UPDATE [User] SET [PasswordAttempts] = 0 WHERE [userID] = @userID";
                using (SqlCommand cmd = new SqlCommand(resetQuery, connection))
                {
                    cmd.Parameters.AddWithValue("userID", userID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            this.Close();
        }

    }
}