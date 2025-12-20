using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using school_management_service.src.Core.Entities;
using school_management_service.srcs.Application.DTOs.Students.Response;

namespace school_management_service.srcs.Core.Interfaces.Repositories
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