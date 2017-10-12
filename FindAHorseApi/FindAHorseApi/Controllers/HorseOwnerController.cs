using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FindAHorseBusiness.Business;
using FindAHorseApiModel;
using System.Web;
using FindAHorseApiModel.ApiModel;

namespace FindAHorseApi.Controllers
{
    [RoutePrefix("horse")]
    public class HorseOwnerController : ApiController
    {
        private readonly HorseBusiness _horseBusiness = new HorseBusiness();
        [HttpPost]
        [Route("add")]
        public IHttpActionResult AddHorse(HorseApiModel horse)
        {
            var httpRequest = HttpContext.Current.Request;
            //if (httpRequest.Files.Count < 1)
            //{
            //    return (IHttpActionResult)Request.CreateResponse(HttpStatusCode.BadRequest);
            //}
            //foreach (string file in httpRequest.Files)
            //{
            //    var postedFile = httpRequest.Files[file];
            //    var filePath = HttpContext.Current.Server.MapPath("~/UploadedFiles" + postedFile.FileName);
            //    postedFile.SaveAs(filePath);
            //    horse.ImagePaths.Add(filePath);
            //}
            int result = _horseBusiness.AddHorse(horse);
            if (result > 0)
            {
                return Ok("Horse with Id:" + result + " created successfully");
            }
            else
            {
                return Ok("Horse not created");
            }
        }
        [HttpGet]
        public IHttpActionResult GetHorseById(int id)
        {
            var result = _horseBusiness.GetHorseById(id);
            if (result != null)
            {
                return Ok(result);
            }
            else return BadRequest("Data Not found");
        }
        [HttpGet]
        public IHttpActionResult GetHorseByOwnerId(int ownerId)
        {
            var result = _horseBusiness.GetHorseByOwnerId(ownerId);
            if (result != null)
            {
                return Ok(result);
            }
            else return BadRequest("Data Not found");
        }
    }
}
