using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models
{
    //It is the business layer
    public class TestStudentRepository : IStudentRepository
    {
        private List<Student> _students;

        public TestStudentRepository()
        {
            _students = new List<Student>()
            {
               new Student() { StudentId = 101, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" },
               new Student() { StudentId = 102, Name = "Smith", Branch = "ETC", Section = "B", Gender = "Male" },
               new Student() { StudentId = 103, Name = "David", Branch = "CSE", Section = "A", Gender = "Male" },
               new Student() { StudentId = 104, Name = "Sara", Branch = "CSE", Section = "A", Gender = "Female" },
            };
        }

        public void Delete(Student student)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentById(int studentId)
        {
            return _students.FirstOrDefault(c => c.StudentId == studentId);
        }

        public void Insert(Student student)
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
