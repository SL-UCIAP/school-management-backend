 
using AutoMapper;
using school_management_service.Application.DTOs.Certificate.Request;
using school_management_service.Application.DTOs.Certificate.Response;
using school_management_service.src.Core.Entities;

namespace school_management_service.Application.Mappings
{
    public class CertificateMappingProfile :Profile
    {
        public CertificateMappingProfile()
        {
            CreateMap<CertificateCreateRequest,Certificate>();
            CreateMap<CertificateUpdateRequest,Certificate>();
            CreateMap<Certificate,CertificateResponse>();
        }
    }
}