using System.Runtime.InteropServices.ComTypes;
using Contracts;
using Contracts.Student;

namespace Services.Student
{
    public class AddStudentService : IAddStudent
    {
        private IUnitOfWork _unitOfWork;
        
        public void Execute()
        {
            // _unitOfWork.StudentRepository
            _unitOfWork.Save();            
        }
    }
}