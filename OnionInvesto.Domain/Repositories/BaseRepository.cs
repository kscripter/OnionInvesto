using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnionInvesto.Core.Entities;
using OnionInvesto.Core.Interface.Repository;
using OnionInvesto.Core.Repositories;
using OnionInvesto.Data.Context;

namespace OnionInvesto.Domain.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where  T: BaseEntity , new()
    {
        protected InvestoContext DbContext { get; set; }

        public async Task<T> AddAsync(T entity)
        {
            await DbContext.Set<T>().AddAsync(entity);
            return entity;
        }

        public  Task DeleteAsync(Guid id)
        {
            var entity = new T
            {
                Id = id
            };
            return DeleteAsync(entity);
        }

        public Task DeleteAsync(T entity)
        {
            DbContext.Set<T>().Remove(entity);
            return Task.CompletedTask;
        }

        public async Task<T> FindByIdAsync(Guid id)
        {
            return await DbContext.Set<T>().SingleOrDefaultAsync(e => e.Id == id);
        }

        public IQueryable<T> Query()
        {
            return DbContext.Set<T>().AsQueryable();
        }

        public Task<T> UpdateAsync(T entity)
        {
            DbContext.Set<T>().Update(entity);
            return Task.FromResult(entity);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await DbContext.SaveChangesAsync();
        }
    }
}
