using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Aplication.Interfaces;

namespace AddressesHandlerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NeighborhoodController(INeighborhoodServices neighborhoodServices) : ControllerBase
    {

        [HttpGet(Name = "GetAllNeighborhoods")]
        public async Task<IActionResult> Get()
        {
            var neighborhoods = await neighborhoodServices.GetAll();

            return Ok(neighborhoods);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var neighborhood = await neighborhoodServices.FindById(id);

            if (neighborhood == null) {
                return NotFound();
            }

            return Ok(neighborhood);
        }

        [HttpGet("GetBySectorId/{sectorId}")]
        public async Task<IActionResult> GetBySectorId(int sectorId)
        {
            var neighborhoods = await neighborhoodServices.FindBySectorId(sectorId);

            return Ok(neighborhoods);
        }
    }
}
