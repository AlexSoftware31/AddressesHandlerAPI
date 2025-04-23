using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebApi.Aplication.Interfaces;

namespace AddressesHandlerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CountryController (ICountryServices countryServices) :  ControllerBase
    {
        private readonly ICountryServices _countryServices = countryServices;

        [HttpGet(Name = "GetAllCountries")]
        public async Task<IActionResult> Get()
        {
            var countries = await _countryServices.GetAll();

            return Ok(countries);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var country = await _countryServices.FindById(id);

            if (country == null)
                return BadRequest(country);


            return Ok(country);

        }
    }
}
