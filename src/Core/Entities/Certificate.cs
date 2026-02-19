using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using school_management_service.src.Core.Entities;

namespace school_management_service.src.Core.Entities
{
    public class Certificate
    {
        // PRIMARY KEY
    [Key]
    public int CertificateId { get; set; }

    public required string CertificateType { get; set; }

    // UNIQUE KEY
    public required string CertificateNumber { get; set; }

    public DateTime IssueDate { get; set; }

    public required string IssuedBy { get; set; }

    public string Purpose { get; set; }=string.Empty;

    public required string VerificationCode { get; set; }

    public bool IsValid { get; set; }

    [Column(TypeName = "text")] // IMPORTANT (PostgreSQL)
    public string CertificateHtml { get; set; } = string.Empty;

    // FOREIGN KEY (links to Student or Citizen)
    public required Guid CitizenId { get; set; }
    [ForeignKey("CitizenId")]
    public Student Student{get;set;}
    }
}