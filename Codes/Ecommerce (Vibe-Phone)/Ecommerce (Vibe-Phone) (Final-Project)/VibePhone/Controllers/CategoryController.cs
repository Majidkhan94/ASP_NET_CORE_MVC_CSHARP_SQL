namespace VibePhone.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ICategoryRepo _CategoryRepo;

        public CategoryController(ICategoryRepo categoryRepo)

        {
            _CategoryRepo = categoryRepo;
        }

        //  ====================================================================
        //                                CategoryAdd
        //    ====================================================================

        [HttpGet("AddCategory")]
        public IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost("AddCategory")]
        public IActionResult CategoryAdd(Category model)
        {
            var add = _CategoryRepo.AddCategory(model);
            return Redirect($"{Url.Action("Index", "Dashboard")}#Categories");
        }

        //  ====================================================================
        //                                CategoryUpdate
        //    ====================================================================

        [HttpGet("UpdateCategory")]
        public IActionResult CategoryUpdate(int id)
        {
            var find = _CategoryRepo.GetCategoryById(id);
            if (find == null)
                return NotFound();
            return View(find);
        }

        [HttpPost("UpdateCategory")]
        public IActionResult CategoryUpdate(Category Update)
        {
            var update = _CategoryRepo.UpdateCategory(Update);
            return Redirect($"{Url.Action("Index", "Dashboard")}#Categories");
        }

        //  ====================================================================
        //                                CategoryDelete
        //    ====================================================================

        [HttpGet("CategoryDelete/{id}")]
        public IActionResult CategoryDelete(int Id)
        {
            var find = _CategoryRepo.GetCategoryById(Id);
            if (find == null)
                return NotFound();
            return View(find);
        }

        [HttpPost]
        public IActionResult CategoryDeleteConfirmed(int CategoryId)
        {
            var delete = _CategoryRepo.DeleteCategory(CategoryId);
            return Redirect($"{Url.Action("Index", "Dashboard")}#Categories");

        }

    }
}
