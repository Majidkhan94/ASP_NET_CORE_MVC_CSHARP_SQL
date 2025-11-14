namespace VibePhone.DBConnection
{
    public class DBCONTEXT : DbContext
    {
        public DBCONTEXT(DbContextOptions<DBCONTEXT> options) : base(options) { }
        public DbSet<UserRegistration> UserRegistrations { get; set;}
        public DbSet<AdminRegistration> AdminRegistrations { get; set;}
        public DbSet<Slider> SliderDetails { get; set;}
        public DbSet<Feature> Features { get; set; }
        public DbSet<Category> Categories { get; set;}
        public DbSet<Gallery> ImageGallery { get; set;}
        public DbSet<Blog> Blogs { get; set;}
        public DbSet<Testimonial> Testimonials { get; set;}
        public DbSet<Newsletter> Newsletters { get; set;}
        public DbSet<Contactus> ContactUS { get; set;}
        public DbSet<Checkout> Orders { get; set; }

    }
}
