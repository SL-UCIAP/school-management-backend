using Microsoft.AspNetCore.Mvc;
using school_management_service.Application.DTOs.Class.Request;
using school_management_service.Core.Interfaces.Services;

namespace school_management_service.API.Controllers;
[ApiController]
[Route("api/v1/[controller]")]
public class ClassController(IClassService classService) :ControllerBase
{
    private readonly IClassService _classService=classService;

    [HttpPost]
    public async Task<IActionResult> Create([FromBody]ClassCreateRequest request)
    {
        var classes=await _classService.CreateAsync(request);
        return Ok(classes);
    }
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _classService.DeleteAsync(id);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody]ClassUpdateRequest request)
    {
        var schoolClass= await _classService.UpdateAsync(request);
        return Ok(schoolClass);
    }
 
    [HttpGet]
    public async Task<IActionResult> GetClass(
        [FromQuery] int? classId,
        [FromQuery] int? teacherId)
    {
        if (classId.HasValue && !teacherId.HasValue)
        {
            var schoolClass=await _classService.GetClassAsync(classId.Value);
            return Ok(schoolClass);
        }

        if (teacherId.HasValue && !classId.HasValue)
        {
            var schoolClass =await _classService.GetByTeacherIdAsync(teacherId.Value);
            return Ok(schoolClass);
        }
        if (!classId.HasValue && !teacherId.HasValue)
        {
            var classes=await _classService.GetClassesAsync();
            return Ok(classes);
        }
        return BadRequest(
            "Invalid query combination. " +
            "Use: citizenId  OR  teacherId or without non"
        ); 
    }
    
 
    
    
    
    
}