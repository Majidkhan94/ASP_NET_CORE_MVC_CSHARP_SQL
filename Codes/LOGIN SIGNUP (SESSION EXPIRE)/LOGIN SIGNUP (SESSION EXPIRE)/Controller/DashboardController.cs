namespace BlogWebsite.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Data = HttpContext.Session.GetString("login");
            return View();
        }
    }
}
