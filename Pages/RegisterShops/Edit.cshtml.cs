using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NAVASCA_PROEL4WProject.Data;
using NAVASCA_PROEL4WProject.Models;

namespace NAVASCA_PROEL4WProject.Pages.RegisterShops
{
    public class EditModel : PageModel
    {
        private readonly NAVASCA_PROEL4WProject.Data.NAVASCA_PROEL4WProjectContext _context;

        public EditModel(NAVASCA_PROEL4WProject.Data.NAVASCA_PROEL4WProjectContext context)
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

            var registershop =  await _context.RegisterShop.FirstOrDefaultAsync(m => m.ShopID == id);
            if (registershop == null)
            {
                return NotFound();
            }
            RegisterShop = registershop;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(RegisterShop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegisterShopExists(RegisterShop.ShopID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RegisterShopExists(int id)
        {
            return _context.RegisterShop.Any(e => e.ShopID == id);
        }
    }
}
