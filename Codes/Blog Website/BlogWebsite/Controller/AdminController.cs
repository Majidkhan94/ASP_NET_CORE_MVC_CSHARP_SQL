using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUserlogin _Userlogin;
        public AdminController(IUserlogin iUserlogin)
        {
            _Userlogin = iUserlogin;
        }
        // Login
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Userlogin login)
        {
            var log = _Userlogin.UserLogin(login.Email, login.Password);
            if (log != null)
            {

                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, log.UserName),   // ✅ Username claim me save
                        new Claim(ClaimTypes.Email, log.Email),     // Optional: email bhi rakh lo
                        new Claim(ClaimTypes.NameIdentifier, log.ID.ToString())
                    };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));


                return RedirectToAction("Index", "Dashboard");
            }

            ViewBag.error = "Invalid Email and Password";
            return View("Index");
        }

        // Registration
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(Userlogin Registration)
        {
            if (_Userlogin.EmailExists(Registration.Email))
            {
                ModelState.AddModelError("Email", "This email is already registered.");
                return View("Index");
            }

            if (ModelState.IsValid)
            {
                _Userlogin.UserRegistration(Registration);
                return RedirectToAction("Index");
            }

            return View("Index");

        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Admin");
        }



    }

}
