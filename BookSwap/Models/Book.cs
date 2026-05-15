using System.ComponentModel.DataAnnotations;

namespace BookSwap.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public string Genre { get; set; }

        [MinLength(10)]
        [MaxLength(300)]
        public string Description { get; set; }

        public string Status { get; set; } = "Available";

        public string ImageUrl { get; set; }

        public bool IsFeatured { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}