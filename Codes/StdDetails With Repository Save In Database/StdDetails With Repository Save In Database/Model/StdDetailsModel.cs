

namespace StdDetails_With_Repository_Save_In_Database.Model
{
    public class StdDetailsModel
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Address { get; set; }
        
        [Required]
        public string Phone { get; set; }
        
    }
}
