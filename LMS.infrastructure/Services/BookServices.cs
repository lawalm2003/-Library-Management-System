using LMS.app.DTOs.Commands;
using LMS.app.Services;
using LMS.Domain.MODELS;
using LMS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.infrastructure.Services
{
    public class BookServices : IBookServices
    {
        private readonly IBookRepos _bookRepository;
        public BookServices(IBookRepos bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<bool> AddBook(CreateBookCommand book)
        {
            var bk = new Book(book.ISBN, book.Title, book.Category/*, book.Department*/, book.TotalQuantity, book.AvailableQuantity);

            await _bookRepository.Add(bk);
            return true;
        }

        public async Task<bool> DeleteBook(int id)
        {
            var bk = await _bookRepository.GetById(id);
            if (bk != null)
            {
                await _bookRepository.Delete(id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await _bookRepository.GetAll();
         
        }

        public async Task<Book> GetBookById(int id)
        {
           return await _bookRepository.GetById(id);
        }

        public async Task<bool> UpdateBook(UpdateBookCommand book)
        {
            var bk = await _bookRepository.GetById(book.Id);
            if (bk != null)
            {
                bk.ISBN = book.ISBN;
                bk.Title = book.Title;                
                bk.Category = book.Category;
                bk.TotalQuantity = book.TotalQuantity;
                bk.AvailableQuantity = book.AvailableQuantity;

                await _bookRepository.Update(bk);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
