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
    public class DeleteModel : PageModel
    {
        private readonly NAVASCA_PROEL4WProject.Data.NAVASCA_PROEL4WProjectContext _context;

        public DeleteModel(NAVASCA_PROEL4WProject.Data.NAVASCA_PROEL4WProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RegisterShop RegisterShop { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registershop = await _context.RegisterShop.FirstOrDefaultAsync(m => m.ShopID == id);

            if (registershop == null)
            {
                return NotFound();
            }
            else
            {
                RegisterShop = registershop;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registershop = await _context.RegisterShop.FindAsync(id);
            if (registershop != null)
            {
                RegisterShop = registershop;
                _context.RegisterShop.Remove(RegisterShop);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
