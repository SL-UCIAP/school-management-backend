using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school_management_service.src.Core.Entities
{
    public class ConsentManagement
    {
        
    // PRIMARY KEY
    [Key]
    public int  Id { get; set; }

 

    public required string OrganizationName { get; set; }

    public required string OrganizationType { get; set; }      // e.g., "Government", "Private"

    public required string DataCategories { get; set; }        // e.g., "Attendance, AcademicRecord"

    public DateTime ConsentGivenDate { get; set; }

    public DateTime ConsentExpiryDate { get; set; }

    public bool IsActive { get; set; }                // true if consent is currently active
    public required string ConsentToken { get; set; }  

       // FOREIGN KEY (links to Student/Citizen)
    public required string CitizenId { get; set; }
    public Student student{get;set;}
    }
}