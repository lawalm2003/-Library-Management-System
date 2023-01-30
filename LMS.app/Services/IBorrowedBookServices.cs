using LMS.app.DTOs.Commands;
using LMS.Domain.MODELS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LMS.app.Services
{
    public interface IBorrowedBookServices
    {
        Task<List<BorrowedBook>> GetAllBorrowedBooks();
        Task<BorrowedBook> GetBorrowedBookById(int id);
        Task<bool> AddBorrowedBook(CreateBorrowedBookCommand borrowedbook);
        Task<bool> UpdateBorrowedBook(UpdateBorrowedBookCommand borrowedBook);
        Task<bool> DeleteBorrowedBook(int id);       
    }
}
