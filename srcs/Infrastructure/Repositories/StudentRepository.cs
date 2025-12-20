using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using school_management_service.src.Core.Entities;
using school_management_service.src.Infrastructure.Data;
using school_management_service.srcs.Application.DTOs.Students.Response;
using school_management_service.srcs.Core.Interfaces.Repositories;

namespace school_management_service.srcs.Infrastructure.Repositories
{
    public class StudentRepository(AppDbContext context) :IStudentRepository
    {
        private readonly AppDbContext _cotext = context;

        public async Task<Student> AddAsync(Student student)
        {
             _cotext.Students.Add(student);
             await _cotext.SaveChangesAsync();
             return student;
        }
        public async Task DeleteAsync(Student student)
        {
             _cotext.Students.Remove(student);
             await _cotext.SaveChangesAsync();
        }
        public async Task<List<Student>> GetAllAsync()
        {
            var students=await _cotext.Students.ToListAsync();
            return students;
        }
        public async Task<Student?> GetByCitizenIdAsync(Guid citizenId)
        {
             return await _cotext.Students
                          .FirstOrDefaultAsync(s =>s.CitizenId==citizenId);
        }
        public async Task SaveChangesAsync()
        {
             await _cotext.SaveChangesAsync();
        }
 
    }
}