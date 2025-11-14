



namespace StdDetails_With_Repository_Save_In_Database.Controllers
{
    public class StdDetailsController : Controller
    {
        private readonly IStdDetails _IStdDetails;
        public StdDetailsController(IStdDetails iStdDetails)
        {
                _IStdDetails = iStdDetails;
        }

        [HttpPost]
        public IActionResult ShowStdDetails(StdDetailsModel model)
        {
            if (ModelState.IsValid)
            {
                _IStdDetails.AddStudent(model);
                return RedirectToAction("Success");
            }

            return View(model);
        }
        
        
        [HttpGet]
        public IActionResult ShowStdDetails()
        {
            return View(new StdDetailsModel());
        }

        public IActionResult Success()
        {
            return View();
        }
        public IActionResult ShowAllStudents()
        {
            var students = _IStdDetails.GetAllStdDetails();
            return View(students);
        }
     



    }
}
