using StudentLibrary.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Core.Services
{
    public interface IAuthorService
    {
        Task<AuthorDto> GetByIdAsync(int id);
        Task<IList<AuthorDto>> GetAllAsync();
        Task AddAsync(AuthorAddDto entitiy);
        Task UpdateAsync(AuthorUpdateDto entity);
        Task DeleteAsync(AuthorDto entity);
        Task<int> CountAsync(Expression<Func<AuthorDto, bool>> predicate);
        Task<bool> AnyAsnc(Expression<Func<AuthorDto, bool>> predicate);
    }
}
