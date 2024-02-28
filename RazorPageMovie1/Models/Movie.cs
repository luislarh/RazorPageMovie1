using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageMovie1.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength =3)]
        public String? Title { get; set; }
        [Display (Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[a-zA-Z_][a-zA-Z0-9_]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }
        [Range(1,100)]
        [DataType(DataType.Currency)]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        [RegularExpression(@"^[a-zA-Z_][a-zA-Z0-9_]*$")]
        [StringLength(5)]
        [Required]
        public string? Rating { get; set; }    
    }
}
