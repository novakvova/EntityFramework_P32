using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Animal.Infrastructure.Entities;

namespace Animal.Infractructure.Entities;
[Table("tblAdoptions")]
public class AdoptionEntity
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("Animal"), Required] 
    public int AnimalId { get; set; }
    [ForeignKey("Adopter"), Required] 
    public int AdopterId { get; set; }
    [Required] 
    public DateTime AdoptedOn { get; set; }
    public virtual AnimalEntity Animal { get; set; }
    public virtual AdopterEntity Adopter { get; set; }
}

/*
   id SERIAL PRIMARY KEY,
   pet_id INT NOT NULL,
   adopter_id INT NOT NULL,
   adoption_date DATE NOT NULL,
   FOREIGN KEY (pet_id) REFERENCES pets(id) ON DELETE CASCADE,
   FOREIGN KEY (adopter_id) REFERENCES adopters(id) ON DELETE CASCADE
*/