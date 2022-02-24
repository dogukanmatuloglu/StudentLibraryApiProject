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
    public class BookService : IBookService
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public BookService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task AddAsync(BookAddDto entitiy)
        {
            await _unitOfWork.Books.AddAsync(_mapper.Map<Book>(entitiy));
            await _unitOfWork.SaveAsync();
        }

        public async Task<int> CountAsync(Expression<Func<BookDto, bool>> predicate)
        {
            return await _unitOfWork.Books.CountAsync();
        }

        public async Task DeleteAsync(BookDto entity)
        {
            await _unitOfWork.Books.DeleteAsync(_mapper.Map<Book>(entity));
            await _unitOfWork.SaveAsync();
        }

        public async Task<IList<BookDto>> GetAllAsync()
        {
           var books= await _unitOfWork.Books.GetAllAsync(null, a => a.Author);
            return _mapper.Map<IList<BookDto>>(books);
        }

        public async Task<BookDto> GetByIdAsync(int id)
        {
            var book = await _unitOfWork.Books.GetById(id);
                return _mapper.Map<BookDto>(book);
        }

        public async Task UpdateAsync(BookUpdateDto entity)
        {
            await _unitOfWork.Books.UpdateAsync(_mapper.Map<Book>(entity));
            await _unitOfWork.SaveAsync();
        }
    }
}
