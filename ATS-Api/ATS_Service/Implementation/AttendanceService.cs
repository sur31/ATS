using ATS_DataAccess.Entities;
using ATS_Service.Interface;
using ATS_Repository.Interface;
using ATS_Service.ViewModels;

namespace ATS_Service.Implementation
{
    public class AttendanceService : IAttendanceService
    {
        private IRepository<Attendance> attendanceRepository; 
  
        public AttendanceService(IRepository<Attendance> attendanceRepository)  
        {  
            this.attendanceRepository = attendanceRepository;  
        }  
        public int AddAttendance(AttendanceModel attendance)  
        {  
            return attendanceRepository.Add(new Attendance()
            {
                
            });
        }  

    }
}