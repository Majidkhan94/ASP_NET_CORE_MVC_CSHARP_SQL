namespace VibePhone.Controllers
{
    
    public class FeatureController : Controller
    {
        public readonly IFeatureRepo _FeatureRepo;
        private readonly IMapper _Mapper;
        private readonly DBCONTEXT _DBCONTEXT;

        public FeatureController(IFeatureRepo featureRepo, IMapper iMapping, DBCONTEXT dBCONTEXT)
        {
            _FeatureRepo = featureRepo;
            _Mapper = iMapping;
            _DBCONTEXT = dBCONTEXT;
        }

        //  ====================================================================
        //                                FeatureAdd
        //    ====================================================================

        [HttpGet("AddFeature")]
        public IActionResult FeatureAdd()
        {
            ViewBag.CategoryList = new SelectList(_DBCONTEXT.Categories, "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost("AddFeature")]
        public IActionResult FeatureAdd(ViewFeature model)
        {
            if (model.Image != null)
            {
                _FeatureRepo.AddFeature(model);
                return Redirect($"{Url.Action("Index", "Dashboard")}#Feature");
            }
            ViewBag.CategoryList = new SelectList(_DBCONTEXT.Categories, "CategoryId", "CategoryName");
            return View(model);
        }


        //  ====================================================================
        //                                FeatureUpdate
        //    ====================================================================

        [HttpGet("UpdateFeature")]
        public IActionResult FeatureUpdate(int id)
        {
            var data = _FeatureRepo.GetFeatureById(id);
            if (data == null) return NotFound();
            var viewModel = _Mapper.Map<ViewFeature>(data);
            ViewBag.CategoryList = new SelectList(_DBCONTEXT.Categories, "CategoryId", "CategoryName", viewModel.CategoryId);
            return View(viewModel);
        }


        [HttpPost("UpdateFeature")]
        public IActionResult FeatureUpdate(ViewFeature Update)
        {
            if (Update.Image != null)
            {
                _FeatureRepo.UpdateFeature(Update);
                return Redirect($"{Url.Action("Index", "Dashboard")}#Feature");

            }
            ViewBag.CategoryList = new SelectList(_DBCONTEXT.Categories, "CategoryId", "CategoryName");
            return View(Update);
        }


        //  ====================================================================
        //                                FeatureDelete
        //    ====================================================================

        [HttpGet("FeatureDelete/{id}")]
        public IActionResult FeatureDelete(int id)
        {
            var find = _FeatureRepo.GetFeatureById(id);
            if (find == null)
                return NotFound();
            return View(find);
        }

        [HttpPost]
        public IActionResult FeatureDeleteConfirmed(int id)
        {
            _FeatureRepo.DeleteFeature(id);
            return Redirect($"{Url.Action("Index", "Dashboard")}#Feature");


        }

        //  ====================================================================
        //                                Single Product
        //    ====================================================================

        [HttpGet]
        public IActionResult SingleProduct(int id)
        {
            var product = _FeatureRepo.GetFeatureById(id);
            if (product == null) return NotFound();

            var vm = _Mapper.Map<ViewFeature>(product);
            ViewData["ImagePath"] = product.Image;
            return View(vm);
        }
    }
}
