using System;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Services;
using DataAccess.BaseRepository;
using DataAccess.EF;
using DataAccess.Repository;
using Microsoft.ReportingServices.Interfaces;
using RMS.View;
using SimpleInjector;
namespace RMS
{
    static partial class Program
    {
        private static Container container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutoMapperConfig.Map();
            Bootstrap();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.GetInstance<AuthForm>());
        }

        private static void Bootstrap()
        {
            // Create the container as usual.
            container = new Container();

            // Register your types, for instance:
            //container.Register<IUserRepository, UserRepository>(Lifestyle.Singleton);
            //container.Register<IDataContextAsync, RMSEntities>(Lifestyle.Singleton);
            //container.Register<IUnitOfWorkAsync, EntityFrameorkUnitOfWork>(Lifestyle.Singleton);
            //container.Register<Form1>();
            AutofacConfig.ConfigureDiContainer(container);

        }
    }
}