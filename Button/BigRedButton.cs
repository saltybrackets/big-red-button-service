using System;
using System.Linq;
using HidLibrary;
using log4net;


namespace BigRedButtonService
{
    public sealed class BigRedButton
	{

		#region Constants
		private const int DefaultVendorId = 0x1D34;
		private const int DefaultProductId = 0x000D;
		private readonly byte[] statusCommand = { 0, 0, 0, 0, 0, 0, 0, 0, 2 };
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
			logger.Info("Button device closed.");
			this.device.CloseDevice();
		}


		/// <summary>
		/// Open communication with device.
		/// </summary>
		public void Open()
		{
			logger.Info("Button device opened.");
			Open(DefaultVendorId, DefaultProductId);
		}


		/// <summary>
		/// Open communicatio with specified device.
		/// </summary>
		/// <param name="vendorId">Numerical vendor ID.</param>
		/// <param name="productId">Numerical product ID.</param>
	    public void Open(int vendorId, int productId)
	    {
			this.device = HidDevices.Enumerate(vendorId, productId).FirstOrDefault();
			if (this.device == null)
			{
				logger.Error("Button device not found.");
				throw new InvalidOperationException("Device not found");
			}
			
			this.device.OpenDevice(DeviceMode.Overlapped, DeviceMode.Overlapped);
	    }


		/// <summary>
		/// Get status of the button.
		/// </summary>
		/// <returns>Status of the button.</returns>
        public ButtonState GetStatus()
		{
			if (!device.IsOpen)
			{
				logger.Error("Tried to read button state while device is closed.");
				return ButtonState.Errored;
			}

			if (!device.Write(statusCommand, 100))
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
