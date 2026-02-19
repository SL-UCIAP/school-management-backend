
using Microsoft.AspNetCore.Mvc;
using school_management_service.Application.DTOs.Students.Request;
using school_management_service.Application.DTOs.Students.Response;
using school_management_service.Core.Interfaces.Services;
 

namespace school_management_service.API.Controllers
{     
    [ApiController]
    [Route("api/v1/[controller]")]
    public class StudentController(IStudentService studentService) : ControllerBase
    {
         private readonly IStudentService _studentService=studentService;

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
        [HttpPut("{citizenId:guid}")]
        public async Task<ActionResult<StudentResponse>>UpdateStudent(Guid citizenId,[FromBody]StudentUpdateRequest updateRequest)
        {
            var updated=await _studentService.UpdateStudentAsync(citizenId,updateRequest);
            return Ok(updated);
        }
        [HttpGet("{citizenId:guid}")]
        public async Task<ActionResult<StudentResponse>> GetStudentById(Guid citizenId)
        {
            var student=await _studentService.GetStudentById(citizenId);
            return Ok(student);
        }
        [HttpDelete("{citizenId:guid}")]
        public async Task<IActionResult> DeleteStudent(Guid citizenId)
        {
            var result=await _studentService.DeleteStudentAsync(citizenId);
            if(!result)return NotFound(new{message="Student not found"});
            return NoContent();
        }
    }
}