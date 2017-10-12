using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FindAHorseBusiness.Business;
using FindAHorseApi.Common;
namespace FindAHorseApi.Controllers
{
    [RoutePrefix("userLogin")]
    public class LoginController : ApiController
    {
        private UserBusiness _userBusiness = new UserBusiness();
        [HttpGet]
        [Route("login")]
        public IHttpActionResult Login(string email, string password, string loginAs)
        {
            int userType = (int)Enum.Parse(typeof(UserTypeEnum), loginAs, true);
            var result = _userBusiness.UserLogin(email, password, userType);
            if (result != null)
            {
                return Ok(result);
            }
            else return Ok("Login Failed");           
        }
    }
}
