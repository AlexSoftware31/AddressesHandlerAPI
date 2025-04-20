using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApi.Infrastructure.Context;
using WebApi.Infrastructure.Interfaces;

namespace WebApi.Infrastructure.Repositories
{
    public class GenericRepository<T>(AppDbContext context) : IGenericRepository<T>
        where T : class
    {
        protected readonly AppDbContext _context = context;

        public async Task<IList<T>> GetAll(
        Expression<Func<T, bool>>? filter = null,
        params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbQuery = _context.Set<T>();

            if (filter != null)
            {
                dbQuery = dbQuery.Where(filter);
            }

            foreach (var navigationProperty in navigationProperties)
            {
                dbQuery = dbQuery.Include(navigationProperty);
            }

            return await dbQuery.AsNoTracking().ToListAsync();
        }

        public async Task<T?> FindById(object id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<(IList<T> Items, int TotalCount)> GetPaged(
            int pageIndex,
            int pageSize,
            Expression<Func<T, bool>>? filter = null,
            params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> dbQuery = _context.Set<T>();

            if (filter != null)
            {
                dbQuery = dbQuery.Where(filter);
            }

            foreach (var navigationProperty in navigationProperties)
            {
                dbQuery = dbQuery.Include(navigationProperty);
            }

            var totalCount = await dbQuery.CountAsync();

            var items = await dbQuery
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync();

            return (items, totalCount);
        }

        public async Task<int> GetCount()
        {
            return await _context.Set<T>().CountAsync();
        }

        public async Task Add(params T[] items)
        {
            await _context.Set<T>().AddRangeAsync(items);
            await _context.SaveChangesAsync();
        }

        public async Task Update(params T[] items)
        {
            _context.Set<T>().UpdateRange(items);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(params T[] items)
        {
            _context.Set<T>().RemoveRange(items);
            await _context.SaveChangesAsync();
        }
    }
}
