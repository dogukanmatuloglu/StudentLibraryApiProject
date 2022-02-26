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
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public StudentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddAsync(StudentAddDto entitiy)
        {
           await _unitOfWork.Students.AddAsync(_mapper.Map<Student>(entitiy));
           await _unitOfWork.SaveAsync();
        }

        public async Task<int> CountAsync(Expression<Func<StudentDto, bool>> predicate)
        {
           return await _unitOfWork.Students.CountAsync();
        }

        public async Task DeleteAsync(int id)
        {
          await  _unitOfWork.Students.DeleteAsync(id);
          await  _unitOfWork.SaveAsync();
        }

        public async Task<IList<StudentDto>> GetAllAsync()
        {
            var students = await _unitOfWork.Students.GetAllAsync(null, s => s.Operations);
            return _mapper.Map<IList<StudentDto>>(students);
        }

        public async Task<StudentDto> GetByIdAsync(int id)
        {
           var student= await _unitOfWork.Students.GetById(id);
            return _mapper.Map<StudentDto>(student);
        }

        public async Task UpdateAsync(StudentUpdateDto entity)
        {
            await _unitOfWork.Students.UpdateAsync(_mapper.Map<Student>(entity));

            await _unitOfWork.SaveAsync();
        }
    }
}
