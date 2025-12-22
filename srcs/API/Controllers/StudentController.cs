using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using school_management_service.src.Infrastructure.Data;
using school_management_service.srcs.Application.DTOs.Students.Request;
using school_management_service.srcs.Application.DTOs.Students.Response;
using school_management_service.srcs.Core.Interfaces.Services;

namespace school_management_service.srcs.API.Controllers
{     
    [ApiController]
    [Route("api/v1/[controller]")]
    public class StudentController(IStudentService studentService) : ControllerBase
    {
         public readonly IStudentService _studentService=studentService;

        [HttpGet]
        public async Task<IActionResult> GetAllStudent()
        {
            var student=await _studentService.GetStudentsAsync();
            return Ok(student);
        }
        [HttpPost]
        public async Task<ActionResult<StudentResponse>> CreateStudent([FromBody]StudentCreateRequest createRequest)
        {
            var student=await _studentService.CreateStudentAsync(createRequest);
            return Ok(student);
        }
        [HttpPut("{citizenId}")]
        public async Task<ActionResult<StudentResponse>>UpdateStudent(Guid citizenId,[FromBody]StudentUpdateRequest updateRequest)
        {
            var updated=await _studentService.UpdateStudentAsync(citizenId,updateRequest);
            return Ok(updated);
        }
        [HttpGet("{citizenId}")]
        public async Task<ActionResult<StudentResponse>> GetStudentBYId(Guid citizenId)
        {
            var student=await _studentService.GetStudentById(citizenId);
            return Ok(student);
        }
        [HttpDelete("{citizenId}")]
        public async Task<IActionResult> DeleteStudent(Guid citizenId)
        {
            var result=await _studentService.DeleteStudentAsync(citizenId);
            if(!result)return NotFound(new{message="Student not found"});
            return NoContent();
        }
    }
}