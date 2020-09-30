using System.Collections.Generic;
namespace ATS_DataAccess.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public byte DesignationId { get; set; }
        public string ManagerName { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}