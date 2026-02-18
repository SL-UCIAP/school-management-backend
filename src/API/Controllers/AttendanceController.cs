using Microsoft.AspNetCore.Mvc;
using school_management_service.Application.DTOs.Attendance.Request;
using school_management_service.Application.DTOs.Attendance.Response;
using school_management_service.Core.Interfaces.Services;
 

namespace school_management_service.API.Controllers;
[ApiController]
[Route("api/v1/[controller]")]
public class AttendanceController(IAttendanceService attendanceService) :ControllerBase
{
    private readonly IAttendanceService _attendanceService=attendanceService;

    [HttpPost]
    public async Task<ActionResult<AttendanceResponse>> MarkAsync([FromBody] AttendanceCreateRequest attendance)
    {
        var marked = await _attendanceService.CreateAttendanceAsync(attendance);
        return Ok(marked);
    }

    [HttpPatch("{attendanceId}")]
    public async Task<ActionResult<AttendanceResponse>> UpdateAsync(int attendanceId,[FromBody] AttendanceUpdateRequest attendance)
    {
        var updated=await _attendanceService.UpdateAttendanceAsync(attendanceId,attendance);
        return Ok(updated);
    }

    [HttpDelete("{attendanceId}")]
    public async Task<IActionResult> DeleteAsync(int attendanceId)
    {
       var deleted= await _attendanceService.DeleteAttendanceAsync(attendanceId);
       return Ok(deleted);
    }

    [HttpGet("{citizenId:guid}")]
    public async Task<ActionResult<AttendanceResponse>> GetByIdAsync(Guid citizenId)
    {
        var attendance=await _attendanceService.GetMyAttendanceToday(citizenId);
        return Ok(attendance);
    }

    [HttpGet]
    public async Task<ActionResult<AttendanceResponse>> GetAttendance(
        [FromQuery] Guid? citizenId,
        [FromQuery] int? subjectId,
        [FromQuery] DateTime? date)
    {
        if (citizenId.HasValue && subjectId.HasValue && !date.HasValue)
        {
            var results=await _attendanceService
                .GetMySubjectAttendance(citizenId.Value, subjectId.Value);
            return Ok(results);
        }

        if (citizenId.HasValue && date.HasValue && !subjectId.HasValue)
        {
            var results=await  _attendanceService
                .GetByCitizenAndDateAsync(citizenId.Value, date.Value);
            return Ok(results);
        }

        if (subjectId.HasValue && !date.HasValue && !citizenId.HasValue)
        {
            var results=await   _attendanceService
                .GetSubjectAttendance(subjectId.Value);
            return Ok(results);
        }
        return BadRequest(
            "Invalid query combination. " +
            "Use: citizenId+subjectId OR citizenId+date OR subjectId only."
            );
    } 
        
        
}