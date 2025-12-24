namespace school_management_service.Application.DTOs.Class.Response;

public class ClassResponse
{
    public int ClassId { get; set; }

    public string GradeLevel { get; set; } = string.Empty;
    public string Section { get; set; } = string.Empty;
    public string RoomNumber { get; set; } = string.Empty;

    public int AcademicYear { get; set; }
    public int MaxCapacity { get; set; }
    
    public int TeacherId { get; set; }
    public string TeacherName { get; set; } = string.Empty;
    public int StudentCount { get; set; }
}