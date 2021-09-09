using System;
using Contracts;
using Contracts.Courses;
using Contracts.Student;
using EF.Course;
using EF.Student;

namespace EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private SchoolDbContext _context;

        public UnitOfWork(SchoolDbContext context)
        {
            _context = context;
        }

        public ICourseRepository CourseRepository
        {
            get => new CourseRepository(_context);
            set => throw new Exception();
        }

        public IStudentRepository StudentRepository
        {
            get => new StudentRepository(_context);
            set => throw new Exception();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }
}