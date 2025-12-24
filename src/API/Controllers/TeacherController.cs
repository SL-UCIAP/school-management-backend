using Microsoft.AspNetCore.Mvc;
using school_management_service.Application.DTOs.Teacher.Request;
using school_management_service.Application.DTOs.Teacher.Response;
using school_management_service.Core.Interfaces.Services;

namespace school_management_service.API.Controllers;
[ApiController]
[Route("api/v1/[controller]")]
public class TeacherController(ITeacherService teacherService) :ControllerBase
{
    
    private readonly ITeacherService _teacherService=teacherService;
    

    [HttpPost]
    public async Task<ActionResult<TeacherResponse>> CreateAsync([FromBody]TeacherCreateRequest request)
    {
        var teacher = await _teacherService.AddTeacherAsync(request);
        return Ok(teacher);
    }

    [HttpPut("{teacherCode}")]
    public async Task<ActionResult<TeacherResponse>> UpdateAsync(string teacherCode,[FromBody] TeacherUpdateRequest request)
    {
        var teacher =await _teacherService.UpdateTeacherAsync(teacherCode,request);
        return Ok(teacher);
    }

    [HttpDelete("{teacherCode}")]
    public async Task<ActionResult<TeacherResponse>> DeleteAsync(string teacherCode)
    {
        var deleted=await _teacherService.DeleteTeacherAsync(teacherCode);
        return Ok(deleted); 
            
    }
    
    [HttpGet("{teacherCode}")]
    public async Task<ActionResult<TeacherResponse>> GetAsync(string teacherCode)
    {
        var teacher=await  _teacherService.GetTeacherAsync(teacherCode);
        return Ok(teacher);
    }

    [HttpGet]
    public async Task<ActionResult<List<TeacherResponse>>> GetAsync()
    {
        var teacherEntity=await _teacherService.GetTeachersAsync();
        return Ok(teacherEntity);
    }
    
}