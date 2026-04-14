using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Planademic.Web.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty] public string? Email    { get; set; }
        [BindProperty] public string? Password { get; set; }
        [BindProperty] public string  Role     { get; set; } = "Student";

        public void OnGet() { }

        // TODO: Replace with real ASP.NET Identity authentication in Iteration 3.
        public IActionResult OnPost() => RedirectToPage("/Dashboard");
    }
}