using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
/*
 * Razor Pages Need A Root Folder, we can find this insed Page folder
 * Index.cshtml is a default document
 * 
 * 
 */
namespace AbbyWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // In razor pages we call controllers as Handlers
        public void OnGet()
        {

        }
    }
}