using AutoMapper;
using WebApi.Aplication.Dtos;
using WebApi.Domain.Entities;

namespace AddressesHandlerAPI.Helpers
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Address, AddressCreateDto>().ReverseMap();
            CreateMap<Address, AddressUpdateDto>().ReverseMap();
        }
    }
}
