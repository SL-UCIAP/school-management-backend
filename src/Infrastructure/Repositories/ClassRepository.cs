using Microsoft.EntityFrameworkCore;
using school_management_service.Core.Interfaces.Repositories;
using school_management_service.Infrastructure.Data;
using school_management_service.src.Core.Entities;


namespace school_management_service.Infrastructure.Repositories;

public class ClassRepository(AppDbContext context) :IClassRepository
{
    private readonly AppDbContext _context=context;
    public async Task<SchoolClass> CreateAsync(SchoolClass sClass)
    {
        _context.SchoolClasses.Add(sClass);
        await _context.SaveChangesAsync();
        return sClass;
    }

    public async Task DeleteAsync(SchoolClass sClass)
    {
        _context.SchoolClasses.Remove(sClass);
        await _context.SaveChangesAsync();
    }

    public async Task SaveChangesAsync()
    {
         await _context.SaveChangesAsync();
    }

    public async Task<List<SchoolClass>> GetClassAsync()
    {
        return await _context.SchoolClasses.ToListAsync();
    }

    public async Task<SchoolClass?> GetByClassCode(int classId)
    {
         return await _context.SchoolClasses
             .FirstOrDefaultAsync(s=>s.ClassId==classId);
    }

    public async Task<List<SchoolClass>?> GetByTeacherIdAsync(int teacherId)
    {
         return await  _context.SchoolClasses
             .Include(s=>s.Teacher)
             .Where(a=>a.TeacherId==teacherId)
             .ToListAsync();
    }
}