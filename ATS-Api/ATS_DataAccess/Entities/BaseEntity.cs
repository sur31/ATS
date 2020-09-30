using System.ComponentModel.DataAnnotations;
namespace ATS_DataAccess.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}