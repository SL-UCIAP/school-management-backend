using AutoMapper;
using school_management_service.Application.DTOs.Teacher.Request;
using school_management_service.Application.DTOs.Teacher.Response;
using school_management_service.src.Core.Entities;

namespace school_management_service.Application.Mappings;

public class TeacherMappingProfile : Profile
{
    public  TeacherMappingProfile()
    {
        CreateMap<TeacherCreateRequest, Teacher>()
            .ForMember(dest => dest.BehavioralRecords, opt => opt.Ignore())
            .ForMember(dest => dest.SchoolClasses, opt => opt.Ignore())
            .ForMember(dest => dest.ExtracurricularActivities, opt => opt.Ignore());
        CreateMap<TeacherUpdateRequest, Teacher>()
            .ForMember(dest => dest.BehavioralRecords, opt => opt.Ignore())
            .ForMember(dest => dest.SchoolClasses, opt => opt.Ignore())
            .ForMember(dest => dest.ExtracurricularActivities, opt => opt.Ignore());
        CreateMap<Teacher, TeacherResponse>();
        

    }
}