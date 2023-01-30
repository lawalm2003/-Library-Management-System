using LMS.Domain.MODELS;
using LMS.Domain.Repositories;
using LMS.Persistence.EF_Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Persistence.Repositories
{
    public class BorrowedBookRepos : BaseRepo<BorrowedBook>, IBorrowedBookRepos
    {
        private readonly LMSContext _context;

        public BorrowedBookRepos(LMSContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<List<BorrowedBook>> GetAll()
        {
            return await _context.BorrowedBooks
                .Include(b => b.Book)
                .Include(b => b.Student)
                .ToListAsync();
        }
        public override async Task<BorrowedBook> GetById(int id)
        {
            return await _context.BorrowedBooks
                .Include(b => b.Book)
                .Include(b => b.Student)
                .FirstOrDefaultAsync(b => b.Id == id);
        }
    }
}
