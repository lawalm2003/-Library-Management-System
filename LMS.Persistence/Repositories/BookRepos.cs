using LMS.Domain.MODELS;
using LMS.Domain.Repositories;
using LMS.Persistence.EF_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMS.Persistence.Repositories
{
    public class BookRepos : BaseRepo<Book>, IBookRepos
    {
        public BookRepos(LMSContext context) : base(context)
        {
        }
    }
}
