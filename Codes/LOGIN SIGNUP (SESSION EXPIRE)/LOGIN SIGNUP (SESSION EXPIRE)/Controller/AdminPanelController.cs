using Microsoft.IdentityModel.Abstractions;


namespace BlogWebsite.Controllers
{
    public class AdminPanelController : Controller
    {
        private readonly IAdminPanel AdminPanelCont;
        public AdminPanelController(IAdminPanel _IAdminPanel)
        {
            AdminPanelCont = _IAdminPanel;
        }
        public IActionResult Index()
        {
            HttpContext.Session.SetString("login", "login");
           return View();
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(AdminPanel AddUser)
        {
            if (AdminPanelCont.EmailExists(AddUser.Email))
            {
                ModelState.AddModelError("Email", "This email is already registered.");
                return View("Index");
            }

            if (ModelState.IsValid)
            {
                AdminPanelCont.Registration(AddUser);
                return RedirectToAction("Index");
            }

            return View("Index");

        }
        [HttpGet]

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Login(AdminPanel AddUser)
        {
            var log = AdminPanelCont.Login(AddUser.Email, AddUser.Password);
            if (log != null)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            ViewBag.error = "Invalid Email and Password";
            return View("Index");
            
        }










    }
}
