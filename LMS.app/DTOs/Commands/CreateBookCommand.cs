using LMS.Domain.Constants;
using LMS.Domain.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.app.DTOs.Commands
{
    public class CreateBookCommand
    {
        public CreateBookCommand(string isbn, string title, string category/*, Departments department*/)
        {
            ISBN = isbn;
            Title = title;
            Category = category;
            //Department = department;
        }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        //public Departments Department { get; set; }
        public int TotalQuantity { get; set; }
        public int AvailableQuantity { get; set; }
    }
}
