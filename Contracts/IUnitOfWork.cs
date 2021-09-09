using System;
using Contracts.Courses;
using Contracts.Student;

namespace Contracts
{
    public interface IUnitOfWork
    {
        public IStudentRepository StudentRepository { get; set; }
        public ICourseRepository CourseRepository { get; set; }
        void Save();
    }
}