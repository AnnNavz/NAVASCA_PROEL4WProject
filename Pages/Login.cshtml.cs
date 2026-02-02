using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NAVASCA_PROEL4WProject.Models;

namespace NAVASCA_PROEL4WProject.Pages
{
    public class LoginModel : PageModel
    {

        private readonly ApplicationDbContext _context;

        public LoginModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Login users { get; set; } = new Login();

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var dbUser = _context.Register
                .FirstOrDefault(u => u.Username == users.Username);

            if (dbUser != null && dbUser.Password == users.Password)
            {
                return RedirectToPage("/Index");
            }

            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            return Page();
        }
    }
}
