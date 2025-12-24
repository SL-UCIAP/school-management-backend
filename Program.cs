using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using school_management_service.Application.Mappings;
using school_management_service.Application.Services;
using school_management_service.Core.Interfaces.Repositories;
using school_management_service.Core.Interfaces.Services;
using school_management_service.Infrastructure.Data;
using school_management_service.Infrastructure.Repositories;
 


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<AppDbContext>(options =>
 options.UseNpgsql(
    builder.Configuration.GetConnectionString("DefaultConnection")
 )
);
builder.Services.AddScoped<IStudentRepository,StudentRepository>();
builder.Services.AddScoped<IStudentService,StudentService>();
builder.Services.AddAutoMapper(typeof(StudentMappingProfile));
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(
            new JsonStringEnumConverter());
    });
builder.Services.AddScoped<ICertificateRepository,CertificateRepository>();
builder.Services.AddScoped<ICertificateService,CertificateService>();
builder.Services.AddAutoMapper(typeof(CertificateMappingProfile));

builder.Services.AddScoped<ITeacherRepository,TeacherRepository>();
builder.Services.AddScoped<ITeacherService,TeacherService>();
builder.Services.AddAutoMapper(typeof(TeacherMappingProfile));

builder.Services.AddScoped<IClassRepository,ClassRepository>();
builder.Services.AddScoped<IClassService,ClassService>();
builder.Services.AddAutoMapper(typeof(ClassMappingProfile));

builder.Services.AddScoped<IAttendanceRepository,AttendanceRepository>();
builder.Services.AddScoped<IAttendanceService,AttendanceService>();
builder.Services.AddAutoMapper(typeof(AttendanceMappingProfile));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
