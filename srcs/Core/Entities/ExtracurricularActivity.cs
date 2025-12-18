using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school_management_service.src.Core.Entities
{
    public class ExtracurricularActivity
    {
        
    // PRIMARY KEY
    [Key]
    public int ActivityId { get; set; }

    public required string ActivityName { get; set; }      // e.g., "Basketball", "Debate Club"

    public required string Category { get; set; }          // e.g., "Sports", "Arts"

    public string Description { get; set; }=string.Empty;    // Optional details about the activity

    // FOREIGN KEY (links to Teacher who coordinates the activity)
    public int CoordinatorId { get; set; } 

    public Teacher teacher{get;set;}

    public List<Student> students{get;set;}
    public List<StudentActivity>StudentActivities{get;set;}
         
    }
}