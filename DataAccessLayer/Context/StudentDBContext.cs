using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;
namespace DataAccessLayer
{
    public class StudentDBContext: DbContext
    {
        public StudentDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }

    }
}
