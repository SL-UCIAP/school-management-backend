 
using school_management_service.Application.DTOs.Students.Request;
using school_management_service.Application.DTOs.Students.Response;
namespace school_management_service.Core.Interfaces.Services
{
    public interface IStudentService
    {
        Task<List<StudentResponse>>GetStudentsAsync();
        Task<StudentResponse>CreateStudentAsync(StudentCreateRequest createRequest);
        Task<StudentResponse>UpdateStudentAsync(Guid citizenId,StudentUpdateRequest updateRequest);
        Task<StudentResponse> GetStudentById(Guid citizenId);
        Task<bool> DeleteStudentAsync(Guid citizenId);
    }
}