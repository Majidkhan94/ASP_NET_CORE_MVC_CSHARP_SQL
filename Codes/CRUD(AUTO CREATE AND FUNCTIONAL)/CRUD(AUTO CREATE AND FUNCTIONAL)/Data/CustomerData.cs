

namespace CRUD_AUTO_CREATE_AND_FUNCTIONAL_.Data
{
    public class CustomerData : DbContext
    {
        public CustomerData(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CustomerModel> Customers { get; set; }
    }
}
