using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school_management_service.src.Core.Entities
{
    public class SchoolClass
    {
        // PRIMARY KEY
   [Key]
    public int ClassId { get; set; }

    public required string GradeLevel { get; set; }      // e.g., "10", "11"

    public required string Section { get; set; }         // e.g., "A", "B"

  

    public required string RoomNumber { get; set; }      // e.g., "R101"

    public int AcademicYear { get; set; }       // e.g., 2025

    public int MaxCapacity { get; set; } 

  // FOREIGN KEY (links to Teacher)
    public int ClassTeacherId { get; set; }
    public Teacher teacher{get;set;}

    public List<Student> Students{get;set;}



  



    }
}