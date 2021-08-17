using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Meddiff_Problem5.Repository
{
    public class StudentRepository : IStudentRepository
    {
        List<Student> listOfStudent = new List<Student>();
        public List<Student> GetAllStudents() {
            return listOfStudent;
        }
        public void AddStudent(Student student) {
            listOfStudent.Add(student);
        }
        public void DeleteStudent(int rollNumber) {
            for (int i = 0; i < listOfStudent.Count; i++) {
                if (listOfStudent[i].RollNumber == rollNumber) {
                    listOfStudent.RemoveAt(i);
                    break;
                }
            }
        }
        public Student GetStudent(int rollNumber) {
            Student student = null;
            for (int i = 0; i < listOfStudent.Count; i++)
            {
                if (listOfStudent[i].RollNumber == rollNumber)
                {
                    student = listOfStudent[i];
                }
            }
            return student;
        }
        public void UpdateStudent(Student student) {
            for (int i = 0; i < listOfStudent.Count; i++)
            {
                if (listOfStudent[i].RollNumber == student.RollNumber)
                {
                    listOfStudent[i] = student;
                }
            }
        }
    }
}
