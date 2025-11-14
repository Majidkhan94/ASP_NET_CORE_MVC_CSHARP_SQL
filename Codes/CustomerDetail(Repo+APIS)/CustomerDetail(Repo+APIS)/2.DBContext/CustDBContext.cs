

namespace CustomerDetail_Repo_APIS_._2.DBContext
{
    public class CustDBContext : DbContext
    {
        public CustDBContext(DbContextOptions<CustDBContext> options) : base(options) { }
        public DbSet<CustModel> Customers { get; set; }
    }
}
