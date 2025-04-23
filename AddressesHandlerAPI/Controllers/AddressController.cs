using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Aplication.DTOs;
using WebApi.Aplication.Interfaces;
using WebApi.Domain.Entities;

namespace AddressesHandlerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class AddressController(IAddressServices addressServices, IMapper mapper) : ControllerBase
    {
        private readonly IAddressServices _addressServices = addressServices;
        private readonly IMapper _mapper = mapper;

        [HttpGet(Name = "GetAllAddress")]
        public async Task<IActionResult> Get()
        {
            var addresses = await _addressServices.GetAll();

            return Ok(addresses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var address = await _addressServices.FindById(id);

            if (address == null)
                return NotFound();

            var addressDto = _mapper.Map<AddressCreateDto>(address);

            return Ok(addressDto);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddressCreateDto addressDto)
        {

            var address = _mapper.Map<Address>(addressDto);

            await _addressServices.Add(address);

            return CreatedAtAction(nameof(GetById), new { id = address.Id }, new { message = "Address created!" });
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] AddressUpdateDto addressDto)
        {
          
            var address = _mapper.Map<Address>(addressDto);

            await _addressServices.Update(address);

            return Ok(new { message = "Address updated!" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
           var address = await _addressServices.FindById(id);

            if (address == null)
                return NotFound();

            await _addressServices.Remove(address);

            return Ok(new { message = "Address deleted!" });
        }

       
    }
}
