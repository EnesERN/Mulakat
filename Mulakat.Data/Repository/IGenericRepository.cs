using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mulakat.Data.Repository
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> predicate);
        Task<T> GetByIdAsync(object id);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task Insert(T entity);
        Task Insert(IEnumerable<T> entities);
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        void Update(T entity, params Expression<Func<T, object>>[] noUpdateProperties);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        Task SqlCommandCRUDAsync(string command);
    }
}
