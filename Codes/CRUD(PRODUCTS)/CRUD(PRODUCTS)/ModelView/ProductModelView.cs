
namespace CRUD_PRODUCTS_.ModelView
{
    public class ProductModelView
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
    }
}
