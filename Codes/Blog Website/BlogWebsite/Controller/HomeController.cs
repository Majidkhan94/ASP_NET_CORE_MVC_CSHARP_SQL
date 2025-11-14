using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPosts PostCont;
        private readonly IComments CommentsCont;

        public HomeController(IPosts _Posts, IComments _Comments)
        {
            PostCont = _Posts;
            CommentsCont = _Comments;

        }
        public IActionResult Index()
        {
            var vm = new CombinedViewModel
            {
                AllPosts = PostCont.GetAllPosts().OrderByDescending(d => d.ID).ToList(),
                Comments = CommentsCont.GetAllComments().OrderByDescending(c => c.CreatedAt).ToList()
            };

            return View(vm);
        }


        // ------------------ Comments ------------------


        [HttpPost]
        public IActionResult AddComment(int postId, string content)
        {
            if (!string.IsNullOrEmpty(content))
            {
                var comment = new CommentsModel
                {
                    PostId = postId,
                    AuthorName = User.Identity.Name,
                    Content = content,
                    CreatedAt = DateTime.Now
                };


                CommentsCont.AddComment(comment);
            }
            return RedirectToAction("Index", "Home");

        }


        public IActionResult Comments()
        {
            var vm = new CombinedViewModel
            {
                Comments = CommentsCont.GetAllComments()
                   .OrderByDescending(c => c.CreatedAt)
                   .ToList()
            };
            return View(vm);
        }

        public IActionResult Details(int id)
        {
            var post = PostCont.GetByID(id); // ye PostsModel hoga
            var comments = CommentsCont.GetCommentsByPostId(id);

            var vm = new CombinedViewModel
            {
                NewPost = new ViewPostsModel
                {
                    ID = post.ID,  // 🔥 Yeh line zaroori hai
                    Title = post.Title,
                    Description = post.Description,
                    Categories = post.Categories,
                },
                Comments = comments.OrderByDescending(c => c.CreatedAt).ToList()
            };

            return View(vm);
        }

        public IActionResult ShowComments()
        {
            var comments = CommentsCont.GetAllComments(); 
            return View(comments);
        }












    }
}

