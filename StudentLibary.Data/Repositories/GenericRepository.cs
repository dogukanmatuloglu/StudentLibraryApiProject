using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentLibrary.Core.Repositories;
using StudentLibrary.Data.Contexts;

namespace StudentLibrary.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class
    {
        private readonly StudentLibraryContext _context;
        public GenericRepository(StudentLibraryContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
           await _context.Set<T>().AddAsync(entity);
        }

        public async Task<bool> AnyAsnc(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate=null)
        {
            return await (predicate == null ? _context.Set<T>().CountAsync() : _context.Set<T>().CountAsync(predicate));

        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run( ()=> { _context.Set<T>().Remove(entity); });
        }

        public async Task<IList<T>> GetAllAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate=null, params System.Linq.Expressions.Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();

            if (predicate!=null)
            {
                query = query.Where(predicate);
            }
            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
                
            }

            return await query.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            await Task.Run(() => { _context.Set<T>().Update(entity); });
        }
    }
}
