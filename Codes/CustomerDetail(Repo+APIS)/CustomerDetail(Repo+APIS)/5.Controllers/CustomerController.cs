

using System.Text;

namespace CustomerDetail_Repo_APIS_._5.Controllers
{
    public class CustomerController : Controller
    {
        string APIURL = "https://localhost:7009/api/CustAPIS";
        HttpClient client = new HttpClient();


        [HttpGet]
        public IActionResult Index()
        {
            List<CustModel> Customers = new List<CustModel>();
            HttpResponseMessage response = client.GetAsync(APIURL).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<List<CustModel>>(result);
                if (data != null)
                {
                    Customers = data;
                }
            }
            return View(Customers);
        }
        [HttpGet] public IActionResult Create(){return View();}
        
        [HttpPost]
        public IActionResult CreateCust(CustModel CreateCust)
        {
             HttpResponseMessage response = client.PostAsJsonAsync(APIURL, CreateCust).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Customer");

            }
            return View(CreateCust);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            HttpResponseMessage response = client.GetAsync($"{APIURL}/{id}").Result;

            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var Customer = JsonConvert.DeserializeObject<CustModel>(data);
                return View(Customer);
            }

            return NotFound();
        }
        [HttpPost]
        public IActionResult Update(CustModel UpdateCust)
        {
            //string data = JsonConvert.SerializeObject(UpdateStudent);
            //StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsJsonAsync($"{APIURL}/{UpdateCust.Id}", UpdateCust).Result;

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Customer");
            }

            return View(UpdateCust);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            HttpResponseMessage response = client.GetAsync($"{APIURL}/{id}").Result;

            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var student = JsonConvert.DeserializeObject<CustModel>(data);
                return View(student);
            }

            return NotFound();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            HttpResponseMessage response = client.DeleteAsync($"{APIURL}/{id}").Result;
            var result = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Customer");
            }
            return View();
        }
    }
}
