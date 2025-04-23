using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.Entities;
using WebApi.Infrastructure.Context;
using WebApi.Infrastructure.Interfaces;

namespace WebApi.Infrastructure.Repositories
{
    public class UserRepository(AppDbContext context) : GenericRepository<User>(context), IUserRepository
    {
        public async Task<bool> IsAuthorized(User userLogin)
        {
            var user = await _context.Users.Where(u => u.Username == userLogin.Username).FirstOrDefaultAsync();

            if (user == null) 
                return false;

            bool isValid = BCrypt.Net.BCrypt.Verify(userLogin.PasswordHash, user.PasswordHash);

            return isValid;
        }
    }
}
