using System.Collections;
using System.Collections.Generic;
using Czwiczenia2.Models;

namespace Czwiczenia2.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}