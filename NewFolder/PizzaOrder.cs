namespace HiloMRM3.NewFolder
{
	public class PizzaOrder
	{
		public int Id { get; set; }

        public string name { get; set; }

        public string Address { get; set; }
        public string Left_Axis { get; set; }

        public string? Description { get; set; } 
        public string? Date { get; set; } 
        public string? Right_SPH { get; set; } 
        public string? Right_CYL { get; set; } 
        public string? Right_AXIS { get; set; } 
        public string? Right_ADD { get; set; } 
        public string? Right_VISION { get; set; } 
        public string? Left_SPH { get; set; } 
        public string? Left_CYL { get; set; } 

        public string? Left_ADD { get; set; } 
        public string? Left_VISION { get; set; } 
        public string? Items { get; set; } 

        public string Total { get; set; }

        public string Qty { get; set; }
    }
}
