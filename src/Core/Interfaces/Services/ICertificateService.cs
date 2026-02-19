using school_management_service.Application.DTOs.Certificate.Request;
using school_management_service.Application.DTOs.Certificate.Response;

namespace school_management_service.Core.Interfaces.Services
{
    public interface ICertificateService
    {
        Task<CertificateResponse> CreateAsync(CertificateCreateRequest createRequest);
        Task<CertificateResponse> UpdateAsync(string certificateNumber,CertificateUpdateRequest updateRequest);
        Task <bool>DeleteAsync(string certificateNumber);
        Task<List<CertificateResponse>>GetCertificatesAsync();


    }
}