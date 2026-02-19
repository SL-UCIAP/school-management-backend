
namespace school_management_service.Application.DTOs.Students.Request
{
    public class StudentCreateRequest
    { 
        public int SchoolStudentId { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public DateTime EnrollmentDate { get; set; }
        public string CurrentGradeLevel { get; set; } = string.Empty;
        public string Section { get; set; } = string.Empty;

        public int ClassId { get; set; }
    }
}