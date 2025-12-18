using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace school_management_service.src.Core.Entities
{
    public class Subject
    {
          // PRIMARY KEY
    public int SubjectId { get; set; }

    // UNIQUE KEY
    public required string SubjectCode { get; set; }   // e.g., "MATH101"

    public required string SubjectName { get; set; }

    public string Description { get; set; }=string.Empty;

    public int Credits { get; set; }

    public required string Category { get; set; }      // e.g., "Science", "Arts"

    public bool IsActive { get; set; }       // t

    public List<AcademicRecord>AcademicRecords{get;set;}

    public List<Attendance>Attendances{get;set;}
    }
}