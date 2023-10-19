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
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\LCMS\\Legal Case\\Legal Case\\Database1.mdf\";Integrated Security=True";
        }
    }
}