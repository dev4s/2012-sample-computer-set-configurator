using System;
using System.Linq;
using System.Windows.Forms;
using SampleComputerSetConfigurator.Controls;
using SampleComputerSetConfigurator.Database;

namespace SampleComputerSetConfigurator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainFormLoad(object sender, EventArgs e)
		{
			InitializePanel();
		}

		private void ControlPriceChanged(object sender, PriceEventArgs e, decimal price)
		{
			if (e.Equation == PriceEquation.Addition)
			{
				labelPriceControl.Price += price;
			}

			if (e.Equation == PriceEquation.Subtraction)
			{
				labelPriceControl.Price -= price;
			}
		}

		private void ButtonFinishOrderClick(object sender, EventArgs e)
		{
			//TODO:

			//if (((ComputerPart) comboBox1.SelectedItem).ComputerPartId == -1)
			//{
			//    return;
			//}

			//using (var dbContext = new ComputerSetDatabaseContext())
			//{
			//    var motherboard = dbContext.ComputerParts.CheckAndAttach((ComputerPart) comboBox1.SelectedItem);
			//    var processor = dbContext.ComputerParts.CheckAndAttach((ComputerPart) comboBox2.SelectedItem);
			//    var memory = dbContext.ComputerParts.CheckAndAttach((ComputerPart) comboBox3.SelectedItem);
			//    var hardisk = dbContext.ComputerParts.CheckAndAttach((ComputerPart) comboBox4.SelectedItem);
			//    var opticaldrive = dbContext.ComputerParts.CheckAndAttach((ComputerPart) comboBox5.SelectedItem);
			//    var computercase = dbContext.ComputerParts.CheckAndAttach((ComputerPart) comboBox6.SelectedItem);
			//    var additionalService = dbContext.AdditionalServices.CheckAndAttach((AdditionalService) comboBox7.SelectedItem);

			//    var computerParts = new[] {motherboard, processor, memory, hardisk, opticaldrive, computercase};
			//    var newOrder = new Order{AdditionalServices = new Collection<AdditionalService>(), ComputerParts = new Collection<ComputerPart>()};

			//    foreach (var part in computerParts.Where(part => part != null))
			//    {
			//        newOrder.ComputerParts.Add(part);
			//    }

			//    if (additionalService != null)
			//    {
			//        newOrder.AdditionalServices.Add(additionalService);
			//    }

			//    dbContext.Orders.Add(newOrder);
			//    dbContext.SaveChanges();
			//}

			//MessageBox.Show("Nowe zamówienie zostało złożonoe.\r\nProgram zostanie teraz zamknięty.", "Złożono zamówienie", MessageBoxButtons.OK,
			//                    MessageBoxIcon.Information);
			//Close();
		}

		private void ButtonCleanOrderClick(object sender, EventArgs e)
		{
			panelGroupsAndParts.Controls.Clear();
			InitializePanel();
		}

		private void ButtonGroupsAndPartsClick(object sender, EventArgs e)
		{
			var groupsAndPartsForm = new GroupsAndPartsForm();
			groupsAndPartsForm.ShowDialog();

			panelGroupsAndParts.Controls.Clear();
			InitializePanel();
		}

		private void InitializePanel()
		{
			using (var dbContext = new ComputerSetDatabaseContext())
			{
				var additionalServiceControl = new AdditionalServicesControl();
				additionalServiceControl.SetServicesValues(dbContext.AdditionalServices.ToList(), "Name", "Id");
				additionalServiceControl.PriceChanged += ControlPriceChanged;
				panelGroupsAndParts.AddControl(additionalServiceControl);

				foreach (var g in dbContext.ComputerPartGroups.OrderByDescending(x => x.Sequence))
				{
					var parts = g.ComputerParts.ToList();
					parts.InsertFakeValue();

					var control = new GroupsAndPartsControl { GroupName = g.Name, Name = g.Name.NormalizeAndAddSequence(g.Sequence) };
					control.SetPartsValues(parts, "Name", "Id");
					control.PriceChanged += ControlPriceChanged;

					if (g.Parent != null)
					{
						control.Enabled = false;
					}

					panelGroupsAndParts.AddControl(control);
				}
			}
		}
	}
}
