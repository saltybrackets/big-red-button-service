using System;


namespace BigRedButtonService
{
	public class ButtonCommand
	{

		#region Fields
		private CommandType type;
		private string command;
		#endregion


		#region Constructors
		public ButtonCommand()
		{
			this.type = CommandType.None;
			this.command = string.Empty;
		}
		#endregion


		#region Events
		public event Action<ButtonCommand> Changed;
		#endregion


		#region Enums
		public enum CommandType
		{
			None,
			HttpRequest,
			CommandLine
		}
		#endregion


		#region Properties
		/// <summary>
		/// Type of command.
		/// </summary>
		public CommandType Type
		{
			get { return this.type; }
			set
			{
				if (this.type != value)
				{
					this.type = value;
					if (Changed != null)
						Changed(this);
				}
			}
		}


		/// <summary>
		/// Command to execute.
		/// </summary>
		public string Command
		{
			get { return this.command; }
			set
			{
				if (this.Command != value)
				{
					this.command = value;
					if (Changed != null)
						Changed(this);
				}
			}
		}
		#endregion

	}
}
