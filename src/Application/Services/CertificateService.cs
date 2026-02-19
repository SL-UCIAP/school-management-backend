 
using AutoMapper;
using school_management_service.Application.DTOs.Certificate.Request;
using school_management_service.Application.DTOs.Certificate.Response;
using school_management_service.Core.Interfaces.Repositories;
using school_management_service.Core.Interfaces.Services;
using school_management_service.src.Core.Entities;
 
 

namespace school_management_service.Application.Services
{
     public class CertificateService(ICertificateRepository repo,IMapper mapper) : ICertificateService
    {
        private readonly ICertificateRepository _repo=repo;
        private readonly IMapper _mapper=mapper;
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
        public async Task<bool> DeleteAsync(string certificateNumber)
        {
             var certificate=await _repo.GetByCertificateNumberIdAsync(certificateNumber);
             if(certificate==null)return false;
             await _repo.DeleteAsync(certificate);
             return true;
        }
        public async Task<List<CertificateResponse>> GetCertificatesAsync()
        {
             var certificates=await _repo.GetAllAsync();
             return _mapper.Map<List<CertificateResponse>>(certificates);
        }

        public async Task<CertificateResponse> UpdateAsync(string certificateNumber,CertificateUpdateRequest updateRequest)
        {
             var certificate=await _repo.GetByCertificateNumberIdAsync(certificateNumber);
             _mapper.Map(updateRequest,certificate);
             await _repo.SaveChangesAsync();
             return _mapper.Map<CertificateResponse>(certificate);
        }
    }
} 