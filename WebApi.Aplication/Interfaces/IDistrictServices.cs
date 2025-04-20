using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.Entities;

namespace WebApi.Aplication.Interfaces
{
    public interface IDistrictServices:IGenericServices<District>
    {
        Task<ICollection<District>> FindByMunicipalityId(int munipalityId);
    }
}
