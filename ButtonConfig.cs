

namespace BigRedButtonService
{
	public class ButtonConfig
	{

		#region Fields
		private ButtonCommand buttonPressedCommand;
		private ButtonCommand lidClosedCommand;
		private ButtonCommand lidOpenedCommand;
		#endregion


		#region Constructors
		public ButtonConfig()
		{
			this.buttonPressedCommand = new ButtonCommand();
			this.lidClosedCommand = new ButtonCommand();
			this.lidOpenedCommand = new ButtonCommand();
		}
		#endregion
		

		#region Properties
		public ButtonCommand ButtonPressedCommand
		{
			get { return this.buttonPressedCommand; }
		}

		public ButtonCommand LidClosedCommand
		{
			get { return this.lidClosedCommand; }
		}

		public ButtonCommand LidOpenedCommand
		{
			get { return this.lidOpenedCommand; }
		}
		#endregion

	}
}
