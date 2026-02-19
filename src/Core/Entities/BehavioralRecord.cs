using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using school_management_service.src.Core.Enums;

namespace school_management_service.src.Core.Entities
{
    public class BehavioralRecord
    {
     // PRIMARY KEY
    [Key]
    public int  Id { get; set; }

    // Enum for type of behavioral record (e.g., Warning, Commendation)
    public BehavioralRecordType RecordType { get; set; }

    public string Description { get; set; } =string.Empty;     // Details of the incident

    public DateTime IncidentDate { get; set; }

    public required string ActionTaken { get; set; }      // Actions taken by the school

    public required string SeverityLevel { get; set; }    // e.g., Low, Medium, High

    public DateTime CreatedAt { get; set; }  

    // FOREIGN KEY (links to Student/Citizen)
    public required Guid CitizenId { get; set; }
    [ForeignKey("CitizenId")]
    public Student Student{get;set;}

    // FOREIGN KEY (links to Teacher who reported)
    public int TeacherId { get; set; }
    public Teacher ReportedBy{get;set;}
    }
}