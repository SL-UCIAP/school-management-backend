using school_management_service.Application.DTOs.Class.Request;
using school_management_service.Application.DTOs.Class.Response;
using school_management_service.src.Core.Entities;

namespace school_management_service.Core.Interfaces.Services;

public interface IClassService
{   
    Task<List<ClassResponse>?> GetByTeacherIdAsync(int teacherId);
    Task<ClassResponse?> GetClassAsync(int classId);
    Task<List<ClassResponse>?> GetClassesAsync();
    Task<ClassResponse> CreateAsync(ClassCreateRequest request);
    Task<ClassResponse> UpdateAsync(ClassUpdateRequest request);
    Task<bool> DeleteAsync(int classId);
    




}