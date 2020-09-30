using ATS_DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace ATS_Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)  
        {  
        }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)  
        {  
            base.OnModelCreating(modelBuilder);  
            new UserMap(modelBuilder.Entity<User>());  
            new AttendanceMap(modelBuilder.Entity<Attendance>());  
        }  
    }
}