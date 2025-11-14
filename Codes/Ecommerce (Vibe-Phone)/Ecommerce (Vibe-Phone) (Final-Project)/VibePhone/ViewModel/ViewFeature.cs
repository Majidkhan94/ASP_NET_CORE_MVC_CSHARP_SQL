namespace VibePhone.ViewModel
{
    public class ViewFeature
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "Title cannot exceed 60 characters.")]
        public string Title { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "Description cannot exceed 150 characters.")]
        public string Description { get; set; }

        [Required]
        public IFormFile Image { get; set; }

        [Required]
        public decimal? Price { get; set; }

        // Foreign Key (belongs to one category)
        public int CategoryId { get; set; }

        // Navigation property
        public Category Category { get; set; }
    }
}
