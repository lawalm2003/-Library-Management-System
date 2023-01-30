using LMS.Domain.MODELS;
using LMS.Domain.Repositories;
using LMS.Persistence.EF_Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Persistence.Repositories
{
    public class StudentRepos : BaseRepo<Student>, IStudentRepos
    {
        public StudentRepos(LMSContext context) : base(context)
        {
                
        }
    }
    
}
