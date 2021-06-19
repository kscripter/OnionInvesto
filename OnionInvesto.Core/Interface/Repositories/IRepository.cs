using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionInvesto.Core.Entities;

namespace OnionInvesto.Core.Repositories
{
    public interface IRepository<T> where  T : BaseEntity
    {
        public Task<T> AddAsync(T entity);

        public Task<T> FindByIdAsync(Guid id);

        public IQueryable<T> Query();

        public Task DeleteAsync(Guid id);

        public Task<T> UpdateAsync(T entity);

        public Task<int> SaveChangesAsync();
    }
}
