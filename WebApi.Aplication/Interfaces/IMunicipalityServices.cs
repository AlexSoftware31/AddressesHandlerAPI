using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.Entities;

namespace WebApi.Aplication.Interfaces
{
    public interface IMunicipalityServices : IGenericServices<Municipality>
    {
        Task<ICollection<Municipality>> FindByProvinceId(int provinceId);
    }
}
