using ShowStdDetails_Through_Repository.Data;

namespace ShowStdDetails_Through_Repository.Controllers
{
    public class StdDetailsController : Controller
    {
        private IStdDetailsRepo _IStdDetailsRepo;
        public StdDetailsController(IStdDetailsRepo iStdDetailsRepo)
        {
            _IStdDetailsRepo = iStdDetailsRepo;
        }

        public List<StdDetailsModel> getAllStdDetails()
        {
            return _IStdDetailsRepo.GetAllStdDetails();
        }

        public StdDetailsModel getAllStdDetailsById(int id)
        {
            return _IStdDetailsRepo.GetAllStdDetailsById(id);
        }




        public IActionResult ShowStdInfo()
        {
            var student = _IStdDetailsRepo.GetAllStdDetails();
            return View(student);
        }
    }
}
