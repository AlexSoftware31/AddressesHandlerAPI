using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Aplication.Interfaces
{
    public interface IGenericServices<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T?> FindById(object id);
        Task<(List<T> Items, int TotalCount)> GetPaged(int pageIndex, int pageSize);
        Task Add(params T[] elements);
        Task Update(params T[] elements);
        Task Remove(params T[] elements);
    }
}
