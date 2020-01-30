namespace ComboBugRepro
{
    using System;
    using System.Windows.Forms;

    static class Program
    {
        [STAThread]
        static void Main(string [] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.Automatic);

            using (var mainWindow = new frmMain())
            {
                Application.Run(mainWindow);
            }
        }
    }
}