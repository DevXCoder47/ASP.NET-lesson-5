using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeORM.DTOs;
using PracticeORM.Interfaces;
using PracticeORM.Models;

namespace PracticeORM.Controllers
{
    [Route("api/drivers")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IDriverService service;
        private readonly IMapper mapper;
        public DriverController(IDriverService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        #region Get Actions
        [HttpGet("all")]
        public ActionResult<ICollection<DriverDTO>> GetDrivers([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            try
            {
                return Ok(service.GetDrivers(skip, take).Select(mapper.Map<DriverDTO>));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("driver/{first_name}")]
        public ActionResult<DriverDTO> GetDriverByName([FromRoute] string first_name)
        {
            try
            {
                return Ok(mapper.Map<DriverDTO>(service.GetDriverByFirstName(first_name)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public ActionResult<DriverDTO> GetDriverById([FromRoute] int id)
        {
            try
            {
                return Ok(mapper.Map<DriverDTO>(service.GetDriverById(id)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion
        #region Post Actions
        [HttpPost]
        public ActionResult<DriverDTO> CreateDriver([FromBody] DriverDTO driverDTO)
        {
            try
            {
                service.CreateDriver(mapper.Map<Driver>(driverDTO));
                return Created(Url.Action("GetDrivers"), driverDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion
        #region Delete Actions
        [HttpDelete("delete/{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            try
            {
                service.DeleteDriver(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion
        #region Put Actions
        [HttpPut("put/{id}")]
        public ActionResult<DriverDTO> UpdateDriver([FromRoute] int id, [FromBody] DriverDTO driverDTO)
        {
            try
            {
                service.UpdateDriver(id, mapper.Map<Driver>(driverDTO));
                return Ok(driverDTO);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion
        #region Patch Actions
        [HttpPatch("patch/{id}")]
        public ActionResult PatchDriverName([FromRoute] int id, [FromQuery] string first_name, [FromQuery] string last_name)
        {
            try
            {
                service.PatchDriverName(id, first_name, last_name);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion
    }
}
