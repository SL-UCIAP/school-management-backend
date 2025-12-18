using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school_management_service.src.Core.Entities
{
    public class StudentActivity
    {
         // PRIMARY KEY
         
   [Key]
    public int EnrollmentId { get; set; }

    // FOREIGN KEY (links to Student/Citizen)
    public required string CitizenId { get; set; }
    public Student student{get;set;}

    // FOREIGN KEY (links to ExtracurricularActivity)
    public int ActivityId { get; set; }
    public ExtracurricularActivity extracurricularActivity{get;set;}

    public DateTime EnrollmentDate { get; set; }  // Date student joined the activity

    public required string RolePosition { get; set; }      // e.g., "Captain", "Member"

    public string Achievement { get; set; }=string.Empty;    // Description of achievement

    public DateTime? AchievementDate { get; set; } // Date of the achievement (nullable)
}
    
}