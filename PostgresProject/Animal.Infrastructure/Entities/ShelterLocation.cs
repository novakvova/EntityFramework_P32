using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animal.Infrastructure.Entities
{
    /// <summary>
    /// Філії притулків
    /// </summary>
    [Table("tbl_shelter_locations")]
    public class ShelterLocation
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string  Name { get; set; } = string.Empty;
        [Required]
        public string Adress { get; set; } = string.Empty;
        [StringLength(20)]
        public string? Phone { get; set; }
    }
}
