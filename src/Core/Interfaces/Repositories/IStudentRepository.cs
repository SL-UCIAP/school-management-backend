 
using school_management_service.src.Core.Entities;
 

namespace school_management_service.Core.Interfaces.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync();
        Task<Student>AddAsync(Student student);
    
        Task<Student?> GetByCitizenIdAsync(Guid citizenId);
        Task SaveChangesAsync();
        Task DeleteAsync(Student student);
  
    }
}