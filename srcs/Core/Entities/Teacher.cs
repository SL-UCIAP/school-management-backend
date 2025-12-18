using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school_management_service.src.Core.Entities
{
    public class Teacher
    {
        
    // PRIMARY KEY
    public int TeacherId { get; set; }

    // UNIQUE KEY
    public required string TeacherCode { get; set; }     // e.g., "TCH101"

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required string Email { get; set; }

    public required string PhoneNumber { get; set; }

    public required string Department { get; set; }      // e.g., "Mathematics", "Science"

    public required string Qualification { get; set; }   // e.g., "BSc in Physics"

    public DateTime JoiningDate { get; set; }

    public bool IsActive { get; set; }               // true if currently active
   
    public List<SchoolClass> SchoolClasses{get;set;}


    public List<BehavioralRecord> BehavioralRecords{get;set;}

    public List<ExtracurricularActivity>ExtracurricularActivities{get;set;}
   
    }
}