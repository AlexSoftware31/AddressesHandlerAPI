using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Aplication.Interfaces;
using WebApi.Domain.Entities;

namespace WebApi.Aplication.Interfaces
{
    public interface IProvinceServices:IGenericServices<Province>
    {
        Task<ICollection<Province>> FindByCountryId(int countryId);
    }
}
