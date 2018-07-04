using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Services;
using DataAccess.EF;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Model.ViewModel;
using RMS.ActionResult;
using RMS.Model;

namespace RMS.Controllers
{
    public class AccountNewController
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserStore<ApplicationUser> _userStore;

        public AccountNewController()
        {
            var rmsEntities = new ApplicationDbContext();
            _userStore = new UserStore<ApplicationUser>(rmsEntities);
            _userManager = new UserManager<ApplicationUser>(_userStore);
            _roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(rmsEntities));
        }

        public List<ApplicationUser> GetCount()
        {
            try
            {
                return _userManager.Users.ToList();
            }
            catch (Exception ex)
            {
                return new List<ApplicationUser>();
            }
        }


        public ApplicationUser Authenticate(LoginViewModel model)
        {
            var user = _userManager.Find(model.Username, model.Password);
            return user;
        }

        public bool Register(RegisterViewModel model)
        {
           var identityResult =  _userManager.Create(new ApplicationUser() {UserName = model.Email, Email = model.Email}, model.Password);
            return identityResult.Succeeded;
        }

        public void ShowPassword(TextBox txtPassword, bool showPassword)
        {
            txtPassword.UseSystemPasswordChar = showPassword;
        }

        public RolesConstants.Enum UserRole(ApplicationUser user)
        {
            RolesConstants.Enum returnEum = RolesConstants.Enum.Admin;
            var roleName = _roleManager.Roles.ToList().First(c => c.Id == user.Roles.First().RoleId).Name;
            switch (roleName)
            {
                case "SuperAdmin":
                    returnEum =  RolesConstants.Enum.SuperAdmin;
                    break;

                case "Student":
                    returnEum =  RolesConstants.Enum.Student;
                    break;


                case "Admin":
                    returnEum =  RolesConstants.Enum.Admin;
                    break;
            }

            return returnEum;
        }

    }
}
