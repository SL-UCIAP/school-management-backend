 
using Microsoft.EntityFrameworkCore;
using school_management_service.src.Core.Entities;

namespace school_management_service.Infrastructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Students { get; set; }
            public DbSet<Teacher> Teachers { get; set; }
            public DbSet<ParentGuardian> ParentGuardians { get; set; }

            public DbSet<SchoolClass> SchoolClasses { get; set; }
            public DbSet<Subject> Subjects { get; set; }

            public DbSet<AcademicRecord> AcademicRecords { get; set; }
            public DbSet<BehavioralRecord> BehavioralRecords { get; set; }
            public DbSet<Attendance> Attendances { get; set; }

            public DbSet<StudentActivity> StudentActivities { get; set; }
            public DbSet<ExtracurricularActivity> ExtracurricularActivities { get; set; }
            public DbSet<StudentExtracurricular> StudentExtracurriculars { get; set; }

            public DbSet<Certificate> Certificates { get; set; }

            public DbSet<ConsentManagement> ConsentManagements { get; set; }
            public DbSet<AccessLog> AccessLogs { get; set; }
         
        
    }
}