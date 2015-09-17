using System.Collections.Generic;

namespace SampleComputerSetConfigurator.Database
{
	public class AdditionalService
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }

		public virtual ICollection<Order> Orders { get; set; }
	}
}