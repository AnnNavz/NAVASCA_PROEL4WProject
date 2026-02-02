using Microsoft.EntityFrameworkCore;

namespace NAVASCA_PROEL4WProject.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Register> Register { get; set; }
    }
}
