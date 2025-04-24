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
    public class NeighborhoodServices(INeighborhoodRepository repository) : GenericServices<Neighborhood, INeighborhoodRepository>(repository), INeighborhoodServices
    {
        public async Task<ICollection<Neighborhood>> GetAllNeighborhood()
        {
            return await _repository.GetAll();
        }

        public async Task<ICollection<Neighborhood>> FindBySectorId(int sectorId)
        {
            return await _repository.GetNeighborhoodsBySector(sectorId);
        }
    }
}
