namespace StdDetails_Direct_Save_In_Database.Controllers
{
    public class StdDetailsController : Controller
    {
        private readonly ModelData _ModelData;
        public StdDetailsController(ModelData modelData)
        {
            _ModelData = modelData;
        }

        [HttpGet]
        public IActionResult ShowStdDetails()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowStdDetails(StdDetailsModel stdDetailsModel)
        {
            if (ModelState.IsValid)
            {


                _ModelData.StdDetails.Add(stdDetailsModel);
                _ModelData.SaveChanges();
                return RedirectToAction("Success");
            }
               return View(stdDetailsModel); 
        }
        
        public IActionResult Success()
        {
            return View();
        }

    }
}
