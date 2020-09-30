using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ATS_DataAccess.Entities
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.FullName);
            entityBuilder.Property(x => x.Email);
            entityBuilder.Property(x => x.DesignationId);
            entityBuilder.Property(x => x.ManagerName);
            entityBuilder.HasMany(x => x.Attendances).WithOne(b => b.User).HasForeignKey(b => b.UserId);
        }
    }
}