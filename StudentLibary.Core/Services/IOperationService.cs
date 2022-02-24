using StudentLibrary.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Core.Services
{
    public interface IOperationService
    {
        Task<OperationDto> GetByIdAsync(int id);
        Task<IList<OperationDto>> GetAllAsync();
        Task AddAsync(OperationAddDto entitiy);
        Task UpdateAsync(OperationUpdateDto entity);
        Task DeleteAsync(OperationDto entity);
        Task<int> CountAsync(Expression<Func<OperationDto, bool>> predicate);
        Task<bool> AnyAsnc(Expression<Func<OperationDto, bool>> predicate);
    }
}
