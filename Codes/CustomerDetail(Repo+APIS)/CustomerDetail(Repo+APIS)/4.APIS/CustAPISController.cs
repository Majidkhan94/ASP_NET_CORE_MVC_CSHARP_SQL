

namespace CustomerDetail_Repo_APIS_._4.APIS
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustAPISController : ControllerBase
    {
        private readonly ICust CUSTAPI;
        public CustAPISController(ICust _ICust)
        {
                CUSTAPI = _ICust;
        }

        [HttpPost]
        public IActionResult CreateCust(CustModel CreateCust)
        {
            CUSTAPI.CreateCust(CreateCust);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAllCust()
        {
           var Data = CUSTAPI.GetAllCust();
            return Ok(Data);
        }
        [HttpGet("{id}")]
        public IActionResult CustByID(int id)
        {
            var data = CUSTAPI.CustByID(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
         
        [HttpPut("{id}")]
        public IActionResult UpdateCust(int id, CustModel UpdateCust)
        {
            if(id != UpdateCust.Id)
            {
                return BadRequest();
            }
            CUSTAPI.UpdateCust(id,UpdateCust);
            return Ok(UpdateCust);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCust(int id)
        {
            CUSTAPI.DeleteCust(id);
            return Ok();
        }

    }
}
