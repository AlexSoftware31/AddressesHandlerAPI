using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Aplication.Interfaces;

namespace AddressesHandlerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class MunicipalityController( IMunicipalityServices municipalityServices ) : ControllerBase
    {

        [HttpGet(Name = "GetAllMunicipalities")]
        public async Task<IActionResult> Get()
        {
            var municipalities = await municipalityServices.GetAll();

            return Ok(municipalities);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var municipality = await municipalityServices.FindById(id);

            if (municipality == null) {
             return NotFound();
            }

            return Ok(municipality);
        }

        [HttpGet("GetByProvinceId/{provinceId}")]
        public async Task<IActionResult> GetByProvinceId(int provinceId)
        {
            var municipalities = await municipalityServices.FindByProvinceId(provinceId);

            return Ok(municipalities);
        }
    }
}
