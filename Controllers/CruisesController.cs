using System;
using Microsoft.AspNetCore.Mvc;
using vacation.Models;
using vacation.Services;

namespace vacation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CruisesController : ControllerBase

    {
        private readonly CruisesService _service;

        public CruisesController(CruisesService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<Cruise> Create([FromBody] Cruise newCruise)
        {
            try
            {
                return Ok(_service.Create(newCruise));
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete]
        public ActionResult<Cruise> Delete(int id)
        {
            try
            {
                return Ok(_service.Delete(id));
            }
            catch (System.Exception err)
            {

                return BadRequest(err.Message);
            }

        }

    }
}