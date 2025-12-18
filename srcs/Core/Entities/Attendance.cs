using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using school_management_service.src.Core.Enums;

namespace school_management_service.src.Core.Entities
{
    public class Attendance
    {
         // PRIMARY KEY

    [Key]
    public int AttendanceId { get; set; }

    public DateTime AttendanceDate { get; set; }

    // Enum for attendance status (Present, Absent, Late, etc.)
    public AttendanceStatus Status { get; set; }
 
    public int PeriodNumber { get; set; }


    public required string MarkedBy { get; set; }  // Teacher or staff who marked

    public DateTime MarkedAt { get; set; }  // Timestamp when attendance was recorded
   
   
    // FOREIGN KEY (links to Student/Citizen)
    public required string CitizenId { get; set; }
    public Student student{get;set;}


    // FOREIGN KEY (links to Subject)
    public int SubjectId { get; set; }
    public Subject subject{get;set;}

    }
}