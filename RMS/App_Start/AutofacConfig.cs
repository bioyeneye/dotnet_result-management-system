using System.Linq;
using BusinessLogic.Services;
using DataAccess.BaseRepository;
using DataAccess.EF;
using DataAccess.Repository;
using RMS.Controllers;
using RMS.View;
using SimpleInjector;

namespace RMS
{
    static class AutofacConfig
    {
        public static void ConfigureDiContainer(Container container)
        {
            RepositoryLoad(container);
            ServiceLoad(container);
            ContextLoad(container);
            ViewLoad(container);
            Controller(container);
        }

        private static void RepositoryLoad(Container container)
        {
            var repositoryAssembly = typeof(UserRepository).Assembly;

            var registrations = repositoryAssembly.GetExportedTypes()
                .Where(x => x.Name.EndsWith("Repository") && x.IsClass)
                .Select(c => new
                {
                    Service = c.GetInterfaces().First(x => x.Name.EndsWith("Repository")),
                    Implementation = c
                });

            foreach (var reg in registrations)
            {
                container.Register(reg.Service, reg.Implementation, Lifestyle.Singleton);
            }
        }
        private static void ServiceLoad(Container container)
        {
            var repositoryAssembly = typeof(UserService).Assembly;

            var registrations = repositoryAssembly.GetExportedTypes()
                .Where(x => x.Name.EndsWith("Service") && x.IsClass)
                .Select(c => new
                {
                    Service = c.GetInterfaces().First(x => x.Name.EndsWith("Service")),
                    Implementation = c
                });

            foreach (var reg in registrations)
            {
                container.Register(reg.Service, reg.Implementation, Lifestyle.Singleton);
            }
        }
        private static void ContextLoad(Container container)
        {
            container.Register<IDataContextAsync, RMSEntities>(Lifestyle.Singleton);
            container.Register<IUnitOfWorkAsync, EntityFrameorkUnitOfWork>(Lifestyle.Singleton);
        }
        private static void ViewLoad(Container container)
        {
            var repositoryAssembly = typeof(Form1).Assembly;
            var registrations =
                repositoryAssembly.GetExportedTypes()?
                    .Where(c => c.FullName.Contains("View"))
                    .Select(c => new
                    {
                        Implemenation = c
                    });

            foreach (var reg in registrations)
            {
                container.Register(reg.Implemenation);
            }
        }

        private static void Controller(Container container)
        {
            //container.Register(typeof(BaseController));
            var repositoryAssembly = typeof(AccountController).Assembly;
            var registrations =
                repositoryAssembly.GetExportedTypes()?
                    .Where(c => c.FullName != null && c.FullName.Contains("Controllers"))
                    .Select(c => new
                    {
                        Implemenation = c
                    });

            foreach (var reg in registrations)
            {
                container.Register(reg.Implemenation);
            }
        }
    }
}