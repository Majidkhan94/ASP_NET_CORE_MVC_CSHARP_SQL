


namespace StudentDetailsThroughAPIS.APIS
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        private readonly StudentDetailsDbContext _StudentDetails;
        public StudentAPIController(StudentDetailsDbContext StudentDetails)
        {
            _StudentDetails = StudentDetails;
        }


        [HttpPost]
        public async Task<ActionResult<StudentDetail>> AddStudentDetail(StudentDetail AddStudent)
        {
            await _StudentDetails.StudentDetails.AddAsync(AddStudent);
            await _StudentDetails.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<StudentDetail>>> GetAllStudent()
        {
            var data = await _StudentDetails.StudentDetails.ToListAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDetail>> GetStudentByID(int id)
        {
            var data = await _StudentDetails.StudentDetails.FindAsync(id);
            return Ok(data);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<StudentDetail>> UpdateStudentDetail(int id, StudentDetail UpdateStudent)
        {
            if (id != UpdateStudent.Id)
            {
                return BadRequest();
            }
            _StudentDetails.Entry(UpdateStudent).State = EntityState.Modified;
            await _StudentDetails.SaveChangesAsync();
            return Ok();
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<StudentDetail>> DeleteStudentDetail(int id)
        {
            var Del = await _StudentDetails.StudentDetails.FindAsync(id);
            _StudentDetails.StudentDetails.Remove(Del);
            await _StudentDetails.SaveChangesAsync();
           return Ok();
        }
    }
}
