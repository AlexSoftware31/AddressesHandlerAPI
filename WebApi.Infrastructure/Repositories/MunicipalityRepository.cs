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
    public class MunicipalityRepository(AppDbContext context) : GenericRepository<Municipality>(context), IMunicipalityRepository
    {
        public async Task<ICollection<Municipality>> GetMunicipalitiesByProvince(int provinceId)
        {
            return await _context.Municipalities.Where(m => m.IdProvince == provinceId).ToListAsync();
        }
    }
}
