using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NAVASCA_PROEL4WProject.Models;

namespace NAVASCA_PROEL4WProject.Data
{
    public class NAVASCA_PROEL4WProjectContext : DbContext
    {
        public NAVASCA_PROEL4WProjectContext (DbContextOptions<NAVASCA_PROEL4WProjectContext> options)
            : base(options)
        {
        }

        public DbSet<NAVASCA_PROEL4WProject.Models.Product> Product { get; set; } = default!;
        public DbSet<NAVASCA_PROEL4WProject.Models.Register> Register { get; set; } = default!;
        public DbSet<NAVASCA_PROEL4WProject.Models.RegisterShop> RegisterShop { get; set; } = default!;
    }
}
