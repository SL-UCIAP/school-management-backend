using school_management_service.src.Core.Entities;

namespace school_management_service.Core.Interfaces.Repositories;

public interface IAttendanceRepository
{
    Task<Attendance> CreateAsync(Attendance attendance);
    Task DeleteAsync(Attendance attendance);
    Task<List<Attendance>> GetByCitizenAndSubjectAsync(Guid citizenId, int subjectId);
    Task<List<Attendance>> GetBySubjectAsync(int subjectId);
    Task<List<Attendance>> GetByCitizenAndDateAsync(Guid citizenId, DateTime date);
    
    Task<Attendance?> GetByIdAsync(int attendanceId);
    Task<Attendance?> GetLatestByCitizenAsync(Guid citizenId);
    Task SaveChangesAsync();
}