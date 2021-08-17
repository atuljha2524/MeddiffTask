using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Meddiff_Problem5.Repository
{
    public interface IStudentRepository
    {
        public List<Student> GetAllStudents();
        public void AddStudent(Student student);

        public void DeleteStudent(int rollNumber);
        public Student GetStudent(int rollNumber);
        public void UpdateStudent(Student student);
    }
}
