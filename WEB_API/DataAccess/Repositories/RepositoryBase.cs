using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected AUTOMAContext RepositoryContext { get; set; }

        public RepositoryBase(AUTOMAContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public async Task<List<T>> GetAll() => await RepositoryContext.Set<T>().AsNoTracking().ToListAsync();
        public async Task<List<T>> GetOne(Expression<Func<T, bool>>expression) => await  RepositoryContext.Set<T>().Where(expression).AsNoTracking().ToListAsync();
        public async Task Create(T entity) => await RepositoryContext.Set<T>().AddAsync(entity);
        public async Task Update(T entity) => RepositoryContext.Set<T>().Update(entity); 
        public async Task Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);
    }
}