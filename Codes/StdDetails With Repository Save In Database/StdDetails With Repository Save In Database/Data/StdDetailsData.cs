
namespace StdDetails_With_Repository_Save_In_Database.Data
{
    public class StdDetailsData : DbContext
    {
        public StdDetailsData(DbContextOptions<StdDetailsData> options) : base(options)
        {
        }

        public DbSet<StdDetailsModel> stdDetailsModel {  get; set; }
        
    }
}

