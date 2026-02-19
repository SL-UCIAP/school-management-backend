using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school_management_service.src.Core.Entities
{
    public class SchoolClass
    {
   
   [Key]
    public int ClassId { get; set; }

    public required string GradeLevel { get; set; }      

    public required string Section { get; set; }       

    public required string RoomNumber { get; set; }     

    public int AcademicYear { get; set; }      

    public int MaxCapacity { get; set; } 

    public int TeacherId { get; set; }
    public Teacher Teacher{get;set;}

    public List<Student> Students{get;set;}=new List<Student>();



  



    }
}