using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PetrovNE.Sprint7.Project0.V10
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*if(Environment.OSVersion.Version.Major >= 6) fix blur window - не смог прочесть user32dll не стал разбираться
            {
                SetProcessDpiAware();
            }*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLicense());
        }
        /*[System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDpiAware();*/
    }
}
