using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>> GetAll(
        Expression<Func<T, bool>>? filter = null,
        params Expression<Func<T, object>>[] navigationProperties);

        Task<T?> FindById(object id);

        Task<(IList<T> Items, int TotalCount)> GetPaged(
            int pageIndex,
            int pageSize,
            Expression<Func<T, bool>>? filter = null,
            params Expression<Func<T, object>>[] navigationProperties);
        Task<int> GetCount();
        Task Add(params T[] items);
        Task Update(params T[] items);
        Task Remove(params T[] items);
    }
}
