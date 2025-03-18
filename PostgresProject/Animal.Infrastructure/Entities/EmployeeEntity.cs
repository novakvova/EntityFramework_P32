using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Animal.Infrastructure.Entities;

namespace Animal.Infractructure.Entities;
[Table("tblEmployees")]
public class EmployeeEntity
{
    [Key] 
    public int Id { get; set; }
    [Required] 
    public string FirstName { get; set; }
    [Required] 
    public string LastName { get; set; }
    public string? Position { get; set; }
    [Required] 
    public DateOnly HireDate { get; set; }
    [ForeignKey("ShelterLocation")] 
    public int ShelterLocationId { get; set; }
    public virtual ShelterLocation ShelterLocation { get; set; }
}
