using LMS.app.DTOs.Commands;
using LMS.Domain.MODELS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LMS.app.Services
{
    public interface IBookServices
    {
        Task<List<Book>> GetAllBooks();
        Task<Book> GetBookById(int id);
        Task<bool> AddBook(CreateBookCommand book);
        Task<bool> UpdateBook(UpdateBookCommand book);
        Task<bool> DeleteBook(int id);
        
    }
}
