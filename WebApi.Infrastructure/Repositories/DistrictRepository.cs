using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.Entities;
using WebApi.Infrastructure.Context;
using WebApi.Infrastructure.Interfaces;

namespace WebApi.Infrastructure.Repositories
{
    public class DistrictRepository(AppDbContext context) : GenericRepository<District>(context), IDistrictRepository
    {
        public async Task<ICollection<District>> GetDistrictsByMunicipality(int municipalityId)
        {
            return await _context.Districts.Where(d => d.IdMunicipality == municipalityId).ToListAsync();
        }
    }
}
