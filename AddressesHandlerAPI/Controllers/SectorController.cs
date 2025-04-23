using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Aplication.Interfaces;


namespace AddressesHandlerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class SectorController(ISectorServices sectorServices) : ControllerBase
    {

        [HttpGet(Name = "GetAllSectors")]
        public async Task<IActionResult> Get()
        {
            var sectors = await sectorServices.GetAll();

            return Ok(sectors);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var sector = await sectorServices.FindById(id);

            if (sector == null) {
             return NotFound(); 
            }

            return Ok(sector);
        }

        [HttpGet("GetByDistrictId/{dictrictId}")]
        public async Task<IActionResult> GetByDistrictId(int dictrictId)
        {
            var sectors = await sectorServices.FindByDistrictId(dictrictId);

            return Ok(sectors);
        }
    }
}
