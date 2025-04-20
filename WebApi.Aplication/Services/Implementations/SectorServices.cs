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
    public class SectorServices(ISectorRepository repository) : GenericServices<Sector, ISectorRepository>(repository), ISectorServices
    {
        public async Task<ICollection<Sector>> GetAllSectors()
        {
            return await _repository.GetAll();
        }

        public async Task<ICollection<Sector>> FindByDistrictId(int districtId)
        {
            return await _repository.GetSectorsByDistrict(districtId);
        }
    }
}
