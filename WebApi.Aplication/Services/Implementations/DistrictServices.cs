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
    public class DistrictServices(IDistrictRepository repository) : GenericServices<District, IDistrictRepository>(repository), IDistrictServices
    {
        public async Task<ICollection<District>> FindByMunicipalityId(int municipalityId)
        {
            return await _repository.GetDistrictsByMunicipality(municipalityId);
        }
    }
}
