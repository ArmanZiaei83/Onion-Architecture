using System;
using Contracts;
using Contracts.Courses;

namespace Services
{
    public class AddCourseService : IAddCourse
    {
        private IUnitOfWork _unitOfWork;
        public void AddCoursesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Execute()
        {
            // _unitOfWork.CourseRepository;
            _unitOfWork.Save();
        }
    }
}