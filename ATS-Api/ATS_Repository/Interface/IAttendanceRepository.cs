using ATS_DataAccess.Entities;
using System.Collections.Generic;
using ATS_Repository.Interface;

namespace ATS_Repository.Interface
{
    public interface IAttendanceRepository : IRepository<Attendance>
    {  
        int GetLastUserAttendanceStatus(int userId);
    }  
}