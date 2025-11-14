namespace CRUD_PROJECT.Model
{
    public class StdDetail
    {
        [Key]
        public int ID { get; set; }
        
        [Required(ErrorMessage ="Enter Your Name") ]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Enter Your Address")]
        public string Address { get; set; }
        
        [Required(ErrorMessage = "Enter Your Phone Number")]
        public string Phone { get; set; }
        
    }
}
