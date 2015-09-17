using System.Collections.Generic;

namespace SampleComputerSetConfigurator.Database
{
	public class ComputerPartDetailType
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual ICollection<ComputerPartDetail> Details { get; set; } 
	}
}