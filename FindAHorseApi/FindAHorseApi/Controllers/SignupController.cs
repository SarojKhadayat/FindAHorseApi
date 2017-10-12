using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FindAHorseBusiness.Business;
using FindAHorseApiModel.ApiModel;
using System.Web;
using System.IO;

namespace FindAHorseApi.Controllers
{
    [RoutePrefix("userSignup")]
    public class SignupController : ApiController
    {
        private UserBusiness _userBussiness = new UserBusiness();

        [HttpPost]
        [Route("signup")]
        public IHttpActionResult SignUp(UserApiModel user)
        {
            try
            {
                var httpRequest = HttpContext.Current.Request;
                //if (httpRequest.Files.Count < 1)
                //{
                //    return (IHttpActionResult)Request.CreateResponse(HttpStatusCode.BadRequest);
                //}
               // var postedFile = httpRequest.Files[0];
              //  var filePath = HttpContext.Current.Server.MapPath("~/UploadedFiles" + postedFile.FileName);
              //  postedFile.SaveAs(filePath);
               // user.ProfilePicture = filePath;
                int userType = (int)Enum.Parse(typeof(Common.UserTypeEnum), user.UserType, true);
                bool userExists = _userBussiness.CheckIfUserExist(user.Email, userType);
                if (userExists)
                {
                    return Ok("User Already exists");
                }
                else
                {
                    int id = _userBussiness.CreateUser(user);
                    if (id > 0)
                    {
                        return Ok("User Created Successfully");
                    }
                    else { return Ok("User not created"); }
                }
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
    }
}
