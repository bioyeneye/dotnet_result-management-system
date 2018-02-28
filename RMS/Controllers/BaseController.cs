using BusinessLogic.Services;
using Model.ViewModel;

namespace RMS.Controllers
{
    public class BaseController
    {
        protected readonly IUserService UserService;
        public BaseController(IUserService userService)
        {
            UserService = userService;
        }

        public int GetCurrentUserId()
        {
            return RMS.Properties.Settings.Default.User;
        }

        public bool IsAuthenticated()
        {
            return RMS.Properties.Settings.Default.User > 0;
        }

        public UserModel CurrentUserInfo
        {
            get
            {
                var currentUserId = GetCurrentUserId();
                if (currentUserId == 0) return new UserModel();
                var user = UserService.GetUser(currentUserId);
                return user;
            }
        }
    }
}
