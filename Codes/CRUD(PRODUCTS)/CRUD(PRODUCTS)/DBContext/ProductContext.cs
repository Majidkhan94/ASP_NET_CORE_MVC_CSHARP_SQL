namespace CRUD_PRODUCTS_.DBContext
{
    public class ProductContext : DbContext
    {
      public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
      public DbSet<ProductModel> Products { get; set; }
    }
}
