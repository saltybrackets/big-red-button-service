using System.Windows.Forms;


namespace BigRedButtonService
{
	public partial class ConfigForm : Form
	{

		#region Fields
		private ButtonController buttonController;
		#endregion


		#region Constructors
		public ConfigForm(ButtonController buttonController)
		{
			this.buttonController = buttonController;
			this.buttonController.StartMonitor();
			InitializeComponent();
		}
		
		private ConfigForm()
		{
			InitializeComponent();
		}
		#endregion


		#region Button Pressed Group
		// Selected None radio button.
		private void buttonPressedNoneOption_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.buttonPressedNoneOption.Checked)
			{
				this.buttonPressedCommandTextbox.Enabled = false;
				this.buttonController.ButtonConfig.ButtonPressedCommand.Type = ButtonCommand.CommandType.None;
			}

			else
			{
				this.buttonPressedCommandTextbox.Enabled = true;
			}	
		}


		// Selected Shell radio button.
		private void buttonPressedShellOption_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.buttonPressedShellOption.Checked)
				this.buttonController.ButtonConfig.ButtonPressedCommand.Type = ButtonCommand.CommandType.CommandLine;
		}


		// Selected HTTP radio button.
		private void buttonPressedHttpOption_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.buttonPressedHttpOption.Checked)
				this.buttonController.ButtonConfig.ButtonPressedCommand.Type = ButtonCommand.CommandType.HttpRequest;
		}


		// Command textbox lost focus.
		private void buttonPressedCommandTextbox_Leave(object sender, System.EventArgs e)
		{
			this.buttonController.ButtonConfig.ButtonPressedCommand.Command = this.buttonPressedCommandTextbox.Text;
		}
		#endregion


		#region Lid Closed Group
		// Selected None radio button.
		private void lidClosedNoneOption_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.lidClosedNoneOption.Checked)
			{
				this.lidClosedCommandTextbox.Enabled = false;
				this.buttonController.ButtonConfig.LidClosedCommand.Type = ButtonCommand.CommandType.None;
			}

			else
			{
				this.lidClosedCommandTextbox.Enabled = true;
			}
		}


		// Selected Shell radio button.
		private void lidClosedShellOption_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.lidClosedShellOption.Checked)
				this.buttonController.ButtonConfig.LidClosedCommand.Type = ButtonCommand.CommandType.CommandLine;
		}


		// Selected HTTP radio button.
		private void lidClosedHttpOption_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.lidClosedHttpOption.Checked)
				this.buttonController.ButtonConfig.LidClosedCommand.Type = ButtonCommand.CommandType.HttpRequest;
		}


		// Command textbox lost focus.
		private void lidClosedCommandTextbox_Leave(object sender, System.EventArgs e)
		{
			this.buttonController.ButtonConfig.LidClosedCommand.Command = this.lidClosedCommandTextbox.Text;
		}
		#endregion


		#region Lid Opened Group
		// Selected None radio button.
		private void lidOpenedNoneOption_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.lidOpenedNoneOption.Checked)
			{
				this.lidOpenedCommandTextbox.Enabled = false;
				this.buttonController.ButtonConfig.LidOpenedCommand.Type = ButtonCommand.CommandType.None;
			}

			else
			{
				this.lidOpenedCommandTextbox.Enabled = true;
			}
		}


		// Selected Shell radio button.
		private void lidOpenedShellOption_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.lidOpenedShellOption.Checked)
				this.buttonController.ButtonConfig.LidOpenedCommand.Type = ButtonCommand.CommandType.CommandLine;
		}


		// Selected HTTP radio button.
		private void lidOpenedHttpOption_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.lidOpenedHttpOption.Checked)
				this.buttonController.ButtonConfig.LidOpenedCommand.Type = ButtonCommand.CommandType.HttpRequest;
		}


		// Command textbox lost focus.
		private void lidOpenedCommandTextbox_Leave(object sender, System.EventArgs e)
		{
			this.buttonController.ButtonConfig.LidOpenedCommand.Command = this.lidOpenedCommandTextbox.Text;
		}
		#endregion
		


	}
}
