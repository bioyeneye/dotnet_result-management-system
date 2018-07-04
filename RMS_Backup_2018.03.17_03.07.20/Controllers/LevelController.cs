/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Services;
using Model.ViewModel;

namespace RMS.Controller
{
    public class LevelController : BaseController
    {
        private readonly ILevelService _levelService;
        public LevelController(IUserService userService, ILevelService levelService)
            : base(userService)
        {
            _levelService = levelService;
        }

        public IHttpActionResult GetCount()
        {
            try
            {
                var responseData = _levelService.GetCount();
                return Ok(responseData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        public IHttpActionResult Post(LevelModel model)
        {

            try
            {
                _levelService.Create(model, GetCurrentUserId());
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        public IHttpActionResult Put(LevelModel model)
        {
            try
            {
                _levelService.Update(model, GetCurrentUserId());
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
                _levelService.Delete(id);
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
                var responseData = _levelService.GetItem(id);
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
                var responseData = _levelService.GetDetail(id);
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
                var responseData = _levelService.GetLookup();
                return Ok(responseData);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
*/
