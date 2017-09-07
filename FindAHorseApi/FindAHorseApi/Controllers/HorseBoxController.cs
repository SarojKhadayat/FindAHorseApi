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
    public class HorseBoxController : ApiController
    {
        private readonly HorseBoxBusiness _horseBoxBusiness = new HorseBoxBusiness();
        public IHttpActionResult AddHorseBox(tblHorseBox horseBox)
        {
            var result = _horseBoxBusiness.AddHorseBox(horseBox);
            if (result > 0)
            {
                return Ok(result);
            }
            else return Ok(false);

        }

        public IHttpActionResult GetAllHorseBoxes()
        {
            var result = _horseBoxBusiness.GetAllHorseBoxes();
            if (result != null)
            {
                return Ok(result);
            }
            else return BadRequest("No Data found");
        }

        public IHttpActionResult GetHorseBoxesByBoxOwnerId(int boxOwnerId)
        {
            var result = _horseBoxBusiness.GetHorseBoxesByBoxOwnerId(boxOwnerId);
            if (result != null)
            {
                return Ok(result);
            }
            else return BadRequest("No Data found");
        }

        public IHttpActionResult GetHorseBoxesById(int id)
        {
            var result = _horseBoxBusiness.GetHorseBoxesById(id);
            if (result != null)
            {
                return Ok(result);
            }
            else return BadRequest("No Data found");
        }
    }
}
