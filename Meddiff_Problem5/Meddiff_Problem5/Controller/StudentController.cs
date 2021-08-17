using Models;
using Meddiff_Problem5.Repository;
using Meddiff_Problem5.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;



namespace Meddiff_Problem5.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public static IStudentRepository studentRepository = new StudentRepository();
        StudentService studentService = new StudentService(studentRepository);
        [HttpGet]
        public List<Student> Get()
        {
            return studentService.GetAll();
        }
        [HttpGet("{rollNumber}")]
        public Student Get(int rollNumber)
        {
            return studentService.Find(rollNumber);
        }
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            studentService.Add(student);
        }
        [HttpPut]
        public void Put([FromBody] Student student)
        {
            studentService.Update(student);
        }
        [HttpDelete("{rollNumber}")]
        public void Delete(int rollNumber)
        {
            studentService.Delete(rollNumber);
        }
    }
}
