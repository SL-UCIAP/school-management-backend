using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace school_management_service.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SubjectCode = table.Column<string>(type: "text", nullable: false),
                    SubjectName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Credits = table.Column<int>(type: "integer", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TeacherCode = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Department = table.Column<string>(type: "text", nullable: false),
                    Qualification = table.Column<string>(type: "text", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "ExtracurricularActivities",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ActivityName = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CoordinatorId = table.Column<int>(type: "integer", nullable: false),
                    TeacherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtracurricularActivities", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_ExtracurricularActivities_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolClasses",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GradeLevel = table.Column<string>(type: "text", nullable: false),
                    Section = table.Column<string>(type: "text", nullable: false),
                    RoomNumber = table.Column<string>(type: "text", nullable: false),
                    AcademicYear = table.Column<int>(type: "integer", nullable: false),
                    MaxCapacity = table.Column<int>(type: "integer", nullable: false),
                    ClassTeacherId = table.Column<int>(type: "integer", nullable: false),
                    TeacherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolClasses", x => x.ClassId);
                    table.ForeignKey(
                        name: "FK_SchoolClasses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    CitizenId = table.Column<string>(type: "text", nullable: false),
                    SchoolStudentId = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CurrentGradeLevel = table.Column<string>(type: "text", nullable: false),
                    Section = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ClassId = table.Column<int>(type: "integer", nullable: false),
                    schoolClassClassId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.CitizenId);
                    table.ForeignKey(
                        name: "FK_Students_SchoolClasses_schoolClassClassId",
                        column: x => x.schoolClassClassId,
                        principalTable: "SchoolClasses",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcademicRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AcademicYear = table.Column<string>(type: "text", nullable: false),
                    TermSemester = table.Column<string>(type: "text", nullable: false),
                    GradeLevel = table.Column<int>(type: "integer", nullable: false),
                    MarksObtained = table.Column<decimal>(type: "numeric", nullable: false),
                    TotalMarks = table.Column<decimal>(type: "numeric", nullable: false),
                    LetterGrade = table.Column<string>(type: "text", nullable: false),
                    TeacherRemarks = table.Column<string>(type: "text", nullable: true),
                    ExamDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CitizenId = table.Column<string>(type: "text", nullable: false),
                    studentCitizenId = table.Column<string>(type: "text", nullable: false),
                    SubjectId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcademicRecords_Students_studentCitizenId",
                        column: x => x.studentCitizenId,
                        principalTable: "Students",
                        principalColumn: "CitizenId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcademicRecords_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccessLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RequesterOrganization = table.Column<string>(type: "text", nullable: false),
                    RequesterId = table.Column<string>(type: "text", nullable: false),
                    DataAccessed = table.Column<string>(type: "text", nullable: false),
                    AccessTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Purpose = table.Column<string>(type: "text", nullable: false),
                    IpAddress = table.Column<string>(type: "text", nullable: false),
                    CitizenId = table.Column<string>(type: "text", nullable: false),
                    studentCitizenId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccessLogs_Students_studentCitizenId",
                        column: x => x.studentCitizenId,
                        principalTable: "Students",
                        principalColumn: "CitizenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AttendanceDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    PeriodNumber = table.Column<int>(type: "integer", nullable: false),
                    MarkedBy = table.Column<string>(type: "text", nullable: false),
                    MarkedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CitizenId = table.Column<string>(type: "text", nullable: false),
                    studentCitizenId = table.Column<string>(type: "text", nullable: false),
                    SubjectId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.AttendanceId);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_studentCitizenId",
                        column: x => x.studentCitizenId,
                        principalTable: "Students",
                        principalColumn: "CitizenId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BehavioralRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RecordType = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IncidentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ActionTaken = table.Column<string>(type: "text", nullable: false),
                    SeverityLevel = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CitizenId = table.Column<string>(type: "text", nullable: false),
                    studentCitizenId = table.Column<string>(type: "text", nullable: false),
                    ReportedBy = table.Column<int>(type: "integer", nullable: false),
                    TeacherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BehavioralRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BehavioralRecords_Students_studentCitizenId",
                        column: x => x.studentCitizenId,
                        principalTable: "Students",
                        principalColumn: "CitizenId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BehavioralRecords_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                columns: table => new
                {
                    CetificateId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CertificateType = table.Column<string>(type: "text", nullable: false),
                    CertificateNumber = table.Column<string>(type: "text", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IssuedBy = table.Column<string>(type: "text", nullable: false),
                    Purpose = table.Column<string>(type: "text", nullable: false),
                    VerificationCode = table.Column<string>(type: "text", nullable: false),
                    IsValid = table.Column<bool>(type: "boolean", nullable: false),
                    DigitalSignature = table.Column<byte[]>(type: "bytea", nullable: false),
                    CitizenId = table.Column<string>(type: "text", nullable: false),
                    studentCitizenId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.CetificateId);
                    table.ForeignKey(
                        name: "FK_Certificates_Students_studentCitizenId",
                        column: x => x.studentCitizenId,
                        principalTable: "Students",
                        principalColumn: "CitizenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsentManagements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrganizationName = table.Column<string>(type: "text", nullable: false),
                    OrganizationType = table.Column<string>(type: "text", nullable: false),
                    DataCategories = table.Column<string>(type: "text", nullable: false),
                    ConsentGivenDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ConsentExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    ConsentToken = table.Column<string>(type: "text", nullable: false),
                    CitizenId = table.Column<string>(type: "text", nullable: false),
                    studentCitizenId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsentManagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsentManagements_Students_studentCitizenId",
                        column: x => x.studentCitizenId,
                        principalTable: "Students",
                        principalColumn: "CitizenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExtracurricularActivityStudent",
                columns: table => new
                {
                    ExtracurricularActivitiesActivityId = table.Column<int>(type: "integer", nullable: false),
                    studentsCitizenId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtracurricularActivityStudent", x => new { x.ExtracurricularActivitiesActivityId, x.studentsCitizenId });
                    table.ForeignKey(
                        name: "FK_ExtracurricularActivityStudent_ExtracurricularActivities_Ex~",
                        column: x => x.ExtracurricularActivitiesActivityId,
                        principalTable: "ExtracurricularActivities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExtracurricularActivityStudent_Students_studentsCitizenId",
                        column: x => x.studentsCitizenId,
                        principalTable: "Students",
                        principalColumn: "CitizenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParentGuardians",
                columns: table => new
                {
                    GuardianId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GuardianName = table.Column<string>(type: "text", nullable: false),
                    Relationship = table.Column<string>(type: "text", nullable: false),
                    ContactNumber = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Occupation = table.Column<string>(type: "text", nullable: false),
                    PrimaryContact = table.Column<bool>(type: "boolean", nullable: false),
                    CitizenId = table.Column<string>(type: "text", nullable: false),
                    studentCitizenId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentGuardians", x => x.GuardianId);
                    table.ForeignKey(
                        name: "FK_ParentGuardians_Students_studentCitizenId",
                        column: x => x.studentCitizenId,
                        principalTable: "Students",
                        principalColumn: "CitizenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentActivities",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CitizenId = table.Column<string>(type: "text", nullable: false),
                    studentCitizenId = table.Column<string>(type: "text", nullable: false),
                    ActivityId = table.Column<int>(type: "integer", nullable: false),
                    extracurricularActivityActivityId = table.Column<int>(type: "integer", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RolePosition = table.Column<string>(type: "text", nullable: false),
                    Achievement = table.Column<string>(type: "text", nullable: false),
                    AchievementDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentActivities", x => x.EnrollmentId);
                    table.ForeignKey(
                        name: "FK_StudentActivities_ExtracurricularActivities_extracurricular~",
                        column: x => x.extracurricularActivityActivityId,
                        principalTable: "ExtracurricularActivities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentActivities_Students_studentCitizenId",
                        column: x => x.studentCitizenId,
                        principalTable: "Students",
                        principalColumn: "CitizenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentExtracurriculars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CitizenId = table.Column<string>(type: "text", nullable: false),
                    studentCitizenId = table.Column<string>(type: "text", nullable: false),
                    ActivityId = table.Column<int>(type: "integer", nullable: false),
                    extracurricularActivityActivityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentExtracurriculars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentExtracurriculars_ExtracurricularActivities_extracurr~",
                        column: x => x.extracurricularActivityActivityId,
                        principalTable: "ExtracurricularActivities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentExtracurriculars_Students_studentCitizenId",
                        column: x => x.studentCitizenId,
                        principalTable: "Students",
                        principalColumn: "CitizenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicRecords_studentCitizenId",
                table: "AcademicRecords",
                column: "studentCitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicRecords_SubjectId",
                table: "AcademicRecords",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_AccessLogs_studentCitizenId",
                table: "AccessLogs",
                column: "studentCitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_studentCitizenId",
                table: "Attendances",
                column: "studentCitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_SubjectId",
                table: "Attendances",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BehavioralRecords_studentCitizenId",
                table: "BehavioralRecords",
                column: "studentCitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_BehavioralRecords_TeacherId",
                table: "BehavioralRecords",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_studentCitizenId",
                table: "Certificates",
                column: "studentCitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsentManagements_studentCitizenId",
                table: "ConsentManagements",
                column: "studentCitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtracurricularActivities_TeacherId",
                table: "ExtracurricularActivities",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtracurricularActivityStudent_studentsCitizenId",
                table: "ExtracurricularActivityStudent",
                column: "studentsCitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentGuardians_studentCitizenId",
                table: "ParentGuardians",
                column: "studentCitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolClasses_TeacherId",
                table: "SchoolClasses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentActivities_extracurricularActivityActivityId",
                table: "StudentActivities",
                column: "extracurricularActivityActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentActivities_studentCitizenId",
                table: "StudentActivities",
                column: "studentCitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentExtracurriculars_extracurricularActivityActivityId",
                table: "StudentExtracurriculars",
                column: "extracurricularActivityActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentExtracurriculars_studentCitizenId",
                table: "StudentExtracurriculars",
                column: "studentCitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_schoolClassClassId",
                table: "Students",
                column: "schoolClassClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicRecords");

            migrationBuilder.DropTable(
                name: "AccessLogs");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "BehavioralRecords");

            migrationBuilder.DropTable(
                name: "Certificates");

            migrationBuilder.DropTable(
                name: "ConsentManagements");

            migrationBuilder.DropTable(
                name: "ExtracurricularActivityStudent");

            migrationBuilder.DropTable(
                name: "ParentGuardians");

            migrationBuilder.DropTable(
                name: "StudentActivities");

            migrationBuilder.DropTable(
                name: "StudentExtracurriculars");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "ExtracurricularActivities");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "SchoolClasses");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
