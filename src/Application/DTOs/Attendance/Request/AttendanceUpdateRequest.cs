using school_management_service.src.Core.Enums;

namespace school_management_service.Application.DTOs.Attendance.Request;

public class AttendanceUpdateRequest
{
    public AttendanceStatus Status { get; set; }

    public int PeriodNumber { get; set; }

    public string MarkedBy { get; set; } = string.Empty;
}