using LMS.app.DTOs.Commands;
using LMS.Domain.Constants;
using LMS.Domain.MODELS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace LMS.app.Services
{
    public interface IStudentServices
    {
        Task<List<Student>> GetAllStudent();
        Task<Student> GetStudentById(int id);
        Task<bool> AddStudent(CreateStudentCommand student);
        Task<bool> UpdateStudent(UpdateStudentCommand student);
        Task<bool> DeleteStudent(int id);
    }
}
