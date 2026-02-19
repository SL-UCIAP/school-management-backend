using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using school_management_service.Application.DTOs.Teacher.Request;
using school_management_service.Application.DTOs.Teacher.Response;
using school_management_service.src.Core.Entities;

namespace school_management_service.Core.Interfaces.Services
{
    public interface ITeacherService
    {
        Task<List<TeacherResponse>> GetTeachersAsync();
        Task<TeacherResponse> GetTeacherAsync(string teacherCode);
        Task<TeacherResponse> AddTeacherAsync(TeacherCreateRequest teacherCreate);
        Task<TeacherResponse> UpdateTeacherAsync(string teacherCode,TeacherUpdateRequest teacherUpdate);
        Task<bool> DeleteTeacherAsync(string teacherCode);
        
    }
}