using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentLibrary.Core.Dtos;
using StudentLibrary.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLibrary.Api.Controllers
{
    [Route("api/[controller][action]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        IOperationService _operationService;

        public OperationController(IOperationService operationService)
        {
            _operationService = operationService;
        }
        public async Task<IActionResult> GetAll()
        {
            var operations = await _operationService.GetAllAsync();
            return Ok(operations);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var operation = await _operationService.GetByIdAsync(id);
            return Ok(operation);
        }

        

    }
}
