using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Infrastructure.Entities;

public class CourseEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(max)")]
    public string ImageUrl { get; set; } = null!;

    [Required]
    [Column(TypeName = "nvarchar(200)")]
    public string Title { get; set; } = null!;

    [Required]
    [Column(TypeName = "nvarchar(200)")]
    public string Author { get; set; } = null!;

    [Required]
    [Column(TypeName = "smallmoney")]
    public decimal Price { get; set; }

    [AllowNull]
    [Column(TypeName = "smallmoney")]
    public decimal? DiscountPrice { get; set; }

    [Required]
    [Column(TypeName = "int")]
    public int Hours { get; set; }

    [Required]
    [Column(TypeName = "bigint")]
    public int TotalBuyers { get; set;} = 0;

    [Required]
    [Column(TypeName = "bigint")]
    public int TotalLikes { get; set; } = 0;

    [Required]
    [Column(TypeName = "bit")]
    public bool BestSeller { get; set; } = false;
}
