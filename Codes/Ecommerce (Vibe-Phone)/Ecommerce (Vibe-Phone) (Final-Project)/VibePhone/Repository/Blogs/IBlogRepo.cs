namespace VibePhone.Repository.Blogs
{
    public interface IBlogRepo
    {
        List<Blog> GetAllBlog();
        Blog GetBlogById(int id);
        Blog AddBlog(ViewBlog AddBlog);
        Blog UpdateBlog(ViewBlog UpdateBlog);
        Blog DeleteBlog(int id);
    }
}
