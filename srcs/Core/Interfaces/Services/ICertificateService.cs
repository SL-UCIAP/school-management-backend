using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using school_management_service.srcs.Application.DTOs.Certificate.Request;
using school_management_service.srcs.Application.DTOs.Certificate.Response;

namespace school_management_service.srcs.Core.Interfaces.Services
{
    public interface ICertificateService
    {
        Task<CertificateResponse> CreateAsync(CertificateCreateRequest createRequest);

    }
}