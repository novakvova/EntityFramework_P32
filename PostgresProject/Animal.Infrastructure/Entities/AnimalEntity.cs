﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Infrastructure.Entities
{
    [Table("tbl_animals")]
    public class AnimalEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; } = null!;

        [ForeignKey("Specie")]
        public int SpecieId { get; set; }
        public Specie Specie { get; set; } = default!;

        public int Age { get; set; }

        [StringLength(40000)]
        public string Description { get; set; } = string.Empty;
    }
}
