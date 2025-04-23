using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.Entities;

namespace WebApi.Aplication.Interfaces
{
    public interface IUserServices: IGenericServices<User>
    {
        Task<bool> IsAuthorized(User userLogin);
    }
}
