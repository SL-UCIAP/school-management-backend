using Microsoft.EntityFrameworkCore;
using school_management_service.Core.Interfaces.Repositories;
using school_management_service.Infrastructure.Data;
using school_management_service.src.Core.Entities;
 


namespace school_management_service.Infrastructure.Repositories
{
    public class StudentRepository(AppDbContext context) :IStudentRepository
    {
        private readonly AppDbContext _context = context;

        public async Task<Student> AddAsync(Student student)
        {
            _context.Students.Add(student);
             await _context.SaveChangesAsync();
             return student;
        }
        public async Task DeleteAsync(Student student)
        {
            _context.Students.Remove(student);
             await _context.SaveChangesAsync();
        }
        public async Task<List<Student>> GetAllAsync()
        {
            return await _context.Students.ToListAsync();
        }
        public async Task<Student?> GetByCitizenIdAsync(Guid citizenId)
        {
             return await _context.Students
                          .FirstOrDefaultAsync(s =>s.CitizenId==citizenId);
        }
        public async Task SaveChangesAsync()
        {
             await _context.SaveChangesAsync();
        }
 
    }
}