using LMS.app.DTOs.Commands;
using LMS.app.Services;
using LMS.Domain.MODELS;
using LMS.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LMS.infrastructure.Services
{
    public class BorrowedBookServices : IBorrowedBookServices
    {
        private readonly IBorrowedBookRepos _borrowedBookRepos;
        private readonly IStudentRepos _studentRepos;
        private readonly IBookRepos _bookRepos;

        public BorrowedBookServices(IBorrowedBookRepos borrowedBookRepos, IStudentRepos studentRepos, IBookRepos bookRepos)
        {
            _borrowedBookRepos = borrowedBookRepos;
            _studentRepos = studentRepos;
            _bookRepos = bookRepos;
        }
        public async Task<bool> AddBorrowedBook(CreateBorrowedBookCommand borrowedbook)
        {
            var book = await _bookRepos.GetById(borrowedbook.BookId);
            if (book != null)
            {
                var student = await _studentRepos.GetById(borrowedbook.StudentId);
                if (student != null)
                {
                    var bb = new BorrowedBook(book, student);
                    bb.Date = borrowedbook.Date;
                  return  await _borrowedBookRepos.Add(bb);
                }
                else
                    return false;
                
            }
            else
            {
                return false;
            }                      
        }

        public async Task<bool> DeleteBorrowedBook(int id)
        {
            var bb = await _borrowedBookRepos.GetById(id);
            if (bb != null)
            {
                await _borrowedBookRepos.Delete(id);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public async Task<List<BorrowedBook>> GetAllBorrowedBooks()
        {
            return await _borrowedBookRepos.GetAll();
        }

        public async Task<BorrowedBook> GetBorrowedBookById(int id)
        {
            return await _borrowedBookRepos.GetById(id);
        }

        public async Task<bool> UpdateBorrowedBook(UpdateBorrowedBookCommand borrowedbook)
        {
            var bb = await _borrowedBookRepos.GetById(borrowedbook.Id);
            if (bb != null)
            {
                bb.IsReturned = borrowedbook.IsReturned;
                await _borrowedBookRepos.Update(bb);
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
