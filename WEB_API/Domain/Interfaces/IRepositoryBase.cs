using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IRepositoryBase<T>
    {
        Task <List<T>> GetAll();
        Task <List<T>> GetOne(Expression<Func<T, bool>> expression);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
