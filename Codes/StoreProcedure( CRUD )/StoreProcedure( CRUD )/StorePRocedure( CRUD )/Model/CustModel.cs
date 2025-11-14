

namespace StorePRocedure__CRUD__.Model
{
    public class CustModel
    {
        [Key]
        public int id {  get; set; }
        [Required]
        public string Name {  get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
