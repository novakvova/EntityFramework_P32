using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.SimpleSQLite.Data.Entities
{
    [Table("tbl_categories")]
    public class Category
    {
        [Key] //-- primary key identity
        public Int32 Id { get; set; }
        //Навза є обовязкова і довжина макисум 255 символів
        [Required, StringLength(255)] 
        public string Name { get; set; } = string.Empty;

        [StringLength(40000)]
        public string? Description { get; set; }
    }
}
