using AutoMapper;
using StudentLibrary.Core.Dtos;
using StudentLibrary.Core.Models;
using StudentLibrary.Core.Services;
using StudentLibrary.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Service.Services
{
    public class AuthorService : IAuthorService
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public AuthorService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddAsync(AuthorAddDto entitiy)
        {
            await _unitOfWork.Authors.AddAsync(_mapper.Map<Author>(entitiy));
            await _unitOfWork.SaveAsync();
        }

       

        public async Task<int> CountAsync(Expression<Func<AuthorDto, bool>> predicate)
        {
            return await _unitOfWork.Authors.CountAsync();
        }

        public async Task DeleteAsync(AuthorDto entity)
        {
           await _unitOfWork.Authors.DeleteAsync(_mapper.Map<Author>( entity));
           await _unitOfWork.SaveAsync();
        }

        public async Task<IList<AuthorDto>> GetAllAsync()
        {
          var authors=  await  _unitOfWork.Authors.GetAllAsync(null,a=>a.Books);

            return _mapper.Map<IList<AuthorDto>>(authors);
        }

        public async Task<AuthorDto> GetByIdAsync(int id)
        {
            var author = await _unitOfWork.Authors.GetById(id);
            return _mapper.Map<AuthorDto>(author);
        }

        public async Task UpdateAsync(AuthorUpdateDto entity)
        {
            await _unitOfWork.Authors.UpdateAsync(_mapper.Map<Author>(entity));
            await _unitOfWork.SaveAsync();
        }
    }
}
