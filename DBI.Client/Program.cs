using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;

namespace DBI.Client
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
            Application.Run(new mainForm());

        }

    }
}
