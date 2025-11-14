using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.Model
{
    public class Userlogin
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Example@gmial.com")]
        public string Email { get; set; }

        [Required]        
        public string Password { get; set; }

        [Required]
        [Compare("Password" ,ErrorMessage = "Password Not Match")]
        public string ConfirmPassword { get; set; }
        
    }
}
