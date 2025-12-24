using AutoMapper;
using school_management_service.Application.DTOs.Attendance.Request;
using school_management_service.Application.DTOs.Attendance.Response;
using school_management_service.src.Core.Entities;

namespace school_management_service.Application.Mappings;

public class AttendanceMappingProfile : Profile
{
    public AttendanceMappingProfile()
    {
        CreateMap<Attendance, AttendanceResponse>()
            .ForMember(dest=>dest.StudentName,
                opt=>opt
                    .MapFrom(src=>src.Student.FirstName+""+src.Student.LastName))
            .ForMember(
                dest => dest.SubjectName,
                opt => opt
                    .MapFrom(src => src.Subject.SubjectName)
            );
            
        CreateMap<AttendanceCreateRequest, Attendance>();
        CreateMap<AttendanceUpdateRequest, Attendance>();
        
    }
}