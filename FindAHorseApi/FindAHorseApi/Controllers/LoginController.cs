using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FindAHorseBusiness.Business;
namespace FindAHorseApi.Controllers
{
    [RoutePrefix("userLogin")]
    public class LoginController : ApiController
    {
        private UserBusiness _userBusiness=new UserBusiness(); 
        [HttpGet]
        [Route("login")]
        public IHttpActionResult Login(string email,string password) {
            bool result = _userBusiness.UserLogin(email, password);
            return Ok(result);         
        }
    }
}
