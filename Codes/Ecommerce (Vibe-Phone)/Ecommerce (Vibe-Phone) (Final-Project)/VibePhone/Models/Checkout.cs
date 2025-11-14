namespace VibePhone.Models
{
    public class Checkout
    {
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Phone { get; set; }

        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
