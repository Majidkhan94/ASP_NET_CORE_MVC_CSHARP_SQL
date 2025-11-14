using System.IO;

namespace VibePhone.Controllers
{
    
    public class SliderController : Controller
    {
        public readonly ISliderRepo _SliderRepo;
        private readonly IMapper _Mapper;
        private readonly DBCONTEXT _DBCONTEXT;

        public SliderController(ISliderRepo SliderRepo, IMapper iMapping, DBCONTEXT dBCONTEXT)
        {
            _SliderRepo = SliderRepo;
            _Mapper = iMapping;
            _DBCONTEXT = dBCONTEXT;
        }

        //  ====================================================================
        //                                SliderAdd
        //    ====================================================================

        [HttpGet("AddSlider")]
        public IActionResult SliderAdd()
        {
            ViewBag.CategoryList = new SelectList(_DBCONTEXT.Categories, "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost("AddSlider")]
        public IActionResult SliderAdd(ViewSlider model)
        {
            if (model.Image != null)
            {
                _SliderRepo.AddSlider(model);
                return RedirectToAction("Index", "Dashboard");
            }
            ViewBag.CategoryList = new SelectList(_DBCONTEXT.Categories, "CategoryId", "CategoryName");
            return View(model);
        }


        //  ====================================================================
        //                                SliderUpdate
        //    ====================================================================

        [HttpGet("UpdateSlider")]
        public IActionResult SliderUpdate(int id)
        {
            var data = _SliderRepo.GetSliderById(id);
            if (data == null) return NotFound();
            var viewModel = _Mapper.Map<ViewSlider>(data);
            ViewBag.CategoryList = new SelectList(_DBCONTEXT.Categories, "CategoryId", "CategoryName", viewModel.CategoryId);
            return View(viewModel);
        }


        [HttpPost("UpdateSlider")]
        public IActionResult SliderUpdate(ViewSlider Update)
        {
            if (Update.Image != null)
            {
                _SliderRepo.UpdateSlider(Update);
                return RedirectToAction("Index", "Dashboard");
            }
            ViewBag.CategoryList = new SelectList(_DBCONTEXT.Categories, "CategoryId", "CategoryName");
            return View(Update);
        }


        //  ====================================================================
        //                                SliderDelete
        //    ====================================================================

        [HttpGet("SliderDelete/{id}")]
        public IActionResult SliderDelete(int id)
        {
            var find = _SliderRepo.GetSliderById(id);
            if (find == null)
                return NotFound();
            return View(find);
        }

        [HttpPost]
        public IActionResult SliderDeleteConfirmed(int id)
        {
            _SliderRepo.DeleteSlider(id);
            return RedirectToAction("Index", "Dashboard");

        }

        //  ====================================================================
        //                                Single Product
        //    ====================================================================

        [HttpGet]
        public IActionResult SingleProduct(int id)
        {
            var product = _SliderRepo.GetSliderById(id);
            if (product == null) return NotFound();

            var vm = _Mapper.Map<ViewSlider>(product);
            ViewData["ImagePath"] = product.Image;
            return View(vm);
        }




    }
}
