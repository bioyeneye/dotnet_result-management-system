using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.EF;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Model.ViewModel;

namespace RMS.Model
{
    public class ApplicationDbInitializer
    {
        public class DefaultLogin
        {
            public string RoleName { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string EmailAddress { get; set; }
            public string UserName { get; set; }
            public string PhoneNumber { get; set; }
        }

        public static void InitializeIdentityForEf(ApplicationDbContext db)
        {
            var authContext = new ApplicationDbContext();
            var rmsContext = new RMSEntities();
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(authContext));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>());

            SetupHelper.SetupRoles(roleManager);
            CrateStartupAdminUsers(userManager);
            CreateLevel(rmsContext);
            CreateSemester(rmsContext);

        }

        private static void CreateSemester(RMSEntities dbContext)
        {
            try
            {
                var roles = new List<string>() { "Harmattan", "Rain" };
                foreach (var role in roles)
                {
                    if (!dbContext.Semeters.Any(c => c.Name == role))
                    {
                        dbContext.Semeters.Add(new Semeter() { Name = role, CreatedAt = DateTime.UtcNow });
                        dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static void CreateLevel(RMSEntities dbContext)
        {
            try
            {
                var levels = new List<string>() {"100", "200", "300", "400", "500"};
                foreach (var level in levels)
                {
                    if (!dbContext.Levels.Any(c => c.Name == level))
                    {
                        dbContext.Levels.Add(new Level() { Name = level, CreatedAt = DateTime.UtcNow});
                        dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void CreateUser(AspNetUserModel model)
        {
            var authContext = new ApplicationDbContext();
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(authContext));

            var user = Mapper.Map<AspNetUserModel, ApplicationUser>(model);

            userManager.Create(user, model.Password);
            userManager.SetLockoutEnabled(user.Id, false);
            userManager.AddToRole(user.Id, model.RoleName);
        }


        private static void CrateStartupAdminUsers(UserManager<ApplicationUser> userManager)
        {

            var logins = new List<DefaultLogin>()
            {
                new DefaultLogin
                {
                    Name = Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.SuperAdmin),
                    Password = "password1",
                    RoleName = Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.SuperAdmin),
                    FirstName = "Super",
                    LastName = "Admin",
                    EmailAddress = "superadmin@rms.com",
                    UserName = "superadmin"
                },

                new DefaultLogin
                {
                    Name = Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.Admin),
                    Password = "password1",
                    RoleName = Enum.GetName(typeof(RolesConstants.Enum), RolesConstants.Enum.Admin),
                    FirstName = "Admin",
                    LastName = "Admin",
                    EmailAddress = "admin@rms.com",
                    UserName = "admin"
                }

            };

            try
            {
                logins.ForEach(login =>
                {
                    if (!userManager.Users.Any(u => u.UserName == login.Name))
                    {
                        var user = new ApplicationUser
                        {
                            FirstName = login.FirstName,
                            LastName = login.LastName,
                            UserName = login.UserName,
                            Email = login.UserName,
                            TwoFactorEnabled = true,
                            EmailConfirmed = true //bypassing the email confirmation----take note
                        };
                        userManager.Create(user, login.Password);
                        userManager.SetLockoutEnabled(user.Id, false);

                        if (!userManager.IsInRole(user.Id, login.RoleName))
                            userManager.AddToRole(user.Id, login.RoleName);
                    }
                });
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                throw;
            }
        }

        public class SetupHelper
        {
            public static void SetupRoles(RoleManager<IdentityRole> roleManager)
            {
                var roles = Enum.GetNames(typeof(RolesConstants.Enum));
                foreach (var role in roles)
                {
                    if (!roleManager.RoleExists(role))
                    {
                        roleManager.Create(new IdentityRole() { Name = role });
                    }
                }
            }
        }
    }
}
