using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
namespace Legal_Case
{
    internal static class Program
    {
        private static SqlConnection connection;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\LCMS\\Legal Case\\Legal Case\\Database1.mdf\";Integrated Security=True";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Gold\\LCMS\\Legal-Case-Management-System\\Legal Case\\Legal Case\\Database1.mdf\";Integrated Security=True";
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                Debug.WriteLine("Database connection successful.");
                // You can perform further database operations here.

                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                try
                {
                    
                    if (connection != null && connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                        connection.Dispose();
                    }

                    Debug.WriteLine("Application is exiting. Clean up resources...");

                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error during cleanup: " + ex.Message);
                }
            }

        }
    }
}