

namespace StudentDetailsThroughAPIS.DBContext;

public class StudentDetailsDbContext : DbContext
{
    public StudentDetailsDbContext(DbContextOptions<StudentDetailsDbContext> options) : base(options) { }

    public DbSet<StudentDetail> StudentDetails { get; set; }
}