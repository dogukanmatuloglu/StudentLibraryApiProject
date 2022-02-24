using StudentLibrary.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Core.Services
{
    public interface IStudentService
    {
        Task<StudentDto> GetByIdAsync(int id);
        Task<IList<StudentDto>> GetAllAsync();
        Task AddAsync(StudentAddDto entitiy);
        Task UpdateAsync(StudentUpdateDto entity);
        Task DeleteAsync(StudentDto entity);
        Task<int> CountAsync(Expression<Func<StudentDto, bool>> predicate);
        Task<bool> AnyAsnc(Expression<Func<StudentDto, bool>> predicate);
    }
}
