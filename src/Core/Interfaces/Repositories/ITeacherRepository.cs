using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using school_management_service.src.Core.Entities;

namespace school_management_service.Core.Interfaces.Repositories
{
    public interface ITeacherRepository
    {
        Task<Teacher>CreateAsync(Teacher teacher);
        Task<bool> DeleteAsync(Teacher teacher);
        Task SaveChangesAsync();
        Task<List<Teacher>>GetTeachersAsync();
        Task<Teacher?>GetByTeacherCode(string teacherCode);
    }
}