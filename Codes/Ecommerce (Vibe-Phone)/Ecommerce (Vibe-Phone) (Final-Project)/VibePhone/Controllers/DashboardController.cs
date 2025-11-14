using Microsoft.EntityFrameworkCore.Metadata.Internal;
using VibePhone.Models;
using VibePhone.Repository.Contact;

namespace VibePhone.Controllers
{
    public class DashboardController : Controller
    {

        public readonly ISliderRepo _SliderRepo;
        public readonly IFeatureRepo _IFeatureRepo;
        public readonly ICategoryRepo _ICategoryRepo;
        public readonly IGalleryRepo _IGalleryRepo;
        public readonly IBlogRepo _IBlogRepo;
        public readonly ITestimonialRepo _ITestimonialRepo;
        public readonly INewslettersRepo _INewslettersRepo;
        public readonly IContactusRepo _IContactusRepo;


        public DashboardController(ISliderRepo sliderRepo, IFeatureRepo featureRepo, ICategoryRepo categoryRepo,
            IGalleryRepo galleryRepo, IBlogRepo blogRepo, ITestimonialRepo testimonialRepo,
            INewslettersRepo newslettersRepo, IContactusRepo contactusRepo)
        
        {
            _SliderRepo = sliderRepo;
            _IFeatureRepo = featureRepo;
            _ICategoryRepo = categoryRepo;
            _IGalleryRepo = galleryRepo;
            _IBlogRepo = blogRepo;
            _ITestimonialRepo = testimonialRepo;
            _INewslettersRepo = newslettersRepo;
            _IContactusRepo = contactusRepo;
           
        }

        //  ====================================================================
        //                                Dashboard
        //    ====================================================================

        [HttpGet("Dashboard")]
        public IActionResult Index()
        {
            var userName = HttpContext.Session.GetString("UserName");
            if (string.IsNullOrEmpty(userName))
                return RedirectToAction("Login", "UserRegistrations");
            ViewBag.UserName = userName;

            var vm = new ViewDashboard
            {
                // List Form Binding
                Slider = _SliderRepo.GetAllSlider(),
                Feature = _IFeatureRepo.GetAllFeature(),
                Category = _ICategoryRepo.GetAllCategories(),
                Gallery = _IGalleryRepo.GetAllGallery(),
                Blog = _IBlogRepo.GetAllBlog(),
                Testimonial = _ITestimonialRepo.GetAllTestimonials(),
                Newsletter = _INewslettersRepo.GetAllNewsletter(),
                Contactus = _IContactusRepo.GetAllContact(),

                // Single Form Binding
                Newsletters = new Newsletter(),
                ContactUS = new Contactus()
            };

            return View(vm);

        }

        [HttpPost]
        public IActionResult NewsletterAdd(ViewDashboard model)
        {
            var newEmail = new Newsletter
            {
                    Email = model.Newsletters.Email,
            };
                _INewslettersRepo.AddNewsletter(newEmail);
               return RedirectToAction("HomePage", "Front");
        }

        [HttpPost]
        public IActionResult AddContact(Contactus AddContact)
        {
            var Contact = new Contactus
            {
                Name = AddContact.Name,
                Email = AddContact.Email,
                Message = AddContact.Message,
            };
            _IContactusRepo.AddContact(Contact);
            return RedirectToAction("HomePage", "Front");
        }


    }
}
