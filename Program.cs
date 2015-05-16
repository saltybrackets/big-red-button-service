using System;
using System.Windows.Forms;


namespace BigRedButtonService
{
	
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			log4net.Config.XmlConfigurator.Configure();

			ButtonController buttonController = new ButtonController();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ConfigForm(buttonController));
			buttonController.StopMonitor();
		}
	}
}
