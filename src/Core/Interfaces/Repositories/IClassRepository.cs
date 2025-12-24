using school_management_service.src.Core.Entities;

namespace school_management_service.Core.Interfaces.Repositories;

public interface IClassRepository
{
    Task<SchoolClass>CreateAsync(SchoolClass sClass);
    Task DeleteAsync(SchoolClass sClass);
    Task SaveChangesAsync();
    Task<List<SchoolClass>>GetClassAsync();
    Task<SchoolClass?>GetByClassCode(int classId);
    Task<List<SchoolClass>?> GetByTeacherIdAsync(int teacherId);
}