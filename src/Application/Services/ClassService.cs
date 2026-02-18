using AutoMapper;
using school_management_service.Application.DTOs.Class.Request;
using school_management_service.Application.DTOs.Class.Response;
using school_management_service.Core.Interfaces.Repositories;
using school_management_service.src.Core.Entities;
using school_management_service.Core.Interfaces.Services;

namespace school_management_service.Application.Services;

public class ClassService(IClassRepository classRepository,IMapper mapper) :IClassService
{
    private readonly IClassRepository _classRepository=classRepository;
    private readonly IMapper _mapper=mapper;
    public async Task<List<ClassResponse>?> GetByTeacherIdAsync(int teacherId)
    {
         var classEntities=await _classRepository.GetByTeacherIdAsync(teacherId);
         return _mapper.Map<List<ClassResponse>>(classEntities);
    }

    public async Task<ClassResponse?> GetClassAsync(int classId)
    {
         var classEntity=await _classRepository.GetByClassCode(classId);
         return _mapper.Map<ClassResponse>(classEntity);
    }

    public async Task<List<ClassResponse>?> GetClassesAsync()
    {
         var schoolClasses=await _classRepository.GetClassAsync();
         return _mapper.Map<List<ClassResponse>>(schoolClasses);
    }

    public async Task<ClassResponse> CreateAsync(ClassCreateRequest request)
    {
         var classEntity=_mapper.Map<SchoolClass>(request);
         var createdClass=await _classRepository.CreateAsync(classEntity);
         return _mapper.Map<ClassResponse>(createdClass);
    }

    public async Task<ClassResponse> UpdateAsync(ClassUpdateRequest request)
    {
         var classEntity=_mapper.Map<SchoolClass>(request);
         _mapper.Map(request, classEntity);
         await _classRepository.SaveChangesAsync();
         return _mapper.Map<ClassResponse>(classEntity);
         
    }

    public async Task<bool> DeleteAsync(int classId)
    {
         var schoolClass=await _classRepository.GetByClassCode(classId);
         if (schoolClass == null) return false;
         await _classRepository.DeleteAsync(schoolClass);
         return true;
    }
}