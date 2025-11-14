namespace VibePhone.Controllers
{
    public class FrontController : Controller
    {
        public readonly ISliderRepo _SliderRepo;
        public readonly IFeatureRepo _IFeatureRepo;
        public readonly ICategoryRepo _ICategoryRepo;
        public readonly IGalleryRepo _IGalleryRepo;
        public readonly IBlogRepo _IBlogRepo;
        public readonly ITestimonialRepo _ITestimonialRepo;
        public readonly INewslettersRepo _INewslettersRepo;

        public FrontController(ISliderRepo sliderRepo, IFeatureRepo featureRepo, ICategoryRepo categoryRepo,
            IGalleryRepo galleryRepo, IBlogRepo blogRepo, ITestimonialRepo testimonialRepo,
            INewslettersRepo newslettersRepo)

        {
            _SliderRepo = sliderRepo;
            _IFeatureRepo = featureRepo;
            _ICategoryRepo = categoryRepo;
            _IGalleryRepo = galleryRepo;
            _IBlogRepo = blogRepo;
            _ITestimonialRepo = testimonialRepo;
            _INewslettersRepo = newslettersRepo;
        }


        public IActionResult HomePage()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");

            var vm = new ViewDashboard
            {
                Slider = _SliderRepo.GetAllSlider(),
                Feature = _IFeatureRepo.GetAllFeature(),
                Category = _ICategoryRepo.GetAllCategories(),
                Gallery = _IGalleryRepo.GetAllGallery(),
                Blog = _IBlogRepo.GetAllBlog(),
                Testimonial = _ITestimonialRepo.GetAllTestimonials(),
                Newsletter = _INewslettersRepo.GetAllNewsletter()
            };

            return View(vm);
        }
            
            
        
        [Route("AboutUs")]
        public IActionResult AboutUs() => View();

        [Route("Products")]
        public IActionResult Products()
        {
            var vm = new ViewDashboard
            {
                Gallery = _IGalleryRepo.GetAllGallery()
            };

            return View(vm);
        }

        [Route("Sony")]
        public IActionResult Sony()
        {
            var vm = new ViewDashboard
            {
                Gallery = _IGalleryRepo
                    .GetAllGallery()
                    .Where(g => g.Category.CategoryName == "Sony")
                    .ToList()
            };

            return View(vm);
        }

        [Route("Apple")]
        public IActionResult Apple()
        {
            var vm = new ViewDashboard
            {
                Gallery = _IGalleryRepo
                    .GetAllGallery()
                    .Where(g => g.Category.CategoryName == "Apple")
                    .ToList()
            };

            return View(vm);
        }

        [Route("Bose")]
        public IActionResult Bose()
        {
            var vm = new ViewDashboard
            {
                Gallery = _IGalleryRepo
                    .GetAllGallery()
                    .Where(g => g.Category.CategoryName == "Bose")
                    .ToList()
            };

            return View(vm);
        }

        [Route("Sennheiser")]
        public IActionResult Sennheiser()
        {
            var vm = new ViewDashboard
            {
                Gallery = _IGalleryRepo
                    .GetAllGallery()
                    .Where(g => g.Category.CategoryName == "Sennheiser")
                    .ToList()
            };

            return View(vm);
        }

        [Route("Blog")]
        public IActionResult Blog()
        {
            var vm = new ViewDashboard
            {
                Blog = _IBlogRepo.GetAllBlog()
            };

            return View(vm);
        }

        [Route("ContactUs")]
        public IActionResult ContactUs() => View();

        [Route("Faqs")]
        public IActionResult Faqs() => View();

        [Route("TermAndCondition")]
        public IActionResult TermAndCondition() => View();

        [Route("PrivacyPolicy")]
        public IActionResult PrivacyPolicy() => View();

    }
}
