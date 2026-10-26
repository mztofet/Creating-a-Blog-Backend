using System.ComponentModel.DataAnnotations;

namespace AtlasBlog.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string? Subtitle { get; set; }

        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string AuthorId { get; set; } = string.Empty;

        public ICollection<Post> Posts { get; set; }
            = new List<Post>();
    }
}