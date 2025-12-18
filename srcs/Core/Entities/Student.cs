using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;
using school_management_service.src.Core.Enums;

namespace school_management_service.src.Core.Entities
{
    public class Student
    {
       // PRIMARY KEY
    [Key]
    public required string CitizenId { get; set; }

    // UNIQUE KEY
    public required string SchoolStudentId { get; set; }

    public string FirstName { get; set; } =string.Empty;

    public string LastName { get; set; }=string.Empty;

    public DateTime DateOfBirth { get; set; }

    public string Gender { get; set; }=string.Empty;

    public string Address { get; set; }=string.Empty;

    public string PhoneNumber { get; set; }=string.Empty;

    public string Email { get; set; }=string.Empty;

    public DateTime EnrollmentDate { get; set; }

    public string CurrentGradeLevel { get; set; }=string.Empty;

    public string Section { get; set; }=string.Empty;

    public StudentStatus Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

     public int ClassId { get; set; }
     public SchoolClass schoolClass{get;set;}

    public List<ParentGuardian>ParentGuardians{get;set;}
    public List<AcademicRecord>AcademicRecords{get;set;}
    public List<Attendance>Attendances{get;set;}
    public List<BehavioralRecord>BehavioralRecords{get;set;}
    public List<Cetificate>Cetificates{get;set;}

    public List<AccessLog>AccessLogs{get;set;}
    public List<ConsentManagement> ConsentManagements{get;set;}

    public List<ExtracurricularActivity>ExtracurricularActivities{get;set;}
    public List<StudentActivity> StudentActivities{get;set;}

}}