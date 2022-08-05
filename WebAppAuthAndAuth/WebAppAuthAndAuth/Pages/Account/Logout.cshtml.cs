using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppAuthAndAuth.Pages.Account
{
    public class LogoutModel : PageModel
    {

        // So when the page handler receives the HttpPost Request , it's going to simply sign out 
        // so is going to kill the cookie and redirect ton index page
        public async Task<IActionResult> OnPostAsync()
        {
            await HttpContext.SignOutAsync("MyCookieAuth");
            return RedirectToPage("/Index");
        }

        // For this page we only need a post method 
    }
}
