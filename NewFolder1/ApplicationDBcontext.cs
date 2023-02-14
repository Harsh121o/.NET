using Microsoft.EntityFrameworkCore;
using HiloMRM3.NewFolder;
namespace HiloMRM3.NewFolder1
{
	public class ApplicationDBcontext : DbContext
	{
		public DbSet<PizzaOrder> PizzaOrders { get; set; }	
		
		public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) : base(options){

		
		}

	}
}
