using System;
using System.Linq;
using HidLibrary;
using log4net;


namespace BigRedButtonService
{
	/// <summary>
	/// Object to interface with Dream Cheeky's Big Red Button device.
	/// </summary>
    public sealed class BigRedButton
	{

		#region Constants
		public const int DefaultVendorId = 0x1D34;
		public const int DefaultProductId = 0x000D;
		public static readonly byte[] StatusCommand = { 0, 0, 0, 0, 0, 0, 0, 0, 2 };
		#endregion


		#region Fields
	    private static ILog logger = LogManager.GetLogger(typeof (BigRedButton));
		
		private HidDevice device;
		#endregion


		/// <summary>
		/// Close communication with device.
		/// </summary>
		public void Close()
		{
			if (this.device != null)
			{
				this.device.CloseDevice();
				logger.Info("Button device closed.");
			}
			
		}


		/// <summary>
		/// Open communication with device.
		/// </summary>
		public bool Open()
		{
			return Open(DefaultVendorId, DefaultProductId);
		}


		/// <summary>
		/// Open communicatio with specified device.
		/// </summary>
		/// <param name="vendorId">Numerical vendor ID.</param>
		/// <param name="productId">Numerical product ID.</param>
	    public bool Open(int vendorId, int productId)
	    {
			this.device = HidDevices.Enumerate(vendorId, productId).FirstOrDefault();
			if (this.device == null)
			{
				logger.Warn("Button device not found.");
				return false;
			}
			
			this.device.OpenDevice(DeviceMode.Overlapped, DeviceMode.Overlapped);
			logger.Info("Button device opened.");
			return true;
	    }


		/// <summary>
		/// Get status of the button.
		/// </summary>
		/// <returns>Status of the button.</returns>
        public ButtonState GetStatus()
		{
			if (device == null)
				return ButtonState.Inactive;
			
			if (!device.IsOpen)
			{
				logger.Error("Tried to read button state while device is closed.");
				return ButtonState.Errored;
			}

			if (!device.Write(StatusCommand, 100))
			{
				logger.Error("Could not communicate with button device.");
				return ButtonState.Errored;
			}

            HidDeviceData data = device.Read(100);
			if (data.Status != HidDeviceData.ReadStatus.Success)
			{
				logger.Error("Device read timed out.");
				return ButtonState.Errored;
			}

            return (ButtonState)data.Data[1];
        }
    }
}
