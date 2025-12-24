using Microsoft.EntityFrameworkCore;
using school_management_service.Core.Interfaces.Repositories;
using school_management_service.Infrastructure.Data;
using school_management_service.src.Core.Entities;
namespace school_management_service.Infrastructure.Repositories;

public class AttendanceRepository(AppDbContext context) :IAttendanceRepository
{
    private readonly AppDbContext _context=context;
    public async Task<Attendance> CreateAsync(Attendance attendance)
    {
        _context.Attendances.Add(attendance);
        await _context.SaveChangesAsync();
        return attendance;
    }

    public Task DeleteAsync(Attendance attendance)
    {
         _context.Attendances.Remove(attendance);
         return _context.SaveChangesAsync();
    }

    public async Task<List<Attendance>> GetByCitizenAndSubjectAsync(Guid citizenId, int subjectId)
    {
         return await _context.Attendances
             .Include(a=>a.Subject)
             .Where(a=>a.CitizenId==citizenId && a.Subject.SubjectId == subjectId)
             .OrderBy(a=>a.AttendanceDate)
             .ToListAsync();
    }

    public async Task<List<Attendance>> GetBySubjectAsync(int subjectId)
    {
         return await _context.Attendances
             .Include(a=>a.Student)
             .Where(a=>a.SubjectId == subjectId)
             .OrderByDescending(a=>a.AttendanceDate)
             .ToListAsync();
    }

    public async Task<List<Attendance>> GetByCitizenAndDateAsync(Guid citizenId, DateTime date)
    {
         return await _context.Attendances
             .Include(a=>a.Subject)
             .Where(
                 a=>a.CitizenId == citizenId  &&
                 a.AttendanceDate.Date == date.Date)
             .OrderBy(a=>a.PeriodNumber)
             .ToListAsync();
    }

   public async Task<Attendance?> GetByIdAsync(int attendanceId)
    {
         return await _context.Attendances
             .Include(a => a.Student)
             .Include(a => a.Subject)
             .FirstOrDefaultAsync(a => a.AttendanceId == attendanceId);
    }

    public async Task<Attendance?> GetLatestByCitizenAsync(Guid citizenId)
    {
        return await _context.Attendances
            .Include(a => a.Subject)
            .Where(a => a.CitizenId == citizenId)
            .OrderByDescending(a => a.AttendanceDate)
            .FirstOrDefaultAsync();
    }

    public async Task SaveChangesAsync()
    {
         await _context.SaveChangesAsync();
    }
}