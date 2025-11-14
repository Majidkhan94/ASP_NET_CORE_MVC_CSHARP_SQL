
namespace BlogWebsite.Data
{
    public class AdminPanelData : DbContext
    {
        public AdminPanelData(DbContextOptions<AdminPanelData> options) : base(options)
        {
        }

        public DbSet<AdminPanel> AdminPanels { get; set; }
       
    }
}
