using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Animal.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Animal.Infractructure.Entities;
[Table("tblAppointments")]
public class AppointmentEntity
{
    [Key] 
    public int Id { get; set; }

    [Required, ForeignKey("Animal")] 
    public int AnimalId { get; set; }
    [Required] 
    public DateTime Date { get; set; }
    public string? Description { get; set; }
    public AnimalEntity? Animal { get; set; } = null!;
}