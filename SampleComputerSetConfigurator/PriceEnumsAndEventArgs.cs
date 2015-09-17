using System;

namespace SampleComputerSetConfigurator
{
	public enum PriceEquation
	{
		Addition,
		Subtraction
	}

	public class PriceEventArgs : EventArgs
	{
		private readonly PriceEquation _equation;
		public PriceEquation Equation { get { return _equation; } }

		public PriceEventArgs(PriceEquation equation)
		{
			_equation = equation;
		}
	}
}