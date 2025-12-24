using school_management_service.Application.DTOs.Attendance.Response;
using school_management_service.Application.DTOs.Class.Response;
using school_management_service.Application.DTOs.Attendance.Request;

namespace school_management_service.Core.Interfaces.Services;

public interface IAttendanceService 
{
   
    Task<AttendanceResponse> CreateAttendanceAsync(AttendanceCreateRequest request);
    Task<AttendanceResponse> UpdateAttendanceAsync(int attendanceId,AttendanceUpdateRequest request);
    Task<bool> DeleteAttendanceAsync(int id);
    Task<List<AttendanceResponse>> GetMyAttendanceToday(Guid citizenId);
    Task<List<AttendanceResponse>> GetMySubjectAttendance(Guid citizenId, int subjectId);
    Task<List<AttendanceResponse>> GetByCitizenAndDateAsync(Guid citizenId, DateTime date);
    Task<List<AttendanceResponse>> GetSubjectAttendance(int subjectId);
    
}