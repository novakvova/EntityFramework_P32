using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Animal.Infractructure.Entities;

namespace Animal.Infrastructure.Entities
{
    [Table("EmployeeInfos")]
    public class EmployeeInfo
    {
        [Key, ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [Required, StringLength(200)]
        public string Address { get; set; } = string.Empty;

        [Required, StringLength(20)]
        public string Phone { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Email { get; set; } = string.Empty;

        public EmployeeEntity? Employee { get; set; }
    }
}
