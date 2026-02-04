using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NAVASCA_PROEL4WProject.Data;
using NAVASCA_PROEL4WProject.Models;

namespace NAVASCA_PROEL4WProject.Pages.RegisterShops
{
    public class IndexModel : PageModel
    {
        private readonly NAVASCA_PROEL4WProject.Data.NAVASCA_PROEL4WProjectContext _context;

        public IndexModel(NAVASCA_PROEL4WProject.Data.NAVASCA_PROEL4WProjectContext context)
        {
            _context = context;
        }

        public IList<RegisterShop> RegisterShop { get;set; } = default!;

        public async Task OnGetAsync()
        {
            RegisterShop = await _context.RegisterShop.ToListAsync();
        }
    }
}
