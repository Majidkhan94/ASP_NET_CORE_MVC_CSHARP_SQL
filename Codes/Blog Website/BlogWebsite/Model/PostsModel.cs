using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.Model
{
    public class PostsModel
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        [Required]
        public string Categories { get; set; }

       
        public string Image { get; set; }
    }
}
