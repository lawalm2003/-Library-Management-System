using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.app.DTOs.Queries
{
    public class ReturnedBorrowedBookQuery
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public DateOnly Date { get; set; }
    }
}
