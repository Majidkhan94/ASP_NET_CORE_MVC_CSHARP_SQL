
namespace BlogWebsite.Repository
{
    public class CComments : IComments
    {
        private readonly DBCONTEXT CONTEXTREPO;
        public CComments(DBCONTEXT _CONTEXT)
        {
            CONTEXTREPO = _CONTEXT;
            
        }
        public void AddComment(CommentsModel Comment)
        {
            Comment.CreatedAt = DateTime.Now;
            CONTEXTREPO.Comments.Add(Comment);
            CONTEXTREPO.SaveChanges();
        }

        public IEnumerable<CommentsModel> GetAllComments()
        {
            return CONTEXTREPO.Comments.ToList();
        }

        public IEnumerable<CommentsModel> GetCommentsByPostId(int postId)
        {
            return CONTEXTREPO.Comments.Where(c => c.PostId == postId).ToList();
        }
        public void Delete(int id)
        {
            var comment = CONTEXTREPO.Comments.Find(id);
            if (comment != null)
            {
                CONTEXTREPO.Comments.Remove(comment);
                CONTEXTREPO.SaveChanges();
            }
        }

    }
}
