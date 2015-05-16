

using System;
using System.Windows.Forms.VisualStyles;


namespace BigRedButtonService
{
	public sealed class ButtonConfig
	{

		#region Constants
		public const string ButtonPressedSection = "Button Pressed";
		public const string LidClosedSection = "Lid Closed";
		public const string LidOpenedSection = "Lid Opened";
		public const string CommandKey = "command";
		public const string TypeKey = "type";
		#endregion


		#region Fields
		private ButtonCommand buttonPressedCommand;
		private string configFile;
		private ButtonCommand lidClosedCommand;
		private ButtonCommand lidOpenedCommand;
		#endregion


		#region Constructors
		/// <summary>
		/// Create a new ButtonConfig, with values loaded/saved to specified file.
		/// </summary>
		/// <param name="file"></param>
		public ButtonConfig(string file)
		{
			this.configFile = file;
			Load();
		}
		#endregion
		

		#region Properties
		/// <summary>
		/// Command to execute whenever Big Red Button is pressed.
		/// </summary>
		public ButtonCommand ButtonPressedCommand
		{
			get { return this.buttonPressedCommand; }
		}


		/// <summary>
		/// Command to execute whenever Big Red Button lid is closed.
		/// </summary>
		public ButtonCommand LidClosedCommand
		{
			get { return this.lidClosedCommand; }
		}


		/// <summary>
		/// Command to execute whenever Big Red Button lid is opened.
		/// </summary>
		public ButtonCommand LidOpenedCommand
		{
			get { return this.lidOpenedCommand; }
		}
		#endregion


		/// <summary>
		/// Load config from file.
		/// </summary>
		/// <returns>ButtonConfig for method chaining.</returns>
		public ButtonConfig Load()
		{
			this.buttonPressedCommand = new ButtonCommand();
			this.lidClosedCommand = new ButtonCommand();
			this.lidOpenedCommand = new ButtonCommand();
			Ini ini = new Ini(this.configFile);

			this.buttonPressedCommand.Type = ParseCommandType(ini.GetValue(TypeKey, ButtonPressedSection));
			this.buttonPressedCommand.Command = ini.GetValue(CommandKey, ButtonPressedSection);

			this.lidClosedCommand.Type = ParseCommandType(ini.GetValue(TypeKey, LidClosedSection));
			this.lidClosedCommand.Command = ini.GetValue(CommandKey, LidClosedSection);

			this.lidOpenedCommand.Type = ParseCommandType(ini.GetValue(TypeKey, LidOpenedSection));
			this.lidOpenedCommand.Command = ini.GetValue(CommandKey, LidOpenedSection);
			
			return this;
		}


		/// <summary>
		/// Save config to file.
		/// </summary>
		/// <returns>ButtonConfig for method chaining.</returns>
		public ButtonConfig Save()
		{
			Ini ini = new Ini(this.configFile);

			ini.WriteValue(TypeKey, ButtonPressedSection, this.buttonPressedCommand.Type.ToString());
			ini.WriteValue(CommandKey, ButtonPressedSection, this.buttonPressedCommand.Command);

			ini.WriteValue(TypeKey, LidClosedSection, this.lidClosedCommand.Type.ToString());
			ini.WriteValue(CommandKey, LidClosedSection, this.lidClosedCommand.Command);

			ini.WriteValue(TypeKey, LidOpenedSection, this.lidOpenedCommand.Type.ToString());
			ini.WriteValue(CommandKey, LidOpenedSection, this.lidOpenedCommand.Command);

			ini.Save();

			return this;
		}


		// Easier way to prase CommandType enums from Ini string values.
		private ButtonCommand.CommandType ParseCommandType(string value)
		{
			ButtonCommand.CommandType commandType;
			ButtonCommand.CommandType.TryParse(value, out commandType);
			return commandType;
		}

	}
}
