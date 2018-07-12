using System;
using System.Windows.Forms;
using log4net.Config;
using Microsoft.Reporting.WinForms;
using RMS.Model;
using RMS.View.Admin;
using RMS.View.Reporting;
using SimpleInjector;

namespace RMS
{
    static class Program
    {
        public static Container container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BasicConfigurator.Configure();
            ApplicationDbInitializer.InitializeIdentityForEf(new ApplicationDbContext());
            AutoMapperConfig.Map();
            Bootstrap();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(container.GetInstance<AuthForm>());
            Application.Run(container.GetInstance<EoMainForm>());
        }


        private static void Bootstrap()
        {
            container = new Container();
            AutofacConfig.ConfigureDiContainer(container);
        }
    }
}