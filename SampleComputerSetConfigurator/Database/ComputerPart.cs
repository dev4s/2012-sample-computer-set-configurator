using System.Collections.Generic;

namespace SampleComputerSetConfigurator.Database
{
	public class ComputerPart
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }

		public virtual ComputerPartGroup Group { get; set; }
		public virtual ICollection<ComputerPartDetail> Details { get; set; }
		public virtual ICollection<Order> Orders { get; set; }
	}
}