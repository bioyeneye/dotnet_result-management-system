using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Services;
using Model.ViewModel;
using RMS.ActionResult;
using RMS.ViewHelper;
using Telerik.WinControls.UI;

namespace RMS.Controllers
{
    public class AccountController : BaseController
    {
        public AccountController(IUserService userService)
            : base(userService)
        {
        }

        public FormActionResult GetCount()
        {
            try
            {
                var responseData = UserService.GetCount();
                return new OkCollection<UserItem>(responseData.ToList());
            }
            catch (Exception ex)
            {
                return new BadRequest<string>(ex.Message, 300);
            }
        }

        public ActionResult<object> Post(UserModel model)
        {
            try
            {
                UserService.Create(model);
                return new ActionResult<object>(model, true);
            }
            catch (Exception ex)
            {
                return new ActionResult<object>(ex.Message, false);
            }

        }

        public ActionResult<object> Authenticate(UserModel model)
        {
            try
            {
                if(TextHelper.ContainsValue(new List<string> {model.Username, model.Password}))
                    return new ActionResult<object>("Ensure fields are filled", false);

                var isAuthenticUser = UserService.Authenticate(model);

                return !isAuthenticUser
                    ? new ActionResult<object>("Login credential is wrong", false)
                    : new ActionResult<object>(isAuthenticUser, true);
            }
            catch (Exception ex)
            {
                return new ActionResult<object>(ex.Message, false);

            }
        }


        /*
        public IHttpActionResult Put(UserModel model)
        {
            try
            {
                _userService.Update(model, GetCurrentUserId());
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public IHttpActionResult Delete(int id)
        {
            try
            {
                _userService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public IHttpActionResult GetItem(int id)
        {
            try
            {
                var responseData = _userService.GetItem(id);
                return Ok(responseData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public IHttpActionResult GetDetail(int id)
        {
            try
            {
                var responseData = _userService.GetDetail(id);
                return Ok(responseData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public IHttpActionResult GetLookup()
        {
            try
            {
                var responseData = _userService.GetLookup();
                return Ok(responseData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }*/
        public void ShowPassword(TextBox txtPassword, bool showPassword)
        {
            txtPassword.UseSystemPasswordChar = showPassword;
        }


    }
}
