using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.Entities;
using WebApi.Domain.Interfaces;
using WebApi.Infrastructure.Context;

namespace WebApi.Infrastructure.Repositories
{
    public class SectorRepository(AppDbContext context) : GenericRepository<Sector>(context), ISectorRepository
    {
        public async Task<ICollection<Sector>> GetSectorsByDistrict(int districtId)
        {
            return await _context.Sectors.Where(s => s.IdDistrict == districtId).ToListAsync();
        }
    }
}
