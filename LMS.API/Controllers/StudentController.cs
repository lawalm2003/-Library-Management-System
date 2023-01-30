using LMS.app.DTOs.Commands;
using LMS.app.Services;
using LMS.Domain.MODELS;
using LMS.infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices _studentServices;

        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        [HttpGet]        
        public async Task<IActionResult> GetStudents()
        {
            var students = await _studentServices.GetAllStudent();
            return Ok(students);
        }

        [HttpGet("StudentId")]
        public async Task<IActionResult> GetStudent(int id)
        {            
            var students = await _studentServices.GetStudentById(id);
            if(students != null)
                return Ok(students);
            else
                return NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] CreateStudentCommand student)
        {
            var success = await _studentServices.AddStudent(student);
            if (success)
                return Ok();
            else
                return BadRequest();
        }

        [HttpPut("StudentId")]
        public async Task<IActionResult> UpdateStudent([FromBody] UpdateStudentCommand student)
        {
            var success = await _studentServices.UpdateStudent(student);

            if (success)
                return Ok();
            else
                return BadRequest();           
        }

        [HttpDelete("StudentId")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var success = await _studentServices.DeleteStudent(id);
            if (success)
                return Ok();
            else
                return BadRequest();
        }
    }
}
