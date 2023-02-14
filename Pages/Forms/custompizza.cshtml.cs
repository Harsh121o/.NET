using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HiloMRM3.NewFolder;

namespace HiloMRM3.Pages.Forms
{

	public class custompizzaModel : PageModel
    {
        [BindProperty]
        
        public PizzasModel Pizza{get; set; }

        public string name { get; set; }
        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            name = Pizza.name;

            return RedirectToPage("/Checkout/checkout", new {name});
            
        }
    }
}
