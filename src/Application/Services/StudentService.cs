 
using AutoMapper;
using school_management_service.Application.DTOs.Students.Request;
using school_management_service.Application.DTOs.Students.Response;
using school_management_service.Core.Interfaces.Repositories;
using school_management_service.Core.Interfaces.Services;
using school_management_service.src.Core.Entities;
 
 

namespace school_management_service.Application.Services
{
    public class StudentService(IMapper mapper,IStudentRepository studentRepo) : IStudentService
    {
        private readonly IMapper _mapper=mapper;
        private readonly IStudentRepository _studentRepo=studentRepo;

        public async Task<StudentResponse> CreateStudentAsync(StudentCreateRequest createRequest)
        {
             var studentEntity= _mapper.Map<Student>(createRequest);
             var createdStudent=await _studentRepo.AddAsync(studentEntity);
             await  _studentRepo.SaveChangesAsync();
             return  _mapper.Map<StudentResponse>(createdStudent);
        }

        public async Task<bool> DeleteStudentAsync(Guid citizenId)
        {
             var student=await _studentRepo.GetByCitizenIdAsync(citizenId);
             if(student==null) return false;
             await _studentRepo.DeleteAsync(student);
             await _studentRepo.SaveChangesAsync();
             return true;     
        }

        public async Task<StudentResponse> GetStudentById(Guid citizenId)
        {
            var student= await _studentRepo.GetByCitizenIdAsync(citizenId);
               return _mapper.Map<StudentResponse>(student);
        }

        public async Task<List<StudentResponse>> GetStudentsAsync()
        {
            var students=await _studentRepo.GetAllAsync();
            return  _mapper.Map<List<StudentResponse>>(students);
        }

        public async Task<StudentResponse> UpdateStudentAsync(Guid citizenId,StudentUpdateRequest updateRequest)
        {
           var student= await _studentRepo.GetByCitizenIdAsync(citizenId) ?? throw new KeyNotFoundException("Student not found");
           _mapper.Map(updateRequest,student);
           student.UpdatedAt=DateTime.UtcNow;
           await _studentRepo.SaveChangesAsync();
           return _mapper.Map<StudentResponse>(student);
        } 
    }

}