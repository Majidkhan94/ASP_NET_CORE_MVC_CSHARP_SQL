using Microsoft.EntityFrameworkCore;

namespace CRUD_PROJECT.Controllers
{
    public class StdDetailController : Controller
    {
        private readonly IStdDetailRepo IStdDetailCont;
        public StdDetailController(IStdDetailRepo _IStdDetailRepo)
        {
            IStdDetailCont = _IStdDetailRepo;
        }

        public object Index()
        {
            var std = IStdDetailCont.ReadOnly() ?? new List<StdDetail>();
            return View(std);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StdDetail Create)
        {
            if (ModelState.IsValid)
            {
                IStdDetailCont.Create(Create);
                return RedirectToAction("Index");
            }
            return View("Create");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = IStdDetailCont.GetById(id); 
            return View(student);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            IStdDetailCont.Delete(id); 
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var Supdate = IStdDetailCont.GetById(id);
            if (Supdate == null)
                return NotFound();
            return View(Supdate);

        }
        [HttpPost]

        public IActionResult Update(StdDetail Update)
        {
            if (ModelState.IsValid)
            {
                IStdDetailCont.Update(Update);
                return RedirectToAction("Index");
                
            }
            return View(Update);

        }
        public IActionResult Details(int id)
        {
            var SDetails = IStdDetailCont.GetById(id);
            if (SDetails == null)
                return NotFound();
            return View(SDetails);
        }
        

    }
}
