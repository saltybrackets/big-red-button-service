using System;
using System.Threading;
using System.Threading.Tasks;

using log4net;


namespace BigRedButtonService
{
	/// <summary>
	/// Regularly polls Big Red Button device for updates.
	/// </summary>
    public sealed class ButtonMonitor
	{

		#region Constants
		public const int DetectDeviceInterval = 2000;
		public const int DefaultPollingInterval = 100;
		#endregion


		#region Fields
		private static ILog logger = LogManager.GetLogger(typeof (ButtonMonitor));

		private readonly BigRedButton bigRedButton;
        private volatile bool terminated;
		private Thread pollingThread;
		private volatile int updateInterval;
		#endregion


		#region Constructors
		/// <summary>
		/// Instantiate ButtonMonitor with default polling interval.
		/// </summary>
		public ButtonMonitor()
			: this(DefaultPollingInterval)
        {
            
        }


		/// <summary>
		/// Instantiate ButtonMonitor with specified polling interval.
		/// </summary>
		/// <param name="updateInterval"></param>
	    public ButtonMonitor(int updateInterval)
	    {
			this.bigRedButton = new BigRedButton();
		    this.updateInterval = updateInterval;
	    }
		#endregion


		#region Events
		/// <summary>
		/// Raised when Big Red Button device's lid is opened.
		/// </summary>
		public event Action LidOpened;

		/// <summary>
		/// Raised when Big Red Button device's lid is closed.
		/// </summary>
		public event Action LidClosed;

		/// <summary>
		/// Raised when Big Red Button device's button is pressed.
		/// </summary>
		public event Action ButtonPressed;
		#endregion


		#region Properties
	    /// <summary>
	    /// Interval (in milliseconds) at which button state will be checked.
	    /// Default interval is 100 milliseconds.
	    /// </summary>
		public int UpdateInterval
	    {
		    get { return this.updateInterval; }
		    set { this.updateInterval = value; }
	    }
	    #endregion


		/// <summary>
		/// Start monitoring button state.
		/// </summary>
		public void Start()
		{
			if (this.pollingThread == null)
			{
				this.pollingThread = new Thread(PollDeviceStatus);
				this.pollingThread.Start();
			}
        }


		/// <summary>
		/// Stop monitoring button state.
		/// </summary>
		public void Stop()
		{
			if (this.pollingThread != null)
			{
				this.terminated = true;
				this.pollingThread.Join();
				this.bigRedButton.Close();	
			}
		}


		// Try to open device for communication.
		private void OpenDevice()
		{
			if (terminated)
				return;

			logger.Info("Trying to open device for communication...");
			
			// Couldn't open, delay and retry.
			if (!this.bigRedButton.Open())
			{
				Thread.Sleep(DetectDeviceInterval);
				OpenDevice();
			}
		}


		// Polls device state and raises appropriate events.
        private void PollDeviceStatus()
        {
            ButtonState lastStatus = ButtonState.Unknown;

			// Poll device state.
            while (!terminated)
            {
                ButtonState status = this.bigRedButton.GetStatus();
	            if (status != ButtonState.Errored && status != ButtonState.Inactive)
	            {
		            if (status == ButtonState.LidClosed && lastStatus == ButtonState.LidOpened)
		            {
						logger.Info("Lid closed.");
						if (LidClosed != null)
							LidClosed();
		            }
		            else if (status == ButtonState.ButtonPressed && lastStatus != ButtonState.ButtonPressed)
		            {
						logger.Info("Button pressed.");
						if (ButtonPressed != null)
							ButtonPressed();
		            }
		            else if (status == ButtonState.LidOpened && lastStatus == ButtonState.LidClosed)
		            {
			            logger.Info("Lid Opened");
			            if (LidOpened != null)
				            LidOpened();
		            }

					lastStatus = status;
					Thread.Sleep(updateInterval);
	            }

				// Device not open for communication.
	            else 
	            {
		            OpenDevice();
	            }
            }

			logger.Info("Exited polling thread.");
		}

	}
}
