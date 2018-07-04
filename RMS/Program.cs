using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Services;
using DataAccess.BaseRepository;
using DataAccess.EF;
using DataAccess.Repository;
using log4net.Config;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.ReportingServices.Interfaces;
using RMS.Model;
using RMS.View;
using RMS.View.Admin;
using RMS.View.Reporting;
using RMS.View.SuperAdmin;
using RMS.View.SuperAdmin.Course;
using SimpleInjector;
namespace RMS
{
    static partial class Program
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
            Application.Run(container.GetInstance<ReportingPractise>());
        }


        private static void Bootstrap()
        {
            container = new Container();
            AutofacConfig.ConfigureDiContainer(container);
        }
    }
}