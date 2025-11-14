namespace VibePhone.Controllers
{
    public class TestimonialController : Controller
    {
        public readonly ITestimonialRepo _TestimonialRepo;

        public TestimonialController(ITestimonialRepo testimonialRepo)

        {
            _TestimonialRepo = testimonialRepo;
        }

        //  ====================================================================
        //                                TestimonialAdd
        //  ====================================================================
        [HttpGet("AddTestimonial")]
        public IActionResult TestimonialAdd()
        {
            return View();
        }

        [HttpPost("AddTestimonial")]
        public IActionResult TestimonialAdd(Testimonial model)
        {
            var add = _TestimonialRepo.AddTestimonial(model);
            return Redirect($"{Url.Action("Index", "Dashboard")}#Testimonials");
        }


        //  ====================================================================
        //                                TestimonialUpdate
        //  ====================================================================
        [HttpGet("UpdateTestimonial")]
        public IActionResult TestimonialUpdate(int id)
        {
            var find = _TestimonialRepo.GetTestimonialById(id);
            if (find == null)
                return NotFound();
            return View(find);
        }

        [HttpPost("UpdateTestimonial")]
        public IActionResult TestimonialUpdate(Testimonial update)
        {
            var updated = _TestimonialRepo.UpdateTestimonial(update);
            return Redirect($"{Url.Action("Index", "Dashboard")}#Testimonials");
        }


        //  ====================================================================
        //                                TestimonialDelete
        //  ====================================================================
        [HttpGet("TestimonialDelete/{id}")]
        public IActionResult TestimonialDelete(int id)
        {
            var find = _TestimonialRepo.GetTestimonialById(id);
            if (find == null)
                return NotFound();
            return View(find);
        }

        [HttpPost]
        public IActionResult TestimonialDeleteConfirmed(int id)
        {
            var delete = _TestimonialRepo.DeleteTestimonial(id);
            return Redirect($"{Url.Action("Index", "Dashboard")}#Testimonials");
        }
    }
}
