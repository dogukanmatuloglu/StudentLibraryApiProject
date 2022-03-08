using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentLibrary.Api.Filters;
using StudentLibrary.Core.Dtos;
using StudentLibrary.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLibrary.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public async Task<IActionResult> GetAll()
        {
            var students = await _studentService.GetAllAsync();
            return Ok(students);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = await _studentService.GetByIdAsync(id);
            return Ok(student);
        }

        public async Task<IActionResult> Count()
        {
            int count = await _studentService.CountAsync();
            return Ok(count);

        }
        [ValidationFilter]
        [HttpPost]
        public async Task<IActionResult> Create(StudentAddDto studentAddDto)
        {
            await _studentService.AddAsync(studentAddDto);
            return Created(string.Empty, studentAddDto);
        }
        [ValidationFilter]
        [HttpPut]
        public async Task<IActionResult> Update(StudentUpdateDto studentUpdateDto)
        {
            await _studentService.UpdateAsync(studentUpdateDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {

            await _studentService.DeleteAsync(id);
            return NoContent();
        }



    }
}
