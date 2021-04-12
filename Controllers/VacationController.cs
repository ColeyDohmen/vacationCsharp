using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using vacation.Models;
using vacation.Services;

namespace vacation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VacationController : ControllerBase
    {

        private readonly VacationService _vacationService;

        public VacationController(VacationService VacationService)
        {
            _vacationService = VacationService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Vacation>> GetAllVacations()
        {
            try
            {
                return Ok(_vacationService.getAll());
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

    }
}