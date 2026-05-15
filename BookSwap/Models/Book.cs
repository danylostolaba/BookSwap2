using System.ComponentModel.DataAnnotations;

namespace BookSwap.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = "";

        [Required]
        [StringLength(100)]
        public string Author { get; set; } = "";

        [Required]
        public string? Genre { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 20)]
        public string? Description { get; set; }

        [Required]
        public string? Status { get; set; }

        [Required]
        [Url]
        public string? ImageUrl { get; set; }

        public bool IsFeatured { get; set; } = false;
    }
}