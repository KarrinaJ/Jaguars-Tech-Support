using Control;
using Jaguars_Tech_Support.Boundary;
using System.Diagnostics;

namespace Jaguars_Tech_Support
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

            StartController.Initiate();


        }
    }
}