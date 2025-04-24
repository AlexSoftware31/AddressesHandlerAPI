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
    public class NeighborhoodRepository(AppDbContext context) : GenericRepository<Neighborhood>(context), INeighborhoodRepository
    {
        public async Task<ICollection<Neighborhood>> GetNeighborhoodsBySector(int sectorId)
        {
            return await _context.Neighborhoods.Where(n => n.IdSector == sectorId).ToListAsync();
        }
    }
}
