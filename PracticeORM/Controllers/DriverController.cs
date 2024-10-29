using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeORM.Interfaces;
using PracticeORM.Models;

namespace PracticeORM.Controllers
{
    [Route("api/drivers")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IDriverService service;
        public DriverController(IDriverService service)
        {
            this.service = service;
        }
        [HttpGet("all")]
        public ActionResult<ICollection<Driver>> GetDrivers([FromQuery]int skip = 0, [FromQuery] int take = 10)
        {
            return Ok(service.GetDrivers(skip, take));
        }
    }
}
