using Microsoft.EntityFrameworkCore;
using school_management_service.Core.Interfaces.Repositories;
using school_management_service.Infrastructure.Data;
using school_management_service.src.Core.Entities;


namespace school_management_service.Infrastructure.Repositories
{
    public class TeacherRepository(AppDbContext context)  :ITeacherRepository
    {
        private readonly  AppDbContext  _context=context;
        
        public async Task<Teacher> CreateAsync(Teacher teacher)
        {
             _context.Teachers.Add(teacher);
             await _context.SaveChangesAsync();
             return teacher;
        }
      
        public async Task<bool> DeleteAsync(Teacher teacher)
        {
            _context.Teachers.Remove(teacher);
             await _context.SaveChangesAsync();
             return true;
        }

        public async Task SaveChangesAsync()
        {
           await _context.SaveChangesAsync();
        }

        public async Task<List<Teacher>> GetTeachersAsync()
        {
             var result=await _context.Teachers.ToListAsync();
             return result;
        }

        public async Task<Teacher?> GetByTeacherCode(string teacherCode)
        {
             return await _context.Teachers
                .FirstOrDefaultAsync(s=>s.TeacherCode==teacherCode);
        }
    }
}