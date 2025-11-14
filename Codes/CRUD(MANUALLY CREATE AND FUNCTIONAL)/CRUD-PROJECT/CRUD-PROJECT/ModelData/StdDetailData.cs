

namespace CRUD_PROJECT.ModelData
{
    public class StdDetailData : DbContext
    {
        public StdDetailData(DbContextOptions<StdDetailData> options) : base(options)
        {
        }

        public DbSet<StdDetail> StdDetails {  get; set; }


    }
}
