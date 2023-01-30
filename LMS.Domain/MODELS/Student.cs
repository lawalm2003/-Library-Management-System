using LMS.Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LMS.Domain.MODELS
{
    public class Student: ModelBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MatNo { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }

        //public List<BorrowedBook> BorrowedBooks { get; set; }

        //public Student()
        //{
        //    BorrowedBooks = new List<BorrowedBook>();
        //}
        public Student()
        {

        }

        public Student(string firstName, string lastName, string matNo, string phoneNo,
            string email)
        {
            FirstName = firstName;
            LastName = lastName;
            MatNo = matNo;
            PhoneNo = phoneNo;
            Email = email;
           // BorrowedBooks = new List<BorrowedBook>();
        }
    }
   
}
