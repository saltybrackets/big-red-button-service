using System;


namespace BigRedButtonService
{
	/// <summary>
	/// Encapsulates a command to be executed.
	/// </summary>
	public sealed class ButtonCommand
	{

		#region Fields
		private CommandType type;
		private string command;
		#endregion


		#region Constructors
		/// <summary>
		/// Create a new ButtonCommand object.
		/// </summary>
		public ButtonCommand()
		{
			this.type = CommandType.None;
			this.command = string.Empty;
		}
		#endregion


		#region Events
		/// <summary>
		/// Raised whenever object values change.
		/// </summary>
		public event Action<ButtonCommand> Changed;
		#endregion


		#region Enums
		/// <summary>
		/// Type of command to be executed.
		/// </summary>
		public enum CommandType
		{
			None,
			Shell,
			HttpRequest
		}
		#endregion


		#region Properties
		/// <summary>
		/// Type of command to execute.
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
