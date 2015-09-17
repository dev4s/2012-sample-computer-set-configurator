using System.Windows.Forms;

namespace SampleComputerSetConfigurator.Controls
{
	public sealed class LabelPriceControl : Label
	{
		private decimal _price;
		public decimal Price
		{
			set
			{
				_price = value;
				Text = _price + " zł";
			}
			get { return _price; }
		}

		public LabelPriceControl()
		{
			_price = 0;
			Text = "0 zł";
		}
	}
}