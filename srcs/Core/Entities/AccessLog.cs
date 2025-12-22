using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using school_management_service.srcs.Core.Enums;

namespace school_management_service.src.Core.Entities
{
    public class AccessLog
    {
     // PRIMARY KEY

    [Key]
    public int Id { get; set; }

    public required string RequesterOrganization { get; set; }

    public required string RequesterId { get; set; }

    public required string DataAccessed { get; set; }     // Details of data accessed

    public DateTime AccessTimestamp { get; set; }

    public required string Purpose { get; set; }          // Reason for accessing data

    public AccessStatus AccessStatus { get; set; }      // Enum: Allowed, Denied

    public required string IpAddress { get; set; }        // IPv4 or IPv6
  //  // FOREIGN KEY (links to Student/Citizen)
    public  Guid CitizenId { get; set; }
    [ForeignKey("CitizenId")]
    public Student Student{get;set;}
    }
}