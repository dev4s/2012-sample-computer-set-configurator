using System;
using System.Windows.Forms;

namespace SampleComputerSetConfigurator
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//NOTE: delete this when initialization is not needed anymore
			System.Data.Entity.Database.SetInitializer(new Database.InitializeSampleData());

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
			//Application.Run(new GroupsAndPartsForm());
		}
	}
}
