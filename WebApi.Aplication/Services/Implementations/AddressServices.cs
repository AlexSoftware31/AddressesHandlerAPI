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
    public class AddressServices(IAddressRepository repository) : GenericServices<Address, IAddressRepository>(repository), IAddressServices
    {

    }
}
