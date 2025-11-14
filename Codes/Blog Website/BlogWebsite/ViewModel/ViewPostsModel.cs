using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.ViewModel
{
    public class ViewPostsModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Categories { get; set; }

        
        public IFormFile Image { get; set; }
    }
}
