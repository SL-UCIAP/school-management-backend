using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace school_management_service.src.Core.Entities
{
    public class StudentExtracurricular
    {
            [Key]
            public int Id{get;set;}
            public required string CitizenId { get; set; }
            public Student student{get;set;}

             public int ActivityId { get; set; }
             public ExtracurricularActivity extracurricularActivity{get;set;}

    }
}