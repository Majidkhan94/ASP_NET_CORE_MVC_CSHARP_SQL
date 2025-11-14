

using StorePRocedure__CRUD__.CustomerDAL;

namespace StorePRocedure__CRUD__.Controllers
{
    public class CustomerController : Controller
    {

        // GetAllCustomers
        [HttpGet]
        public IActionResult Index()
        {
            GetAllCustomers _Customer = new GetAllCustomers();
            List<CustModel> CustList = new List<CustModel>();

            CustList = _Customer.GetAllCustomer();
            return View(CustList);
        }
                           // Create Customer
        
        [HttpGet]public IActionResult Create(){return View();}

        [HttpPost]
        public IActionResult Create(CustModel Createcustomer)
        {
            

           if (ModelState.IsValid)
           {
                CreateCustomer AddCustomer = new CreateCustomer();

                CustModel Customer = AddCustomer.Create(Createcustomer);

                if (Customer != null)
                {
                    return RedirectToAction("Index", "Customer");
                }
           }
            return View(Createcustomer);
        }

        // Update Customer

        [HttpGet] public IActionResult Update(int id)
        {
            CustomerByID customerByID = new CustomerByID();
            CustModel customer = customerByID.CustomerById(id);
            if (customer != null)
            {
                return View(customer);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult Update(int id, CustModel UpdateCustomer)
        {
            if(ModelState.IsValid)
            {
                UpdateCustomer _UpdateCustomer = new UpdateCustomer();
                CustModel customer = _UpdateCustomer.Update(id, UpdateCustomer);

                if (_UpdateCustomer != null)
                {
                    return RedirectToAction("Index", "Customer");
                }
            }
            return View(UpdateCustomer);
        }

        // Delete Customer
        [HttpGet]
        public IActionResult Delete(int id)
        {
            CustomerByID customerByID = new CustomerByID();
            CustModel customer = customerByID.CustomerById(id);
            if (customer != null)
            {
                return View(customer);
            }

            return NotFound();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            if (ModelState.IsValid)
            {
                DeleteCustomer _DeleteCustomer = new DeleteCustomer();
                CustModel customer = _DeleteCustomer.Delete(id);

                if (_DeleteCustomer != null)
                {
                    return RedirectToAction("Index", "Customer");
                }
            }
            return View();
        }

    }
}
