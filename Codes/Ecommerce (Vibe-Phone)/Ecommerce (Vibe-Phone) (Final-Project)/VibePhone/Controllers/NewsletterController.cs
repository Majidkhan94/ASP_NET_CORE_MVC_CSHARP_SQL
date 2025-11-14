namespace VibePhone.Controllers
{
    public class NewsletterController : Controller
    {
        public readonly INewslettersRepo _NewslettersRepo;

        public NewsletterController(INewslettersRepo newslettersRepo)

        {
            _NewslettersRepo = newslettersRepo;
        }
        //  ====================================================================
        //                                NewsletterAdd
        //  ====================================================================

        [HttpGet("AddNewsletter")]
        public IActionResult NewsletterAdd()
        {
            return View();
        }

        [HttpPost("AddNewsletter")]
        public IActionResult NewsletterAdd(Newsletter model)
        {
            var add = _NewslettersRepo.AddNewsletter(model);
            return Redirect($"{Url.Action("Index", "Dashboard")}#Newsletter");
        }


        //  ====================================================================
        //                                NewsletterUpdate
        //  ====================================================================

        [HttpGet("UpdateNewsletter")]
        public IActionResult NewsletterUpdate(int id)
        {
            var find = _NewslettersRepo.GetNewsletterById(id);
            if (find == null)
                return NotFound();
            return View(find);
        }

        [HttpPost("UpdateNewsletter")]
        public IActionResult NewsletterUpdate(Newsletter update)
        {
            var updated = _NewslettersRepo.UpdateNewsletter(update);
            return Redirect($"{Url.Action("Index", "Dashboard")}#Newsletter");
        }


        //  ====================================================================
        //                                NewsletterDelete
        //  ====================================================================

        [HttpGet("NewsletterDelete/{id}")]
        public IActionResult NewsletterDelete(int id)
        {
            var find = _NewslettersRepo.GetNewsletterById(id);
            if (find == null)
                return NotFound();
            return View(find);
        }

        [HttpPost]
        public IActionResult NewsletterDeleteConfirmed(int id)
        {
            var delete = _NewslettersRepo.DeleteNewsletter(id);
            return Redirect($"{Url.Action("Index", "Dashboard")}#Newsletter");
        }
    }
}
