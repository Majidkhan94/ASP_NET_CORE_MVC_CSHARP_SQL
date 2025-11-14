namespace VibePhone.ViewModel
{
    public class ViewGallery
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public IFormFile ImageGallery { get; set; }

        public string ImagePath { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }
        // Foreign Key
        public int CategoryId { get; set; }

        // Navigation property
        public Category Category { get; set; }
    }
}