using LMS.app.DTOs.Commands;
using LMS.app.Services;
using LMS.Domain.MODELS;
using LMS.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LMS.infrastructure.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepos _studentRepository;
        public StudentServices(IStudentRepos studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<bool> AddStudent(CreateStudentCommand student)
        {
            var st = new Student(student.FirstName, student.LastName, student.MatNo, student.PhoneNo, student.Email);

            await _studentRepository.Add(st);
            return true;            
        }

        public async Task<bool> DeleteStudent(int id)
        {
            var st = await _studentRepository.GetById(id);
            if (st != null)
            {
                await _studentRepository.Delete(id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<Student>> GetAllStudent()
        {
            return await _studentRepository.GetAll();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _studentRepository.GetById(id);
        }

        public async Task<bool> UpdateStudent(UpdateStudentCommand student)
        {
            var st = await _studentRepository.GetById(student.Id);
            if (st != null)
            {
                st.FirstName = student.FirstName;
                st.LastName = student.LastName;
                st.PhoneNo = student.PhoneNo;
                await _studentRepository.Update(st);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
