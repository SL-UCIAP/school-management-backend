 
namespace school_management_service.Application.DTOs.Certificate.Request
{
    public class CertificateUpdateRequest
    {
        public string CertificateType { get; set; } = string.Empty;

        public string IssuedBy { get; set; } = string.Empty;

        public string Purpose { get; set; } = string.Empty;

        public bool IsValid { get; set; }

        // HTML content update (main reason this exists)
        public string CertificateHtml { get; set; } = string.Empty;
    }
}