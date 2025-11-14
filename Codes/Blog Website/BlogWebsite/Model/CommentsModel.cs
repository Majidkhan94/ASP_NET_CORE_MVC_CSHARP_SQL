using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.Model
{
    public class CommentsModel
    {
        [Key]
        public int ID { get; set; }
        public string AuthorName { get; set; }   // User ka naam
        public string Content { get; set; }      // Comment text
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Foreign Key
        public int PostId { get; set; }
        public PostsModel Post { get; set; }
    }
}
