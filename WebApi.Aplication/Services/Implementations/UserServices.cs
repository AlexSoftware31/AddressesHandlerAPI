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
    public class UserServices(IUserRepository repository) : GenericServices<User, IUserRepository>(repository), IUserServices
    {
        public Task<bool> IsAuthorized(User userLogin)
        {
            return _repository.IsAuthorized(userLogin);
        }
    }
}
