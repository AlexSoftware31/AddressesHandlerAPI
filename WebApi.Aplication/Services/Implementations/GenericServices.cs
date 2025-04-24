using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Aplication.Interfaces;
using WebApi.Domain.Interfaces;

namespace WebApi.Aplication.Services.Implementations
{
    public class GenericServices<T, R> : IGenericServices<T>
    where T : class
    where R : IGenericRepository<T>
    {
        protected readonly R _repository;

        public GenericServices(R repository)
        {
            _repository = repository;
        }

        public async Task<List<T>> GetAll()
        {
            var list = await _repository.GetAll();
            return list.ToList();
        }

        public async Task<T?> FindById(object id)
        {
            return await _repository.FindById(id);
        }

        public async Task<(List<T> Items, int TotalCount)> GetPaged(int pageIndex, int pageSize)
        {
            var result = await _repository.GetPaged(pageIndex, pageSize);
            return (result.Items.ToList(), result.TotalCount);
        }

        public async Task Add(params T[] elements)
        {
            if (elements.All(IsValid))
            {
                await _repository.Add(elements);
            }
        }

        public async Task Update(params T[] elements)
        {
            if (elements.All(IsValid))
            {
                await _repository.Update(elements);
            }
        }

        public async Task Remove(params T[] elements)
        {
            await _repository.Remove(elements);
        }

        public virtual bool IsValid(T element)
        {
            return element != null;
        }
    }
}
