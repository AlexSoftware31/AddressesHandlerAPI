using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.Entities;

namespace WebApi.Domain.Interfaces
{
    public interface ISectorRepository : IGenericRepository<Sector>
    {
        Task<ICollection<Sector>> GetSectorsByDistrict(int districtId);
    }
}
