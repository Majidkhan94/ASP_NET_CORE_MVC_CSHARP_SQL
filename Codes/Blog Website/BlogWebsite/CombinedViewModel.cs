using BlogWebsite.Model;

namespace BlogWebsite
{
    public class CombinedViewModel
    {
        public ViewModel.ViewPostsModel NewPost { get; set; } = new ViewModel.ViewPostsModel();
        public List<Model.PostsModel> AllPosts { get; set; } = new List<Model.PostsModel>();

        public List<CommentsModel> Comments { get; set; } = new List<CommentsModel>();

       

    }
}
