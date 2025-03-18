using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Animal.Infrastructure.Entities;

[Table("tblAdopters")]
public class AdopterEntity
{
    [Key] 
    public int Id { get; set; }
    [Required] 
    public string FirstName { get; set; } = string.Empty;
    [Required] 
    public string LastName { get; set; } = string.Empty;
    [StringLength(20), Required] 
    public string PhoneNumber { get; set; } = string.Empty;
    [StringLength(100)] 
    public string? Email { get; set; }
    public string? Address { get; set; }
}
