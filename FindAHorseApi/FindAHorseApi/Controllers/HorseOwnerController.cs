using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FindAHorseBusiness.Business;
using FindAHorseApiModel;
namespace FindAHorseApi.Controllers
{
    [RoutePrefix("horseOwner")]
    public class HorseOwnerController : ApiController
    {
        private readonly HorseBusiness _horseBusiness=new HorseBusiness();
       
        public IHttpActionResult AddHorse(tblHors horse)
        {
            int id = _horseBusiness.AddHorse(horse);
            return Ok(id);
        }
        public IHttpActionResult GetHorseById(int id)
        {
          var result= _horseBusiness.GetHorseById(id);
            if (result != null)
            {
                return Ok(result);
            }
            else return BadRequest("Data Not found");
        }

        public IHttpActionResult GetHorseByOwnerId(int ownerId)
        {
            var result= _horseBusiness.GetHorseByOwnerId(ownerId);
            if (result != null) {
                return Ok(result);
            }
            else return BadRequest("Data Not found");
        }
    }
}
