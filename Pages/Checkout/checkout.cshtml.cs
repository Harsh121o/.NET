using HiloMRM3.NewFolder;
using HiloMRM3.NewFolder1;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;

namespace HiloMRM3.Pages.Checkout
{
	[BindProperties(SupportsGet = true)]

	public class checkoutModel : PageModel
    {   

        public string name { get; set; }
        public string Qty { get; set; }
        public string Date { get; set; }
        public string Left_CYL { get; set; }
        public string Right_CYL { get; set; }
        public string Right_ADD { get; set; }
        public string Right_VISION { get; set; }
        public string Left_VISION { get; set; }

        public string Right_AXIS { get; set; }

        public string Right_SPH { get; set; }
        public string Description { get; set; }
        public string Items { get; set; }

        public string Left_ADD { get; set; }
        public string Left_Axis { get; set; }
        public string Left_SPH { get; set; }

        public string Total { get; set; }

        public string Address { get; set; }



        public void OnGet()
        {
			if (string.IsNullOrEmpty(name))
			{
				name = "hi";
			}
            
            if (string.IsNullOrEmpty(Qty))
            {
                Qty = "hi";
            }
            if (string.IsNullOrEmpty(Date))
            {
                Date = "hi";
            }

            if (string.IsNullOrEmpty(Left_CYL))
            {
                Left_CYL = "hi";
            }
            if (string.IsNullOrEmpty(Right_CYL))
            {
                Right_CYL = "hi";
            }
            if (string.IsNullOrEmpty(Right_ADD))
            {
                Right_ADD = "hi";
            }
            if (string.IsNullOrEmpty(Right_VISION))
            {
                Right_VISION = "hi";
            }

            if (string.IsNullOrEmpty(Description))
            {
                Description = "hi";
            }
            if (string.IsNullOrEmpty(Items))
            {
                Items = "hi";
            }
            if (string.IsNullOrEmpty(Left_ADD))
            {
                Left_ADD = "hi";
            }
            if (string.IsNullOrEmpty(Left_Axis))
            {
                Left_Axis = "hi";
            }

            if (string.IsNullOrEmpty(Left_SPH))
            {
                Left_SPH = "hi";
            }
            if (string.IsNullOrEmpty(Total))
            {
                Total = "hi";
            }
            if (string.IsNullOrEmpty(Left_VISION))
            {
                Left_VISION = "hi";
            }

            if (string.IsNullOrEmpty(Right_SPH))
            {
                Right_SPH = "hi";
            }
            if (string.IsNullOrEmpty(Items))
            {
                Items = "hi";
            }

            if (string.IsNullOrEmpty(Address))
            {
                Address = "hi";
            }





            PizzaOrder pizzaOrder= new PizzaOrder();
            pizzaOrder.name = name;
            pizzaOrder.Qty = Qty;
            pizzaOrder.Date = Date;
            pizzaOrder.Left_CYL = Left_CYL;
            pizzaOrder.Description = Description;
            pizzaOrder.Left_ADD = Left_ADD;
            pizzaOrder.Left_Axis = Left_Axis;
            pizzaOrder.Left_SPH = Left_SPH;
            pizzaOrder.Left_VISION = Left_VISION;
            pizzaOrder.Right_ADD = Right_ADD;
            pizzaOrder.Right_AXIS = Right_AXIS;
            pizzaOrder.Right_SPH = Right_SPH;
            pizzaOrder.Right_VISION = Right_VISION;
            pizzaOrder.Items = Items;
            pizzaOrder.Address = Address;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
        }
		private readonly ApplicationDBcontext _context;
		public checkoutModel(ApplicationDBcontext context)
		{
			_context = context;
		}
	}
}
