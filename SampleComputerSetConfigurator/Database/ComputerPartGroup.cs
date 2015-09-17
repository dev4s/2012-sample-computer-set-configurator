using System.Collections.Generic;

namespace SampleComputerSetConfigurator.Database
{
	public class ComputerPartGroup
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Sequence { get; set; }
		public bool Show { get; set; }

		public virtual ComputerPartGroup Parent { get; set; }
		public virtual ICollection<ComputerPartGroup> Children { get; set; }
		public virtual ICollection<ComputerPart> ComputerParts { get; set; }
	}
}