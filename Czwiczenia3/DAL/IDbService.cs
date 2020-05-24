using System.Collections;
using System.Collections.Generic;
using Czwiczenia3.Models;

namespace Czwiczenia3.DAL
{
    public interface IDbService
    {
        public List<Student> GetStudents();
        public List<Enrollment> GetEnrollments();
        public List<Enrollment> fetchEnrollmentsForStudent(string studentId);
    }
}