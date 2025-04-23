using AddressesHandlerAPI.Helpers;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Aplication.DTOs;
using WebApi.Aplication.Interfaces;
using WebApi.Domain.Entities;

namespace AddressesHandlerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IUserServices userServices, IMapper mapper) : ControllerBase
    {
        private readonly IMapper _mapper = mapper;
        private readonly IUserServices _userServices = userServices;

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserDto userDto)
        {
            var userLogin = _mapper.Map<User>(userDto);

            if (await _userServices.IsAuthorized(userLogin))
            {
                var token = JwtHelper.GenerateJwtToken(userLogin.Username);
                var expiryDate = DateTime.UtcNow.AddHours(1);
                var issued = DateTime.UtcNow;
                return Ok(new { token, expiryDate, issued });
            }

            return Unauthorized();
        }
    }
}
