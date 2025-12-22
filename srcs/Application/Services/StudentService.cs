using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using school_management_service.src.Core.Entities;
using school_management_service.src.Infrastructure.Data;
using school_management_service.srcs.Application.DTOs.Students.Request;
using school_management_service.srcs.Application.DTOs.Students.Response;
using school_management_service.srcs.Core.Interfaces.Repositories;
using school_management_service.srcs.Core.Interfaces.Services;

namespace school_management_service.srcs.Application.Services
{
    public class StudentService(IMapper mapper,IStudentRepository studentRepo) : IStudentService
    {
        public readonly IMapper _mapper=mapper;
        public readonly IStudentRepository _studentRepo=studentRepo;

        public async Task<StudentResponse> CreateStudentAsync(StudentCreateRequest createRequest)
        {
             var studentEntity= _mapper.Map<Student>(createRequest);
             var createdStudent=await _studentRepo.AddAsync(studentEntity);
             return  _mapper.Map<StudentResponse>(createdStudent);
        }

        public async Task<bool> DeleteStudentAsync(Guid citizenId)
        {
             var student=await _studentRepo.GetByCitizenIdAsync(citizenId);
             if(student==null) return false;
             await _studentRepo.DeleteAsync(student);
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