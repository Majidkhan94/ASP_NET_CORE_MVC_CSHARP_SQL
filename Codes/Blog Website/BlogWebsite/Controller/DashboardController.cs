

using BlogWebsite.Model;
using System.Linq;

namespace BlogWebsite.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IPosts PostCont;
        private readonly IComments _comments;
       


        public DashboardController(IPosts _Posts, IComments comments)
        {
            PostCont = _Posts;
            _comments = comments;
            
        }

        // ------------------ Index ------------------
        public IActionResult Index()
        {
            var posts = PostCont.GetAllPosts();
            var comments = _comments.GetAllComments().OrderByDescending(c => c.CreatedAt).ToList();

            var vm = new CombinedViewModel
            {
                AllPosts = posts,
                Comments = comments
            };

            // 👇 yahan count nikal kar ViewBag me bhej do
            ViewBag.PostCount = posts.Count();
            ViewBag.CommentCount = comments.Count();

            return View(vm);
        }

        // ------------------ Create (GET) ------------------
        [HttpGet]
        public IActionResult Create()
        {
            var vm = new CombinedViewModel
            {
                NewPost = new ViewPostsModel(),
                AllPosts = PostCont.GetAllPosts()
            };
            return View("Index", vm);
        }

        // ------------------ Create (POST) ------------------
        [HttpPost]
        public IActionResult Create(CombinedViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newPost = new PostsModel
                {
                    Title = model.NewPost.Title,
                    Description = model.NewPost.Description,
                    Categories = model.NewPost.Categories
                };

                PostCont.Create(newPost, model.NewPost);

                return RedirectToAction("Index", "Home");
            }
            model.AllPosts = PostCont.GetAllPosts();
            return View("Index", model);
        }


        // ------------------ All Posts ------------------
        public IActionResult AllPosts()
        {
            var posts = PostCont.GetAllPosts();
            return View(posts);
        }

        // ------------------ Delete ------------------
        public IActionResult Delete(int id)
        {
            PostCont.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteComment(int id)
        {
            _comments.Delete(id);
            return RedirectToAction("Index");
        }




















    }
}
