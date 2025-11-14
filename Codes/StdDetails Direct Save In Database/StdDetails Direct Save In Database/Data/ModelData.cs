namespace StdDetails_Direct_Save_In_Database.Data
{
    public class ModelData : DbContext
    {
        public ModelData(DbContextOptions options) : base(options)
        {
        }

        public DbSet<StdDetailsModel> StdDetails {  get; set; }
        
    }
}
