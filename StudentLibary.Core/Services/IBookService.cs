using StudentLibrary.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Core.Services
{
    public interface IBookService
    {
        Task<BookDto> GetByIdAsync(int id);
        Task<IList<BookDto>> GetAllAsync();
        Task AddAsync(BookAddDto entitiy);
        Task UpdateAsync(BookUpdateDto entity);
        Task DeleteAsync(int id);
        Task<int> CountAsync(Expression<Func<BookDto, bool>> predicate=null);
        //Task<bool> AnyAsnc(Expression<Func<BookDto, bool>> predicate);
    }
}
