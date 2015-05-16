using System;
using System.Threading;
using log4net;


namespace BigRedButtonService
{
    public class ButtonMonitor
	{
		#region Fields
	    private static ILog logger = LogManager.GetLogger(typeof (ButtonMonitor));

		private readonly BigRedButton bigRedButton;
        private volatile bool terminated;
		private Thread thread;
		private volatile int updateInterval;
		#endregion


		#region Constructors
		public ButtonMonitor()
			: this(100)
        {
            
        }

	    public ButtonMonitor(int updateInterval)
	    {
			this.bigRedButton = new BigRedButton();
		    this.updateInterval = updateInterval;
	    }
		#endregion


		#region Events
		public event Action LidOpened;
		public event Action LidClosed;
		public event Action ButtonPressed;
		#endregion


		#region Properties
	    /// <summary>
	    /// Interval (in milliseconds) at which button state will be checked.
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
            this.bigRedButton.Open();
            thread = new Thread(PollDeviceStatus);
            thread.Start();
        }


		/// <summary>
		/// Stop monitoring button state.
		/// </summary>
		public void Stop()
		{
			this.terminated = true;
			thread.Join();
			this.bigRedButton.Close();
		}


		// Polls device state and raises appropriate events.
        private void PollDeviceStatus()
        {
            ButtonState lastStatus = ButtonState.Unknown;

			// Poll device state.
            while (!terminated)
            {
                ButtonState status = this.bigRedButton.GetStatus();
	            if (status != ButtonState.Errored)
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
	            }

				// Couldn't read device for some reason.
	            else
	            {
					logger.Error("Could not read device state.");
	            }

				lastStatus = status;
                Thread.Sleep(updateInterval);
            }
			logger.Info("Exit monitor thread.");
		}

	}
}
