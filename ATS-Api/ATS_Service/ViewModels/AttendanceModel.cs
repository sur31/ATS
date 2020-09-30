namespace ATS_Service.ViewModels
{
    public class AttendanceModel
    {
        public DateTime TimeStamp { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public byte DesignationId { get; set; }
        public string ManagerName { get; set; }

    }
}