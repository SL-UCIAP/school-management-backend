using school_management_service.src.Core.Enums;

namespace school_management_service.Application.DTOs.Attendance.Response;

public class AttendanceResponse
{
    public int AttendanceId { get; set; }

    public DateTime AttendanceDate { get; set; }

    public AttendanceStatus Status { get; set; }

    public int PeriodNumber { get; set; }

    public string MarkedBy { get; set; } = string.Empty;
    public DateTime MarkedAt { get; set; }

    // Student info (flattened)
    public Guid CitizenId { get; set; }
    public string StudentName { get; set; } = string.Empty;

    // Subject info (flattened)
    public int SubjectId { get; set; }
    public string SubjectName { get; set; } = string.Empty;
}