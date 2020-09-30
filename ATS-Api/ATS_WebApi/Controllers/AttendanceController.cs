using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ATS_Service.Interface;
using ATS_Service.ViewModels;

namespace ATS_WebApi.Controllers
{
   // [ApiController]
   // [Route("[controller]")]
    public class AttendanceController : ApiController
    {
        private readonly ILogger<AttendanceController> _logger;
        private readonly IAttendanceService attendanceService;

        public AttendanceController(ILogger<AttendanceController> logger, IAttendanceService attendanceService)
        {
            _logger = logger;
            this.attendanceService = attendanceService;  
        }

        [Route("api/Add")]
        [HttpPost]
        public IHttpActionResult AddAttendance([FromBody]AttendanceModel attendance)
        {
            var result = attendanceService.AddAttendance(attendance);
            return ToJson(result);
        }
    }
}
