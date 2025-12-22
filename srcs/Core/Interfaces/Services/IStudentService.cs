using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using school_management_service.src.Core.Entities;
using school_management_service.srcs.Application.DTOs.Students.Request;
using school_management_service.srcs.Application.DTOs.Students.Response;

namespace school_management_service.srcs.Core.Interfaces.Services
{
    public interface IStudentService
    {
        Task<List<StudentResponse>>GetStudentsAsync();
        Task<StudentResponse>CreateStudentAsync(StudentCreateRequest createRequest);
        Task<StudentResponse>UpdateStudentAsync(Guid citizenId,StudentUpdateRequest updateRequest);
        Task<StudentResponse>GetStudentById(Guid citizenId);
        Task<bool> DeleteStudentAsync(Guid citizenId);
    }
}