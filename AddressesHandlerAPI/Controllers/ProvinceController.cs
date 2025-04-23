using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Aplication.Interfaces;


namespace AddressesHandlerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ProvinceController(IProvinceServices provinceServices) : ControllerBase
    {

        [HttpGet(Name = "GetAllProvinces")]
        public async Task<IActionResult> Get()
        {
            var provinces = await provinceServices.GetAll();

            return Ok(provinces);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var province = await provinceServices.FindById(id);

            if (province == null)
            {
                return NotFound();
            }

            return Ok(province);
        }

        [HttpGet("GetByCountryId/{countryId}")]
        public async Task<IActionResult> GetByCountryId(int countryId)
        {
            var provinces = await provinceServices.FindByCountryId(countryId);

            return Ok(provinces);
        }
    }
}
