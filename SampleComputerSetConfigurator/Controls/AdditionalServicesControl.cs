using System;
using System.Windows.Forms;
using SampleComputerSetConfigurator.Database;

namespace SampleComputerSetConfigurator.Controls
{
	public partial class AdditionalServicesControl : UserControl
	{
		public delegate void PriceChangedEventHandler(object sender, PriceEventArgs e, decimal price);
		public event PriceChangedEventHandler PriceChanged;
		private void OnPriceChanged(PriceEventArgs e, decimal price)
		{
			var handler = PriceChanged;
			if (handler != null) handler(this, e, price);
		}

		public void SetServicesValues(object dataSource, string displayMember, string valueMember)
		{
			checkedListBoxServices.DataSource = dataSource;
			checkedListBoxServices.DisplayMember = displayMember;
			checkedListBoxServices.ValueMember = valueMember;
		}

		public AdditionalServicesControl()
		{
			InitializeComponent();
		}

		private void AdditionalServicesControlLoad(object sender, EventArgs e)
		{
			labelGroupName.Text = "Dodatkowe usługi";
			labelPrice.Text = _sumPrices + " zł";
		}

		private decimal _price;
		private decimal _sumPrices;
		private void CheckedListBoxServicesItemCheck(object sender, ItemCheckEventArgs e)
		{
			var item = (AdditionalService)((CheckedListBox)sender).SelectedItem;
			_price = item.Price;

			if (e.NewValue == CheckState.Checked)
			{
				_sumPrices += _price;
				OnPriceChanged(new PriceEventArgs(PriceEquation.Addition), _price);
			}

			if (e.NewValue == CheckState.Unchecked)
			{
				_sumPrices -= _price;
				OnPriceChanged(new PriceEventArgs(PriceEquation.Subtraction), _price);
			}

			labelPrice.Text = _sumPrices + " zł";
		}
	}
}
