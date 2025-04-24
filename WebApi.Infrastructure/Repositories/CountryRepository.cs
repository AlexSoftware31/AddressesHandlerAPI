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
    public class CountryRepository(AppDbContext context) : GenericRepository<Country>(context), ICountryRepository
    {


    }
}
