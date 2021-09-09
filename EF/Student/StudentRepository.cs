using Contracts.Student;

namespace EF.Student
{
    public class StudentRepository : IStudentRepository
    {
        private SchoolDbContext _context;

        public StudentRepository(SchoolDbContext context)
        {
            _context = context;
        }
    }
}