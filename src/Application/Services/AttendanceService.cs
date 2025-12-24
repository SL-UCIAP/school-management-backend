using AutoMapper;
using school_management_service.Application.DTOs.Attendance.Response;
using school_management_service.Application.DTOs.Attendance.Request;
using school_management_service.Core.Interfaces.Repositories;
using school_management_service.Core.Interfaces.Services;
using school_management_service.src.Core.Entities;



namespace school_management_service.Application.Services;
 
public class AttendanceService(IAttendanceRepository attendanceRepository,IMapper mapper) :IAttendanceService
{
    private readonly IAttendanceRepository _attendanceRepository=attendanceRepository;
    private readonly IMapper _mapper=mapper;
   
    public async Task<AttendanceResponse> CreateAttendanceAsync(AttendanceCreateRequest request)
    {
         var attendance = _mapper.Map<Attendance>(request);
         var createAttendance= await _attendanceRepository.CreateAsync(attendance);
         await _attendanceRepository.SaveChangesAsync();
         return _mapper.Map<AttendanceResponse>(createAttendance);
         
    }

    public async Task<AttendanceResponse> UpdateAttendanceAsync(int attendanceId,AttendanceUpdateRequest request)
    {
         var attendance = _mapper.Map<Attendance>(request);
         _mapper.Map(request,attendance);
         await _attendanceRepository.SaveChangesAsync();
         return _mapper.Map<AttendanceResponse>(attendance);
         
    }

    public async Task<bool> DeleteAttendanceAsync(int id)
    {
         var attendance = await _attendanceRepository.GetByIdAsync(id);
         if (attendance == null) return false;
         await _attendanceRepository.DeleteAsync(attendance);
         await _attendanceRepository.SaveChangesAsync();
         return true;
    }

    public async Task<List<AttendanceResponse>> GetMyAttendanceToday(Guid citizenId)
    {
        var attendance=await _attendanceRepository.GetLatestByCitizenAsync(citizenId);
        return _mapper.Map<List<AttendanceResponse>>(attendance);
    }

    public async Task<List<AttendanceResponse>> GetMySubjectAttendance(Guid citizenId, int subjectId)
    {
        var attendance=await _attendanceRepository.GetByCitizenAndSubjectAsync(citizenId, subjectId);
        return _mapper.Map<List<AttendanceResponse>>(attendance);
    }

    public async Task<List<AttendanceResponse>> GetByCitizenAndDateAsync(Guid citizenId, DateTime date)
    {
         var attendance=await _attendanceRepository.GetByCitizenAndDateAsync(citizenId, date);
         return _mapper.Map<List<AttendanceResponse>>(attendance);
    }

    public async Task<List<AttendanceResponse>> GetSubjectAttendance(int subjectId)
    {
         var attendance=await _attendanceRepository.GetBySubjectAsync(subjectId);
         return _mapper.Map<List<AttendanceResponse>>(attendance);
    }
}