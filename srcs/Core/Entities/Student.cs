using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
    public  Guid CitizenId { get; set; }

    // UNIQUE KEY
    public int SchoolStudentId { get; set; }

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
     [ForeignKey("ClassId")]
     public SchoolClass SchoolClass{get;set;}

    public List<ParentGuardian>ParentGuardians{get;set;} =new List<ParentGuardian>();
    public List<AcademicRecord>AcademicRecords{get;set;}=new List<AcademicRecord>();
    public List<Attendance>Attendances{get;set;}=new List<Attendance>();
    public List<BehavioralRecord>BehavioralRecords{get;set;}=new List<BehavioralRecord>();
    public List<Cetificate>Cetificates{get;set;}=new List<Cetificate>();

    public List<AccessLog>AccessLogs{get;set;}=new List<AccessLog>();
    public List<ConsentManagement> ConsentManagements{get;set;}=new List<ConsentManagement>();

    public List<StudentExtracurricular> StudentExtracurriculars { get; set; } = new List<StudentExtracurricular>();
    public List<StudentActivity> StudentActivities{get;set;}=new List<StudentActivity>();

}}