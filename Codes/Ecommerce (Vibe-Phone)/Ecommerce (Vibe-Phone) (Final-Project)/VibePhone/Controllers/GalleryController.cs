namespace VibePhone.Controllers
{
    public class GalleryController : Controller
    {
        public readonly IGalleryRepo _GalleryRepo;
        private readonly IMapper _Mapper;
        private readonly DBCONTEXT _DBCONTEXT;

        public GalleryController(IGalleryRepo galleryRepo, IMapper iMapping, DBCONTEXT dBCONTEXT)
        {
            _GalleryRepo = galleryRepo;
            _Mapper = iMapping;
            _DBCONTEXT = dBCONTEXT;
        }

        //  ====================================================================
        //                                GalleryAdd
        //    ====================================================================

        [HttpGet("AddGallery")]
        public IActionResult GalleryAdd()
        {
            ViewBag.Categories = _DBCONTEXT.Categories.ToList();
            return View();
        }

        [HttpPost("AddGallery")]
        public IActionResult GalleryAdd(ViewGallery model)
        {
            if (model.ImageGallery != null)
            {
                _GalleryRepo.AddGallery(model);
                return Redirect($"{Url.Action("Index", "Dashboard")}#Gallery");

            }
            ViewBag.Categories = _DBCONTEXT.Categories.ToList();
            return View(model);
        }


        //  ====================================================================
        //                                GalleryDelete
        //    ====================================================================

        [HttpGet("GalleryDelete/{id}")]
        public IActionResult GalleryDelete(int id)
        {
            var find = _GalleryRepo.GetGalleryById(id);
            if (find == null)
                return NotFound();
            return View(find);
        }

        [HttpPost]
        public IActionResult GalleryDeleteConfirmed(int id)
        {
            _GalleryRepo.DeleteGallery(id);
            return Redirect($"{Url.Action("Index", "Dashboard")}#Gallery");

        }

        //  ====================================================================
        //                                Single Product
        //    ====================================================================

        [HttpGet]
        public IActionResult SingleProduct(int id)
        {
            var product = _GalleryRepo.GetGalleryById(id);
            if (product == null) return NotFound();

            var vm = _Mapper.Map<ViewGallery>(product); // ImagePath automatically filled
            return View(vm);
        }




    }
}
