using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using school_management_service.src.Core.Enums;

namespace school_management_service.srcs.Application.DTOs.Students.Response
{
    public class StudentResponse
    {
        public Guid CitizenId { get; set; }
        public int SchoolStudentId { get; set; }

        public string FullName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public string CurrentGradeLevel { get; set; } = string.Empty;
        public string Section { get; set; } = string.Empty;

        public StudentStatus Status { get; set; }
        public int ClassId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}