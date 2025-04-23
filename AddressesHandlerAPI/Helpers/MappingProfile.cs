using AutoMapper;
using WebApi.Aplication.DTOs;
using WebApi.Domain.Entities;

namespace AddressesHandlerAPI.Helpers
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Address, AddressCreateDto>().ReverseMap();
            CreateMap<Address, AddressUpdateDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
