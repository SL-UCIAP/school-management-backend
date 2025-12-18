using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school_management_service.src.Core.Entities
{
    public class AcademicRecord
    {
        
    // PRIMARY KEY
    [Key]
    public int Id { get; set; }

    public required string AcademicYear { get; set; }      // e.g., "2025/2026"

    public required string TermSemester { get; set; }      // e.g., "Term 1", "Semester 2"

    public int GradeLevel { get; set; }           // Numeric grade level

    public decimal MarksObtained { get; set; }    // e.g., 75.50

    public decimal TotalMarks { get; set; }       // e.g., 100.00

    public required string LetterGrade { get; set; }       // e.g., "A", "B+"

    public string? TeacherRemarks { get; set; }    // Optional comments

    public DateTime ExamDate { get; set; }        // Date of the exam

    public DateTime CreatedAt { get; set; }       // Timestamp when record created
  
    // FOREIGN KEY (links to Student/Citizen)
    public required string CitizenId { get; set; }
    public Student student {get;set;}
 

    // FOREIGN KEY (links to Subject)
    public int SubjectId { get; set; }
    public Subject subject{get;set;}


  
    }
}