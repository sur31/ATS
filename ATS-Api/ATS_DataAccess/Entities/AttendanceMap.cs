using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ATS_DataAccess.Entities
{
    public class AttendanceMap
    {
        public AttendanceMap(EntityTypeBuilder<Attendance> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.TimeStamp);
            entityBuilder.Property(x => x.IsEntryAction);
            /*entityBuilder.HasRequired<User>(s => s.User)
                         .WithMany(x => x.Attendances)
                         .HasForeignKey<int>(x => x.UserId);*/
        }
    }
}