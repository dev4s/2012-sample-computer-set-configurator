using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SampleComputerSetConfigurator.Database;

namespace SampleComputerSetConfigurator.Controls
{
	public partial class GroupsAndPartsControl : UserControl
	{
		public string GroupName
		{
			set { labelGroupName.Text = value; }
		}

		public delegate void PriceChangedEventHandler(object sender, PriceEventArgs e, decimal price);
		public event PriceChangedEventHandler PriceChanged;
		private void OnPriceChanged(PriceEventArgs e, decimal price)
		{
			var handler = PriceChanged;
			if (handler != null) handler(this, e, price);
		}

		public void SetPartsValues(object dataSource, string displayMember, string valueMember)
		{
			comboBoxParts.DataSource = dataSource;
			comboBoxParts.DisplayMember = displayMember;
			comboBoxParts.ValueMember = valueMember;
		}

		public GroupsAndPartsControl()
		{
			InitializeComponent();
		}

		private bool _initialized;
		private readonly List<Control> _childControls = new List<Control>();
		private decimal _price;
		private decimal _lastPassedPrice;
		private void ComboBoxPartsSelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedItem = (ComputerPart) comboBoxParts.SelectedItem;

			_price = selectedItem.Price;
			OnPriceChanged(new PriceEventArgs(PriceEquation.Subtraction), _lastPassedPrice);
			OnPriceChanged(new PriceEventArgs(PriceEquation.Addition), _price);
			_lastPassedPrice = selectedItem.Price;
			labelPrice.Text = _price + " zł";

			if (_initialized == false)
			{
				_initialized = true;
				return;
			}

			if (selectedItem.Id == -1)
			{
				EnableChildren(false);
			}
			else
			{
				if (_childControls.Any())
				{
					EnableChildren(true);
				}
				else
				{
					SearchingForChildren(selectedItem);
				}
			}
		}

		private void EnableChildren(bool enabled)
		{
			foreach (var childControl in _childControls)
			{
				childControl.Enabled = enabled;
			}
		}

		private void SearchingForChildren(ComputerPart selectedItem)
		{
			var panel = (Panel) comboBoxParts.Parent.Parent.Parent;
			using (var dbContext = new ComputerSetDatabaseContext())
			{
				dbContext.ComputerParts.Attach(selectedItem);

				if (selectedItem.Group.Children.Any())
				{
					foreach (var panelChild in selectedItem.Group.Children.
						Select(child => panel.Controls.Find(child.Name.NormalizeAndAddSequence(child.Sequence), false)).SelectMany(
							panelChilds => panelChilds))
					{
						_childControls.Add(panelChild);
						panelChild.Enabled = true;
					}
				}
			}
		}
	}
}
