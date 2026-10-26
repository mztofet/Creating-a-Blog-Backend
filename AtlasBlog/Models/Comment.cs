using System.ComponentModel.DataAnnotations;

namespace AtlasBlog.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string CommentText { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public bool IsVisible { get; set; } = true;

        public string UserId { get; set; } = string.Empty;

        public int PostId { get; set; }

        public Post? Post { get; set; }
    }
}