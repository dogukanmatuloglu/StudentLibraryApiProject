using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Core.Repositories
{
    public interface IGenericRepository<T> where T:class
    {
        Task<T> GetById(int id);
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null, params Expression<Func<T, object>>[] includeProperties); 
        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate=null);
        Task<bool> AnyAsnc(Expression<Func<T, bool>> predicate);

    }
}
