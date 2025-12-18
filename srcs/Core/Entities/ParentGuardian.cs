using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school_management_service.src.Core.Entities
{
    public class ParentGuardian
    {
        // PRIMARY KEY
    [Key]
    public int GuardianId { get; set; }

    public required string GuardianName { get; set; }

    public required string Relationship { get; set; }  // e.g., Father, Mother, Uncle

    public required string ContactNumber { get; set; }

    public string Email { get; set; } =string.Empty;

    public required string Address { get; set; }

    public string Occupation { get; set; }=string.Empty;

    public bool PrimaryContact { get; set; }  // true if this guardian is the primary contact
   
   // FOREIGN KEY (links to Student/Citizen)
    public required string CitizenId { get; set; }
    public Student student{get;set;}

    }
}