using AutoMapper;
using school_management_service.Application.DTOs.Class.Request;
using school_management_service.Application.DTOs.Class.Response;
using school_management_service.src.Core.Entities;

namespace school_management_service.Application.Mappings;

public class ClassMappingProfile : Profile
{
    public ClassMappingProfile()
    {
        CreateMap<SchoolClass, ClassResponse>();
        CreateMap<ClassCreateRequest, SchoolClass>()
            .ForMember(dest => dest.Students, opt => opt.Ignore());
        CreateMap<ClassUpdateRequest, SchoolClass>()
            .ForMember(dest => dest.Students, opt => opt.Ignore());

    }
}