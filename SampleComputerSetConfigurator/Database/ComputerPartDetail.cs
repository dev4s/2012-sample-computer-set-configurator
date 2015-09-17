using System.Collections.Generic;

namespace SampleComputerSetConfigurator.Database
{
	public class ComputerPartDetail
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual ICollection<ComputerPart> ComputerParts { get; set; }
		public virtual ComputerPartDetailType Type { get; set; }
	}
}