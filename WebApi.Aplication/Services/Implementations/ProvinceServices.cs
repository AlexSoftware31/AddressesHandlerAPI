using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Aplication.Interfaces;
using WebApi.Domain.Entities;
using WebApi.Infrastructure.Interfaces;

namespace WebApi.Aplication.Services.Implementations
{
    public class ProvinceServices(IProvinceRepository repository) : GenericServices<Province, IProvinceRepository>(repository), IProvinceServices
    {
        public async Task<ICollection<Province>> GetAllProvinces()
        {
            return await _repository.GetAll();
        }

        public async Task<ICollection<Province>> FindByCountryId(int countryId)
        {
            return await _repository.GetProvincesByCountry(countryId);
        }
    }
}
