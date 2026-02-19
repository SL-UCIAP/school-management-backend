
namespace school_management_service.Application.DTOs.Certificate.Request
{
    public class CertificateCreateRequest
    {
        public string CertificateType { get; set; } = string.Empty;
        public string CertificateNumber { get; set; } = string.Empty;
        public string IssuedBy { get; set; } = string.Empty;
        public string Purpose { get; set; } = string.Empty;
        public string VerificationCode { get; set; } = string.Empty;
        public string CertificateHtml { get; set; } = string.Empty;
        public Guid CitizenId { get; set; }
    }
}