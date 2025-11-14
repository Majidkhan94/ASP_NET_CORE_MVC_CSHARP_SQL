

namespace CRUD_AUTO_CREATE_AND_FUNCTIONAL_.Model
{
    public class CustomerModel

    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Phone { get; set; }
        
        [Required]
        public string Address { get; set; } 
    }
}
