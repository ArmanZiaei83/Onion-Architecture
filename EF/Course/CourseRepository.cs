using Contracts.Courses;

namespace EF.Course
{
    public class CourseRepository : ICourseRepository
    {
        private SchoolDbContext _context;
        public CourseRepository(SchoolDbContext context)
        {
            _context = context;
        }
    }
}