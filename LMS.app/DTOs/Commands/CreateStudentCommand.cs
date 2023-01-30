using LMS.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.app.DTOs.Commands
{
    public class CreateStudentCommand
    {
        public CreateStudentCommand(string firstName, string lastName, string matNo, string phoneNo,
             string email)
        {
            FirstName = firstName;
            LastName = lastName;
            MatNo = matNo;
            PhoneNo = phoneNo;
            Email = email;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MatNo { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
    }
}
