using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FindAHorseBusiness.Business;
using FindAHorseApiModel.ApiModel;
using System.Web;

namespace FindAHorseApi.Controllers
{
    [RoutePrefix("transporter")]
    public class TransporterController : ApiController
    {
        private HorseBoxBusiness _transporter = new HorseBoxBusiness();
        [HttpPost]
        [Route("add")]
        public IHttpActionResult AddTransporter(TransporterApiModel transporter)
        {
            //var httpRequest = HttpContext.Current.Request;
            //if (httpRequest.Files.Count < 1)
            //{
            //     return (IHttpActionResult)Request.CreateResponse(HttpStatusCode.BadRequest);
            //}
            //foreach (string file in httpRequest.Files)
            //{
            //    var postedFile = httpRequest.Files[file];
            //    var filePath = HttpContext.Current.Server.MapPath("~/UploadedFiles" + postedFile.FileName);
            //    postedFile.SaveAs(filePath);
            //    transporter.ImagePaths.Add(filePath);
            //}
            int result = _transporter.AddHorseBox(transporter);
            if (result > 0)
            {
                return Ok("Trasporter with Id:" + result + " created successfully");
            }
            else {
                return Ok("Transporter not created");
            }
           
        }
        [HttpGet]
        [Route("transporters")]
        public IHttpActionResult GetAllTransporter() {
            var result = _transporter.GetAllHorseBoxes(); 
            return Ok(result);
        }
        [HttpGet]
        [Route("find")]
        public IHttpActionResult FindTransportersByAddress(string searchText) {
            var result = _transporter.GetHorseBoxByAddress(searchText);
            return Ok(result);
        }
        [HttpGet]
        [Route("detail")]
        public IHttpActionResult GetTransporterDetails(int id)
        {
           var result = _transporter.GetTransporterDetails(id);
            return Ok(result);
        }

    }
}
