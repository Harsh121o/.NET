using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HiloMRM3.NewFolder;


namespace HiloMRM3.Pages
{
    public class pizzaModel : PageModel
    {
        [BindProperty]

        public PizzaOrder Pizza { get; set; }

        public string name { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            name = Pizza.Left_Axis;

            return RedirectToPage("/Checkout/checkout", new
            {
                name,
                Pizza.Qty,
                Pizza.Date,
                Pizza.Left_CYL,
                Pizza.Right_CYL,
                Pizza.Right_ADD,
                Pizza.Right_VISION,
                Pizza.Description,
                Pizza.Items,
                Pizza.Left_ADD,
                Pizza.Left_Axis,
                Pizza.Left_SPH,
                Pizza.Total,
                Pizza.Address
            });

        }
    }
}
