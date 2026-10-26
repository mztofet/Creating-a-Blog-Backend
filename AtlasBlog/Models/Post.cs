using System.ComponentModel.DataAnnotations;

namespace AtlasBlog.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string PostText { get; set; } = string.Empty;

        public DateTime PostDate { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public int BlogId { get; set; }

        public Blog? Blog { get; set; }

        public ICollection<Comment> Comments { get; set; }
            = new List<Comment>();
    }
}