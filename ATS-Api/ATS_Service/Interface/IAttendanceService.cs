using ATS_Service.ViewModels;
namespace ATS_Service.Interface
{
    public interface IAttendanceService
    {
         int AddAttendance(AttendanceModel attendance);
    }
}