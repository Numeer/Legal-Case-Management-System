using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Legal_Case
{
    internal static class Program
    {
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Database connection successful.");
                    // You can perform further database operations here.

                    ApplicationConfiguration.Initialize();
                    Application.Run(new Form1());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}