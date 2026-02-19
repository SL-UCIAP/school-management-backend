using AutoMapper;
using school_management_service.Application.DTOs.Teacher.Request;
using school_management_service.Application.DTOs.Teacher.Response;
using school_management_service.Core.Interfaces.Repositories;
using school_management_service.Core.Interfaces.Services;
using school_management_service.src.Core.Entities;
 
 

namespace school_management_service.Application.Services
{
    public class TeacherService(ITeacherRepository teacherRepository,IMapper mapper) :ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository=teacherRepository;
        private readonly IMapper _mapper=mapper;
        public async Task<List<TeacherResponse>> GetTeachersAsync()
        {
             var teachers=await _teacherRepository.GetTeachersAsync();
             return _mapper.Map<List<TeacherResponse>>(teachers);
            
        }

        public async Task<TeacherResponse> GetTeacherAsync(string teacherCode)
        {
            var teacher=await _teacherRepository.GetByTeacherCode(teacherCode);
            return _mapper.Map<TeacherResponse>(teacher);
        }

        public async Task<TeacherResponse> AddTeacherAsync(TeacherCreateRequest teacherCreate)
        {
             var teacherEntity=_mapper.Map<Teacher>(teacherCreate);
             var teacher=await _teacherRepository.CreateAsync(teacherEntity);
             return _mapper.Map<TeacherResponse>(teacher);
        }

        public async Task<TeacherResponse> UpdateTeacherAsync(string teacherCode,TeacherUpdateRequest teacherUpdate)
        {
            var teacher=await _teacherRepository.GetByTeacherCode(teacherCode);
            _mapper.Map(teacherUpdate,teacher);
             await _teacherRepository.SaveChangesAsync();
            return _mapper.Map<TeacherResponse>(teacher);
            
        }

        public async Task<bool> DeleteTeacherAsync(string  teacherCode)
        {
            var teacher=await _teacherRepository.GetByTeacherCode(teacherCode);
            if (teacher == null)return false;
            return  await _teacherRepository.DeleteAsync(teacher); 
        }
    }
    
 
}