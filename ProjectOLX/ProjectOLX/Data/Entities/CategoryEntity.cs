﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectOLX.Data.Entities;

[Table("tblCategories")]
public class CategoryEntity : BaseEntity<long>
{
    [Required, StringLength(255)]
    public string Name { get; set; } = string.Empty;
    [Required, StringLength(255)]
    public string UrlSlug { get; set; } = string.Empty;

    public int Priority { get; set; }

    [StringLength(200)]
    public string? Image { get; set; }

    [StringLength(40000)]
    public string? Description { get; set; }

    [ForeignKey("Parent")]
    public long? ParentId { get; set; }
    public virtual CategoryEntity Parent { get; set; } = null!;

    public virtual ICollection<CategoryEntity> Children { get; set; } = [];
}
