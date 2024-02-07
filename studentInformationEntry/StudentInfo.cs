using Microsoft.Identity.Client;

namespace studentInformationEntry
{
    internal static class studentInfo
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.Run(new LoginForm());
        }
    }
}