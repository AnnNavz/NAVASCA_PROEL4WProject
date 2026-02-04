using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NAVASCA_PROEL4WProject.Data;
using NAVASCA_PROEL4WProject.Models;

namespace NAVASCA_PROEL4WProject.Pages.RegisterShops
{
    public class CreateModel : PageModel
    {
        private readonly NAVASCA_PROEL4WProject.Data.NAVASCA_PROEL4WProjectContext _context;

        public CreateModel(NAVASCA_PROEL4WProject.Data.NAVASCA_PROEL4WProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RegisterShop RegisterShop { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.RegisterShop.Add(RegisterShop);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
