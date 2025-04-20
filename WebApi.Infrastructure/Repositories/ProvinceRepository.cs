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
    public class ProvinceRepository(AppDbContext context) : GenericRepository<Province>(context), IProvinceRepository
    {
        public async Task<ICollection<Province>> GetProvincesByCountry(int countryId)
        {
            return await _context.Provinces.Where(c => c.IdCountry == countryId).ToListAsync();
        }
    }
}
