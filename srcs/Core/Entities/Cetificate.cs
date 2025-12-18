using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school_management_service.src.Core.Entities
{
    public class Cetificate
    {
        // PRIMARY KEY
    [Key]
    public int CetificateId { get; set; }

    public required string CertificateType { get; set; }

    // UNIQUE KEY
    public required string CertificateNumber { get; set; }

    public DateTime IssueDate { get; set; }

    public required string IssuedBy { get; set; }

    public string Purpose { get; set; }=string.Empty;

    public required string VerificationCode { get; set; }

    public bool IsValid { get; set; }

    // Store digital signature as byte array
    public required byte[] DigitalSignature { get; set; }


    // FOREIGN KEY (links to Student or Citizen)
    public required string CitizenId { get; set; }
    public Student student{get;set;}

    }
}