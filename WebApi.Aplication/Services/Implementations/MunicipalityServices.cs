using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Aplication.Interfaces;
using WebApi.Domain.Entities;
using WebApi.Domain.Interfaces;

namespace WebApi.Aplication.Services.Implementations
{
    public class MunicipalityServices(IMunicipalityRepository repository) : GenericServices<Municipality, IMunicipalityRepository>(repository), IMunicipalityServices
    {
        public async Task<ICollection<Municipality>> FindByProvinceId(int provinceId)
        {
            return await _repository.GetMunicipalitiesByProvince(provinceId);
        }
    }
}
