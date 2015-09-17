using System.Windows.Forms;

namespace SampleComputerSetConfigurator
{
	public static class PanelExtensions
	{
		public static void AddControl(this Panel panel, Control control)
		{
			control.Dock = DockStyle.Top;
			panel.Controls.Add(control);
		}
	}
}