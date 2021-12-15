using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UasFront.Models;

namespace UasFront.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> GetById(int id);
        Task<Student> Add(Student student);
        Task<Student> Update(int id, Student Student);
        Task Delete (int id);
    }
}