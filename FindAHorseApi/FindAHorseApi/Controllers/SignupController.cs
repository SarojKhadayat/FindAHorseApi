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
            if (HttpContext.Current.Request.Files.AllKeys.Any())
            {
                // Get the uploaded image from the Files collection
                var httpPostedFile = HttpContext.Current.Request.Files["UploadedImage"];

                if (httpPostedFile != null)
                {
                    // Validate the uploaded image(optional)
                    // Get the complete file path
                    var fileSavePath = Path.Combine(HttpContext.Current.Server.MapPath("~/UploadedFiles"), httpPostedFile.FileName);
                    // Save the uploaded file to "UploadedFiles" folder
                    httpPostedFile.SaveAs(fileSavePath);
                    user.ProfilePicture = httpPostedFile.FileName;
                }             
            }
            return Ok(_userBussiness.CreateUser(user));
        }
    }
}
