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
    public class BookController : ControllerBase
    {
        IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<IActionResult> GetAll()
        {
            var books = await _bookService.GetAllAsync();
            return Ok(books);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var book = await _bookService.GetByIdAsync(id);
            return Ok(book);
        }

        public async Task<IActionResult> Count()
        {
            int count = await _bookService.CountAsync();
            return Ok(count);

        }
        [ValidationFilter]
        [HttpPost]
        public async Task<IActionResult> Create(BookAddDto bookAddDto)
        {
            await _bookService.AddAsync(bookAddDto);
            return Created(string.Empty, bookAddDto);
        }

        [HttpPut]
        public async Task<IActionResult> Update(BookUpdateDto bookUpdateDto)
        {
            await _bookService.UpdateAsync(bookUpdateDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {

            await _bookService.DeleteAsync(id);
            return NoContent();
        }


    }
}
