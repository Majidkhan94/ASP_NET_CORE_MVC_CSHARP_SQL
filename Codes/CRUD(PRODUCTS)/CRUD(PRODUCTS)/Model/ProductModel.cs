

namespace CRUD_PRODUCTS_.Model
{
    public class ProductModel
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
       public string Image { get; set; }

    }
}
