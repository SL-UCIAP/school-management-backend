using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using school_management_service.src.Core.Enums;

namespace school_management_service.srcs.Application.DTOs.Students.Request
{
    public class StudentUpdateRequest
    {
         public string Address { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string CurrentGradeLevel { get; set; } = string.Empty;
        public string Section { get; set; } = string.Empty;

        public StudentStatus Status { get; set; }
        public int ClassId { get; set; }
    }
}