using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NAVASCA_PROEL4WProject.Models;

namespace NAVASCA_PROEL4WProject.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]

        public Login users { get; set; } = new Login();

        public IActionResult OnPost()
        {
            if (users.Username == "Admin" && users.Password == "Admin123!")
            {
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}
