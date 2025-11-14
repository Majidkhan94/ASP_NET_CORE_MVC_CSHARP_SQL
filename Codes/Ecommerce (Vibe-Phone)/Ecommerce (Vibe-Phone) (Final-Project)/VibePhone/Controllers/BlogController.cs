namespace VibePhone.Controllers
{
    public class BlogController : Controller
    {
        public readonly IBlogRepo _BlogRepo;
        private readonly IMapper _Mapper;
        private readonly DBCONTEXT _DBCONTEXT;

        public BlogController(IBlogRepo blogRepo, IMapper iMapping, DBCONTEXT dBCONTEXT)
        {
            _BlogRepo = blogRepo;
            _Mapper = iMapping;
            _DBCONTEXT = dBCONTEXT;
        }

        //  ====================================================================
        //                                BlogAdd
        //  ====================================================================

        [HttpGet("AddBlog")]
        public IActionResult BlogAdd()
        {
            ViewBag.CategoryList = new SelectList(_DBCONTEXT.Categories, "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost("AddBlog")]
        public IActionResult BlogAdd(ViewBlog model)
        {
            if (model.Image != null)
            {
                _BlogRepo.AddBlog(model);
                return Redirect($"{Url.Action("Index", "Dashboard")}#Blog");
            }
            ViewBag.CategoryList = new SelectList(_DBCONTEXT.Categories, "CategoryId", "CategoryName");
            return View(model);
        }



        //  ====================================================================
        //                                BlogUpdate
        //  ====================================================================

        [HttpGet("UpdateBlog")]
        public IActionResult BlogUpdate(int id)
        {
            var data = _BlogRepo.GetBlogById(id);
            if (data == null) return NotFound();

            var viewModel = _Mapper.Map<ViewBlog>(data);
            ViewBag.CategoryList = new SelectList(_DBCONTEXT.Categories, "CategoryId", "CategoryName", viewModel.CategoryId);
            return View(viewModel);
        }

        [HttpPost("UpdateBlog")]
        public IActionResult BlogUpdate(ViewBlog update)
        {
            if (update.Image != null)
            {
                _BlogRepo.UpdateBlog(update);
                return Redirect($"{Url.Action("Index", "Dashboard")}#Blog");
            }

            ViewBag.CategoryList = new SelectList(_DBCONTEXT.Categories, "CategoryId", "CategoryName");
            return View(update);
        }



        //  ====================================================================
        //                                BlogDelete
        //  ====================================================================

        [HttpGet("BlogDelete/{id}")]
        public IActionResult BlogDelete(int id)
        {
            var find = _BlogRepo.GetBlogById(id);
            if (find == null)
                return NotFound();

            return View(find);
        }

        [HttpPost]
        public IActionResult BlogDeleteConfirmed(int id)
        {
            _BlogRepo.DeleteBlog(id);
            return Redirect($"{Url.Action("Index", "Dashboard")}#Blog");
        }


    }
}
