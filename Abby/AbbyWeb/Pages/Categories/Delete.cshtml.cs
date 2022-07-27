using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Category Category { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            Category = _db.Category.Find(id);
            // First will return null if not find an id
            // FirstOrDefault will thrown an exception
            // where linq used when i have 2 entities some type of join
        }


        // Because input are disabled ModelState is not valid we get only the id in order to serach for this object in db
        // ModelState is not populated because we have disabled fileds
        public async Task<IActionResult> OnPost()
        {
            
            
                var categoryfromdb = _db.Category.Find(Category.Id);
                if (categoryfromdb != null)
                {
                    _db.Category.Remove(categoryfromdb);
                    await _db.SaveChangesAsync();
                    TempData["success"] = "Category Deleted Succesfully";
                    return RedirectToPage("Index");
                }

                
            return Page();
        }
           

    }
}

