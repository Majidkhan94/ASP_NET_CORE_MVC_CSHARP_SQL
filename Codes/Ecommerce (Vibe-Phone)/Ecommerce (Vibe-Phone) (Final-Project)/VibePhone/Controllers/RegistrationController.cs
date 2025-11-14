namespace VibePhone.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IUserRepo _UserRepo;
        private readonly IAdminRepo _AdminRepo;

        public RegistrationController(IUserRepo userRepo, IAdminRepo adminRepo)
        {
            _UserRepo = userRepo;
            _AdminRepo = adminRepo;
        }
        //  ====================================================================
        //                               USER REGISTRATION
        //  ====================================================================

        [HttpGet("user")] public IActionResult UserRegister() => View();

        [HttpPost("user")]
        public IActionResult UserRegister(UserRegistration UserModel)
        {
            if (ModelState.IsValid)
            {
                UserModel.Role = "User";
                _UserRepo.AddUser(UserModel);
                TempData["Success"] = "User Registered Successfully!";
                return RedirectToAction("Login");
            }
            return View(UserModel);
        }

        //  ====================================================================
        //                                ADMIN REGISTRATION
        //  ====================================================================

        [HttpGet("admin")] public IActionResult AdminRegister() => View();

        [HttpPost("admin")]
        public IActionResult AdminRegister(AdminRegistration AdminModel)
        {
            if (ModelState.IsValid)
            {
                AdminModel.Role = "Admin";
                _AdminRepo.AddAdmin(AdminModel);
                TempData["Success"] = "Admin Registered Successfully!";
                return RedirectToAction("Login");
            }
            return View(AdminModel);
        }

        //  ====================================================================
        //                               LOGIN (Shared for Both)
        //  ====================================================================

        [HttpGet("login")] public IActionResult Login()=> View();

        [HttpPost("login")]
        public IActionResult Login(string email, string password)
        {
            // Pehle Admin check karo
           
            var admin = _AdminRepo.ValidateAdmin(email, password);
            if (admin != null)
            {
                HttpContext.Session.SetString("Role", "Admin");
                HttpContext.Session.SetString("UserName", admin.UserName);
                return RedirectToAction("Index", "Dashboard");
            }

            // Ab user check karo
            
            var user = _UserRepo.ValidateUser(email, password);
            if (user != null)
            {
                HttpContext.Session.SetString("Role", "User");
                HttpContext.Session.SetString("UserName", user.UserName);
                return RedirectToAction("HomePage", "Front");
            }

            ModelState.AddModelError("", "Invalid email or password");
            return View();
        }

        //  ====================================================================
        //                               LOGOUT
        //  ====================================================================

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            var role = HttpContext.Session.GetString("Role");

            HttpContext.Session.Clear();

            if (role == "Admin")
            {
                return RedirectToAction("Login", "Registration");
            }
            else
            {
                return RedirectToAction("HomePage", "Front");
            }
        }



    }
}
