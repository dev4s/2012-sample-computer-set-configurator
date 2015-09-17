using System.Collections.Generic;

namespace SampleComputerSetConfigurator.Database
{
	public static class DatabaseExtensions
	{
		public static void InsertFakeValue(this List<ComputerPart> list)
		{
			list.Insert(0, new ComputerPart { Id = -1, Name = "..." });
		}
	}
}