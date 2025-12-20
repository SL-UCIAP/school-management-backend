using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using school_management_service.src.Core.Entities;
using school_management_service.src.Core.Enums;
using school_management_service.srcs.Application.DTOs.Students.Request;
using school_management_service.srcs.Application.DTOs.Students.Response;

namespace school_management_service.srcs.Application.Mappings
{
    public class StudentMappingProfile :Profile
    {
        public StudentMappingProfile()
        {
            CreateMap<StudentCreateRequest,Student>()
            .ForMember(dest => dest.CitizenId, opt => opt.MapFrom(_ => Guid.NewGuid()))
            .ForMember(dest =>dest.Status,opt =>opt.MapFrom(_=>StudentStatus.ACTIVE))
            .ForMember(dest => dest.CreatedAt,opt =>opt.MapFrom(_ =>DateTime.UtcNow))
            .ForMember(dest => dest.UpdatedAt,opt => opt.MapFrom(_ =>DateTime.UtcNow))
            
            .ForMember(dest =>dest.ParentGuardians,opt => opt.Ignore())
            .ForMember(dest => dest.AcademicRecords, opt => opt.Ignore())
            .ForMember(dest => dest.Attendances, opt => opt.Ignore())
            .ForMember(dest => dest.BehavioralRecords, opt => opt.Ignore())
            .ForMember(dest => dest.Cetificates, opt => opt.Ignore())
            .ForMember(dest => dest.AccessLogs, opt => opt.Ignore())
            .ForMember(dest => dest.ConsentManagements, opt => opt.Ignore())
            .ForMember(dest => dest.StudentExtracurriculars, opt => opt.Ignore())
            .ForMember(dest => dest.StudentActivities, opt => opt.Ignore());

            CreateMap<Student,StudentResponse>()
            .ForMember(dest =>dest.FullName,opt =>opt.MapFrom(src=>$"{src.FirstName}{src.LastName}"));

            CreateMap<StudentUpdateRequest,Student>()
            .ForMember(dest => dest.CitizenId, opt => opt.Ignore())
            .ForMember(dest => dest.SchoolStudentId, opt => opt.Ignore())
            .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())

            .ForMember(dest => dest.SchoolClass, opt => opt.Ignore())
            .ForMember(dest => dest.ParentGuardians, opt => opt.Ignore())
            .ForMember(dest => dest.AcademicRecords, opt => opt.Ignore())
            .ForMember(dest => dest.Attendances, opt => opt.Ignore())
            .ForMember(dest => dest.BehavioralRecords, opt => opt.Ignore())
            .ForMember(dest => dest.Cetificates, opt => opt.Ignore())
            .ForMember(dest => dest.AccessLogs, opt => opt.Ignore())
            .ForMember(dest => dest.ConsentManagements, opt => opt.Ignore())
            .ForMember(dest => dest.StudentExtracurriculars, opt => opt.Ignore())
            .ForMember(dest => dest.StudentActivities, opt => opt.Ignore())
        
            .ForMember(dest => dest.UpdatedAt,
                       opt => opt.MapFrom(_ => DateTime.UtcNow));
         }  
    }
}