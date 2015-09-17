using System;
using System.Windows.Forms;

namespace SampleComputerSetConfigurator.Controls
{
	public class CustomTabControl : TabControl
	{
		private const int TcmAdjustrect = 0x1328;

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == TcmAdjustrect && !DesignMode)
			{
				m.Result = (IntPtr) 1;
				return;
			}
			base.WndProc(ref m);
		}
	}
}