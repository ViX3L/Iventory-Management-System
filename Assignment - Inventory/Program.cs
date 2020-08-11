using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Windows.Forms;

namespace Assignment___Inventory
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        [STAThread]

        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }

        
    }
}
