using LMS.Domain.MODELS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Persistence.EF_Core
{
    public class LMSContext : DbContext
    {
        public LMSContext(DbContextOptions<LMSContext> options)
            :base(options)
        {

        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }
    }
    
}
