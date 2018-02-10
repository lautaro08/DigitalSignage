using System;
using System.Windows.Forms;

using DTO;

namespace UI
{
    static class Program
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
      
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            log.Info("Registering mappings");
            AutoMapperConfig.RegisterMappings();

            log.Info("Starting application");
            Application.Run(new MainView());

        }
    }
}
