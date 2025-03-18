using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Animal.Infrastructure.Entities;

namespace Animal.Infractructure.Entities;

[Table("tblMedicalRecords")]
public class MedicalRecordEntity
{
    [Key] 
    public int Id { get; set; }

    [Required, ForeignKey("Animal")] 
    public int AnimalId { get; set; }

    [Required] 
    public DateTime VisitDate { get; set; }

    [Required] 
    public string Diagnosis { get; set; } = string.Empty;
    public string? Treatment { get; set; } = string.Empty;

    [Required, StringLength(255)] 
    public string VetName { get; set; } = string.Empty;
    public virtual AnimalEntity Animal { get; set; } = null!;
}