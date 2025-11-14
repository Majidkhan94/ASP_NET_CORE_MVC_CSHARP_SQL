using BlogWebsite.ViewModel;

namespace BlogWebsite.Repository
{
    public interface IPosts
    {
        PostsModel Create(PostsModel NewPost, ViewPostsModel ViewModel);
        List<PostsModel> GetAllPosts();
        void Delete(int id);
        PostsModel GetByID(int Id);
        
        
    }
}
