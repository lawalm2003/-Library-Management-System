
using LMS.app.DTOs.Commands;
using LMS.app.Services;
using LMS.Domain.MODELS;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookServices _bookservices;

        public BookController(IBookServices bookservices)
        {
            _bookservices = bookservices;
        }

        [HttpGet]        
        public async Task<IActionResult> GetBooks()
        {
            var books = await _bookservices.GetAllBooks();
            return Ok(books);
        }

        [HttpGet("BookId")]
        
        public async Task<IActionResult> GetBook(int id)
        {
            var book = await _bookservices.GetBookById(id);
            if (book != null)
            {
                return Ok(book);               
            }
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] CreateBookCommand book)
        {
            var success = await _bookservices.AddBook(book);
            if (success)
                return Ok();
            else
                return BadRequest();
        }

        [HttpPut("BookId")]
        public async Task<IActionResult> UpdateBook( [FromBody] UpdateBookCommand book)
        {                       
            var success = await _bookservices.UpdateBook(book);
            if (success)
                return Ok();
            else
                return BadRequest();
        }

        [HttpDelete("BookId")]
        public async Task<IActionResult> DeleteBook(int id)
        {            
            var success = await _bookservices.DeleteBook(id);
            if (success)
                return Ok();
            else
                return BadRequest();
        }
    }
}
