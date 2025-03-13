using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animal.Infrastructure.Entities
{
    [Table("tbl_animals")]
    public class AnimalEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = null!;        
        
        /// <summary>
        /// Порода тварини
        /// </summary>
        [StringLength(100)]
        public string? Breed { get; set; } = null;

        public DateOnly? ArrivalDate { get; set; }

        public string? Gender { get; set; }

        [ForeignKey("Specie")]
        public int SpecieId { get; set; }

        public Specie Specie { get; set; } = default!;

        [ForeignKey("ShelterLocation")]
        public int? ShelterLocationId { get; set; }

        public ShelterLocation? ShelterLocation { get; set; } 

        public int Age { get; set; }

        [StringLength(40000)]
        public string Description { get; set; } = string.Empty;
    }
}
