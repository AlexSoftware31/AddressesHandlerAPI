using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Aplication.Interfaces;


namespace AddressesHandlerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController(IDistrictServices districtServices) : ControllerBase
    {

        [HttpGet(Name = "GetAllDistricts")]
        public async Task<IActionResult> Get()
        {
            var districts = await districtServices.GetAll();

            return Ok(districts);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var district = await districtServices.FindById(id);

            if (district == null)
                return NotFound();

            return Ok(district);
        }

        [HttpGet("GetByMunicipalityId/{municipalityId}")]
        public async Task<IActionResult> GetByMunicipalityId(int municipalityId)
        {
           var districts = await districtServices.FindByMunicipalityId(municipalityId);

            return Ok(districts);
        }
    }
}
