using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.Entities;

namespace WebApi.Domain.Interfaces
{
    public interface INeighborhoodRepository : IGenericRepository<Neighborhood>
    {
        Task<ICollection<Neighborhood>> GetNeighborhoodsBySector(int sectorId);
    }
}
