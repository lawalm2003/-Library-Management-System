using LMS.Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LMS.Domain.MODELS
{
    public class Book: ModelBase
    {
        public string ISBN { get; set; }
        public string Title  { get; set; }
        public string Category { get; set; }
        //public Departments Department { get; set; }
        public int TotalQuantity { get; set; }
        public int AvailableQuantity { get; set; }
        public Book()
        {

        }
        //public List<BorrowedBook> BorrowedBooks { get; set; }

        //public Book()
        //{
        //    BorrowedBooks = new List<BorrowedBook>();
        //}
        public Book(string isbn, string title, string category,
           /* Departments department,*/ int totalQuantity, int availableQuantity)
        {
            ISBN = isbn;
            Title = title;
            Category = category;
            //Department = department;
           // BorrowedBooks = new List<BorrowedBook>();
            TotalQuantity = totalQuantity;
            AvailableQuantity = availableQuantity;
        }
    }
}
