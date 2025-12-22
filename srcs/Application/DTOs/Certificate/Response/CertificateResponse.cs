using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school_management_service.srcs.Application.DTOs.Certificate.Response
{
    public class CertificateResponse
    {
        public int CertificateId { get; set; }
        public string CertificateType { get; set; } = string.Empty;
        public string CertificateNumber { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
        public bool IsValid { get; set; }
        public string VerificationCode { get; set; } = string.Empty;
        public string CertificateHtml { get; set; } = string.Empty;
   }
}