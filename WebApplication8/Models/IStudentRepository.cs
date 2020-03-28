using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models
{
    //Business Layer interface
    public interface IStudentRepository
    {
        Student GetStudentById(int studentId);

        public void Insert(Student student);

        public void Update(Student student);

        public void Delete(Student student);
    }
}
