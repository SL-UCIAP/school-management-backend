using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using school_management_service.srcs.Application.DTOs.Certificate.Request;
using school_management_service.srcs.Application.DTOs.Certificate.Response;
using school_management_service.srcs.Core.Entities;
using school_management_service.srcs.Core.Interfaces.Repositories;
using school_management_service.srcs.Core.Interfaces.Services;

namespace school_management_service.srcs.Application.Services
{
     public class CertificateService(ICertificateRepository repo,IMapper mapper) : ICertificateService
    {
        public readonly ICertificateRepository _repo=repo;
        public readonly IMapper _mapper=mapper;
        public async Task<CertificateResponse> CreateAsync(CertificateCreateRequest createRequest)
        {
            if(string.IsNullOrWhiteSpace(createRequest.CertificateHtml))
            {
                throw new Exception("Certificate HTML cannot be empty");
                
            }
            var entity=_mapper.Map<Certificate>(createRequest);
            entity.IssueDate=DateTime.UtcNow;
            entity.IsValid=true;

            var saved=await _repo.CreateAsync(entity);
            return _mapper.Map<CertificateResponse>(saved);
        }
    }
}