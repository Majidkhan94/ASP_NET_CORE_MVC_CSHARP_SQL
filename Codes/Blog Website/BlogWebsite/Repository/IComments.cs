

namespace BlogWebsite.Repository
{
    public interface IComments
    {
        void AddComment(CommentsModel comment);
        IEnumerable<CommentsModel> GetAllComments();
        IEnumerable<CommentsModel> GetCommentsByPostId(int postId);
        void Delete(int id);
    }
}
