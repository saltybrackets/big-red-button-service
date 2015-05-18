using System.Net.Http;
using System.Threading.Tasks;

using log4net;


namespace BigRedButtonService
{
	/// <summary>
	/// Logic for handling button events.
	/// </summary>
	public sealed class ButtonController
	{

		#region Constants
		/// <summary>
		/// File where button config is stored.
		/// </summary>
		public const string ConfigFile = "config.ini";
		#endregion


		#region Fields
		private static ILog logger = LogManager.GetLogger(typeof (ButtonController));

		private ButtonConfig buttonConfig;
		private ButtonMonitor buttonMonitor;
		private HttpClient httpClient;
		#endregion


		#region Constructors
		/// <summary>
		/// Create new ButtonController object.
		/// </summary>
		public ButtonController()
		{
			this.httpClient = new HttpClient();
			this.buttonConfig = new ButtonConfig(ConfigFile);
		}
		#endregion


		#region Properties
		/// <summary>
		/// Button command configuration.
		/// </summary>
		public ButtonConfig ButtonConfig
		{
			get { return this.buttonConfig; }
		}


		/// <summary>
		/// Button status monitoring on background thread.
		/// </summary>
		public ButtonMonitor ButtonMonitor
		{
			get { return this.buttonMonitor; }
		}


		/// <summary>
		/// Client for sending HTTP requests.
		/// </summary>
		public HttpClient HttpClient
		{
			get { return this.httpClient; }
		}
		#endregion


		/// <summary>
		/// Start monitoring button, if available.
		/// If not available, try again in 10 seconds.
		/// </summary>
		public void StartMonitor()
		{
			
			// Device found, start listening.
			this.buttonMonitor = new ButtonMonitor();

			// Register events.
			this.buttonMonitor.ButtonPressed +=
				() => ExecuteButtonCommand(this.buttonConfig.ButtonPressedCommand);
			this.buttonMonitor.LidClosed +=
				() => ExecuteButtonCommand(this.buttonConfig.LidClosedCommand);
			this.buttonMonitor.LidOpened +=
				() => ExecuteButtonCommand(this.buttonConfig.LidOpenedCommand);

			// Start background thread listening for button state changes.
			this.buttonMonitor.Start();
			logger.Info("Monitoring Big Red Button device.");
			
		}


		/// <summary>
		/// Stop monitoring button status on background thread.
		/// </summary>
		public void StopMonitor()
		{
			this.buttonMonitor.Stop();
			logger.Info("Stopped monitoring Big Red Button device.");
		}


		#region Event Handlers
		/// <summary>
		/// Fired when button pressed, lid opened, or lid closed.
		/// </summary>
		private void ExecuteButtonCommand(ButtonCommand buttonCommand)
		{
			// Command line command.
			if (buttonCommand.Type == ButtonCommand.CommandType.Shell)
			{
				Task.Run(() =>
				{
					try
					{
						System.Diagnostics.Process.Start(buttonCommand.Command);
					}
					catch
					{
						logger.Error("Could execute shell command.");
					}
				});
			}

			// HTTP request.
			else if (buttonCommand.Type == ButtonCommand.CommandType.HttpRequest)
			{
				Task.Run(() =>
				{
					try
					{
						// http://www.remotesoundboard.com/scripts/sb_poll.php?cmd=play&target=!!!RND&channel=default
						this.httpClient.GetStringAsync(buttonCommand.Command);
					}
					catch
					{
						logger.Error("Couldn't send HTTP request.");
					}
				});
			}
		}
		#endregion

	}
}
