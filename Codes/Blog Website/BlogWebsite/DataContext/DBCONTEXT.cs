using BlogWebsite.Model;

namespace BlogWebsite.DataContext
{
    public class DBCONTEXT : DbContext
    {
        public DBCONTEXT(DbContextOptions<DBCONTEXT> options) : base(options) { }
        public DbSet<Userlogin> Userlogin { get; set; }
        public DbSet<PostsModel> UserPosts { get; set; }
        public DbSet<CommentsModel> Comments { get; set; }
       

    }
}
