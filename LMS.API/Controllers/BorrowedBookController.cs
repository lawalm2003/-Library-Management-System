using LMS.app.DTOs.Commands;
using LMS.app.Services;
using LMS.Domain.MODELS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowedBookController : ControllerBase
    {
        private readonly IBorrowedBookServices _borrowedBook;

        public BorrowedBookController(IBorrowedBookServices borrowedBook)
        {
            _borrowedBook = borrowedBook;
        }

        [HttpGet]        
        public async Task<IActionResult> GetBorrowedBooks()
        {
            var borrowedBook = await _borrowedBook.GetAllBorrowedBooks();
            return Ok(borrowedBook);
        }

        [HttpGet("BorrowedBookId")]
        public async Task<IActionResult> GetBorrowedBook(int id)
        {            
            var borrowedBooks = await _borrowedBook.GetBorrowedBookById(id);

            if (borrowedBooks != null)
            {
                return Ok(borrowedBooks);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AddBorrowedBook([FromBody] CreateBorrowedBookCommand borrowedBook)
        {
            var success = await _borrowedBook.AddBorrowedBook(borrowedBook);
            if (success)
                return Ok();
            else
                return BadRequest();
        }

        [HttpPut("BorrowedBookId")]
        public async Task<IActionResult> UpdateBorrowedBook([FromBody] UpdateBorrowedBookCommand borrowedBook)
        {                     
            var success = await _borrowedBook.UpdateBorrowedBook(borrowedBook);
            if (success)
                return Ok();
            else
                return BadRequest();
        }

        [HttpDelete("BorrowedBookId")]
        public async Task<IActionResult> DeleteBorrowedBook(int id)
        {            
            var success = await _borrowedBook.DeleteBorrowedBook(id);
            if (success)
                return Ok();
            else
            return BadRequest();
        }
    }
}
