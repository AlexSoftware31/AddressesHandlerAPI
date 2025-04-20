using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Aplication.Interfaces;
using WebApi.Domain.Entities;

namespace WebApi.Aplication.Interfaces
{
    public interface ISectorServices: IGenericServices<Sector>
    {
        Task<ICollection<Sector>> FindByDistrictId(int countryId);
    }
}
