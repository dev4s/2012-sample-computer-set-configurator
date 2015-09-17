using System.Collections.Generic;

namespace SampleComputerSetConfigurator.Database
{
	public class Order
	{
		public int Id { get; set; }
		public virtual ICollection<ComputerPart> ComputerParts { get; set; }
		public virtual ICollection<AdditionalService> AdditionalServices { get; set; }
	}
}