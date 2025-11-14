namespace StdDetails_Direct_Save_In_Database.Model
{
    public class StdDetailsModel
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
