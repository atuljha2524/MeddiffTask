using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meddiff_Problem5.Repository;
using Models;

namespace Meddiff_Problem5.Services
{
    public class StudentService
    {
        public IStudentRepository studentRepository;
        public StudentService(IStudentRepository studentRepository) {
            this.studentRepository = studentRepository;
        }
        public List<Student> GetAll() {
            return studentRepository.GetAllStudents();
        }
        public void Add(Student student) {
            studentRepository.AddStudent(student);
        }
        public void Delete(int rollNumber) {
            studentRepository.DeleteStudent(rollNumber);
        }
        public Student Find(int rollNumber) {
            return studentRepository.GetStudent(rollNumber);
        }
        public void Update(Student student) {
            studentRepository.UpdateStudent(student);
        }
    }
}
