using System;
namespace ATS_DataAccess.Entities
{
    public class Attendance : BaseEntity
    {
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsEntryAction { get; set; }
        public virtual User User { get; set;}
    }
}