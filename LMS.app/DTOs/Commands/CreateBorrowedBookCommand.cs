using LMS.Domain.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.app.DTOs.Commands
{
    public class CreateBorrowedBookCommand
    {
        public CreateBorrowedBookCommand(int bookId, int studentId)
        {
            BookId = bookId;
            StudentId = studentId;
        }
        public int BookId { get; set; }
        public int StudentId { get; set; }
        public bool IsReturned { get; set; }
        public DateTime Date { get; set; }
    }
}
