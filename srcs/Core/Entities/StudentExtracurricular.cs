using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace school_management_service.src.Core.Entities
{
    [PrimaryKey(nameof(CitizenId),nameof(ActivityId))]
    public class StudentExtracurricular
    {
            public required Guid CitizenId { get; set; }
            [ForeignKey("CitizenId")]
            public Student Student{get;set;}

             public int ActivityId { get; set; }
             [ForeignKey("ActivityId")]
             public ExtracurricularActivity Activity{get;set;}

    }
}