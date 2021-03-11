using System;
using System.Threading;
using System.Windows.Forms;

namespace Discord_Rich_Presence
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string appName = "Discord Rich Presence";
            bool createdNew;
            new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                MessageBox.Show(appName + " is already running! Exiting the application", "Error!");
                Environment.Exit(0);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DiscordRichPresence());
        }
    }

}
