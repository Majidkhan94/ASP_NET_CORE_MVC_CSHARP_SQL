namespace BlogWebsite.Model
{
    public class AdminPanel
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required]
        [EmailAddress(ErrorMessage = "Example@gmial.com")]
        public string Email { get; set; }[Required]
        [MaxLength(12)]
        public string Password { get; set; }
        
        [Required]
        [Compare("Password", ErrorMessage = "Password Not Match") ]
        public string ConfirmPassword { get; set; }

            
            


    }
}
