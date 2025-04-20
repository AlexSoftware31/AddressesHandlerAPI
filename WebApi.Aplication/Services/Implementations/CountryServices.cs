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
    public class CountryServices(ICountryRepository repository) : GenericServices<Country, ICountryRepository>(repository), ICountryServices
    {

    }
}
