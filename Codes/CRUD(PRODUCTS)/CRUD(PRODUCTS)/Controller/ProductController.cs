

using System.Reflection;

namespace CRUD_PRODUCTS_.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo ProductCont;
        public ProductController (IProductRepo _IProductRepo)
        {
            ProductCont = _IProductRepo;
        }
                                // Get All Products
        public IActionResult Index()
        {
            var list = ProductCont.GetAllProducts().OrderByDescending(d=>d.ID).ToList() ?? new List<ProductModel>();
            return View(list);
        }
                                // Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductModelView VModel)
        {
            if (ModelState.IsValid)
            {
                var PModel = new ProductModel
                {
                    Title = VModel.Title,
                    Price = VModel.Price,
                    Description = VModel.Description
                };
                ProductCont.CreateProduct(PModel, VModel);
                ViewBag.Create = "Product Submitted Successfully";
                return RedirectToAction("Index");
            }

            
            return View(VModel);
        }
                               // Update Product
        [HttpGet]
        public ActionResult Update(int id) 
        {
            var UProduct = ProductCont.GetProductByID(id);
            if (UProduct == null)
            {
                return NotFound();
            }
            var VModel = new ProductModelView
            {
                Title = UProduct.Title,
                Price = UProduct.Price,
                Description = UProduct.Description,
            };
            return View(VModel);
        }
        [HttpPost]
        public ActionResult Update(ProductModelView VModel)
        {
            if (ModelState.IsValid)
            {
                // ✅ Step 1: Existing product fetch karo using ID
                var existingProduct = ProductCont.GetProductByID(VModel.ID);
                if (existingProduct == null)
                {
                    return NotFound();
                }

                // ✅ Step 2: UpdateProduct() me bhejo (wo image bhi handle kar raha hai)
                ProductCont.UpdateProduct(existingProduct, VModel);

                // ✅ Step 3: Redirect
                return RedirectToAction("Index");
            }

            return View(VModel);
        }


        //Delete
        // GET: Product/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var DProduct = ProductCont.GetProductByID(id); // Return ProductModel, not ViewModel
            if (DProduct == null)
            {
                return NotFound();
            }

            return View(DProduct); // Make sure Delete.cshtml expects ProductModel
        }


        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductCont.DeleteProduct(id);
            return RedirectToAction("Index");
        }


    }
}
