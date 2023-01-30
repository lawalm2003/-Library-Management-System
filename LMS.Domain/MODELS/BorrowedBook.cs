using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Domain.MODELS
{
    public class BorrowedBook: ModelBase
    {
        public BorrowedBook(bool isReturned)
        {
            IsReturned = isReturned;
        }
        public BorrowedBook(Book book, Student student)
        {
            Book = book;
            Student = student;
           
        }

        public Book Book { get; set; }
        public Student Student { get; set; }
        public bool IsReturned { get; set; }
        public DateTime Date { get; set; }
    }
}
