using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using school_management_service.srcs.Application.DTOs.Certificate.Request;
using school_management_service.srcs.Application.DTOs.Certificate.Response;
using school_management_service.srcs.Core.Entities;

namespace school_management_service.srcs.Application.Mappings
{
    public class CertificateMappingProfile :Profile
    {
        public CertificateMappingProfile()
        {
            CreateMap<CertificateCreateRequest,Certificate>();
            CreateMap<Certificate,CertificateResponse>();
        }
    }
}