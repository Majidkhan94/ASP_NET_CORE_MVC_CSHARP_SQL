using Microsoft.AspNetCore.Mvc;

namespace VibePhone.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly DBCONTEXT _dbContext;
        public CheckoutController(DBCONTEXT dbCONTEXT)
        {
            _dbContext = dbCONTEXT;
        }

        [HttpGet]
        public IActionResult Index(string productName, decimal price)
        {
            var order = new Checkout
            {
                ProductName = productName,
                Price = price
            };
            return View(order);
        }

        [HttpPost]
        public ActionResult Index(Checkout order)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Orders.Add(order);
                _dbContext.SaveChanges();

                TempData["Message"] = "Order placed successfully!";
                return RedirectToAction("Success", "Checkout");
            }

            return View(order);
        }

        public ActionResult Success()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
