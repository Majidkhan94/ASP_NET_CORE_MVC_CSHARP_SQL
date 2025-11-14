using Microsoft.AspNetCore.Mvc;

namespace StudentDetailsThroughAPIS.Controllers
{
    public class StdDetailsController : Controller
    {
        string APIURL = "https://localhost:7255/api/StudentAPI";
        HttpClient client = new HttpClient();


        [HttpGet]
        public IActionResult Index()
        {
            List<StudentDetail> StudentDetail = new List<StudentDetail>();
            HttpResponseMessage response = client.GetAsync(APIURL).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
               var data = JsonConvert.DeserializeObject<List<StudentDetail>>(result);
                if (data != null) 
                {
                    StudentDetail = data;
                }
            }
            return View(StudentDetail);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentDetail AddStudent)
        {
            string data = JsonConvert.SerializeObject(AddStudent);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(APIURL, content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "StdDetails");

            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            HttpResponseMessage response = client.GetAsync($"{APIURL}/{id}").Result;

            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var Student = JsonConvert.DeserializeObject<StudentDetail>(data);
                return View(Student);
            }

            return NotFound();
        }
        [HttpPost]
        public IActionResult Update(StudentDetail UpdateStudent)
        {
            string data = JsonConvert.SerializeObject(UpdateStudent);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync($"{APIURL}/{UpdateStudent.Id}", content).Result;

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "StdDetails");
            }

            return View(UpdateStudent);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
          HttpResponseMessage response = client.GetAsync($"{APIURL}/{id}").Result;

            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var student = JsonConvert.DeserializeObject<StudentDetail>(data);
                return View(student);
            }

            return NotFound();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            HttpResponseMessage response = client.DeleteAsync($"{APIURL}/{id}").Result;
            var result = response.Content.ReadAsStringAsync().Result; // debug ke liye

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "StdDetails");
            }

            ViewBag.ApiError = result;
            return View();
        }

    }
}
