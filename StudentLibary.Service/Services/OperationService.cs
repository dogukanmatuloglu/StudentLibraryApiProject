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
    public class OperationService : IOperationService
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public OperationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddAsync(OperationAddDto entitiy)
        {
           await _unitOfWork.Operations.AddAsync(_mapper.Map<Operation>(entitiy));
            await _unitOfWork.SaveAsync();
        }

        public async Task<int> CountAsync(Expression<Func<OperationDto, bool>> predicate)
        {
          return await  _unitOfWork.Operations.CountAsync();
        }

        public async Task DeleteAsync(OperationDto entity)
        {
           await _unitOfWork.Operations.DeleteAsync(_mapper.Map<Operation>(entity));
            await _unitOfWork.SaveAsync();
        }

        public async Task<IList<OperationDto>> GetAllAsync()
        {
           var operations= await _unitOfWork.Operations.GetAllAsync(null, x => x.Student);
            return _mapper.Map<IList<OperationDto>>(operations);
        }

        public async Task<OperationDto> GetByIdAsync(int id)
        {
            var operation = await _unitOfWork.Operations.GetById(id);
            return _mapper.Map<OperationDto>(operation);

        }

        public async Task UpdateAsync(OperationUpdateDto entity)
        {
            await _unitOfWork.Operations.UpdateAsync(_mapper.Map<Operation>(entity));
            await _unitOfWork.SaveAsync();
        }
    }
}
