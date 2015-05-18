using System;
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
			InitializeComponent();
			this.buttonController = buttonController;
			ProcessConfig();
			this.buttonController.StartMonitor();
		}
		
		private ConfigForm()
		{
			InitializeComponent();
		}
		#endregion


		protected override void OnLoad(EventArgs eventArgs)
		{
			//this.Visible = false;
			//this.ShowInTaskbar = false;
			base.OnLoad(eventArgs);
		}


		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.WindowsShutDown ||
				e.CloseReason == CloseReason.ApplicationExitCall || 
				e.CloseReason == CloseReason.TaskManagerClosing)
			{
				return;
			}
			e.Cancel = true;
			
			MinimizeToTray();
		}


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


		#region System Tray
		private void exitMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


		private void trayIcon_DoubleClick(object sender, EventArgs e)
		{
			Restore();
		}
		#endregion


		public void MinimizeToTray()
		{
			this.Visible = false;
			this.ShowInTaskbar = false;
		}


		public void Restore()
		{
			this.Visible = true;
			this.ShowInTaskbar = true;
			ProcessConfig();
		}


		// Save button was clicked.
		private void saveButton_Click(object sender, System.EventArgs e)
		{
			this.buttonController.ButtonConfig.Save();
			MinimizeToTray();
		}


		// Update form to match loaded config.
		private void ProcessConfig()
		{
			ButtonConfig config = this.buttonController.ButtonConfig;
			
			this.buttonPressedCommandTextbox.Text = config.ButtonPressedCommand.Command;
			switch (config.ButtonPressedCommand.Type)
			{
				case ButtonCommand.CommandType.None:
					this.buttonPressedNoneOption.Checked = true;
					break;
				case ButtonCommand.CommandType.CommandLine:
					this.buttonPressedShellOption.Checked = true;
					break;
				case ButtonCommand.CommandType.HttpRequest:
					this.buttonPressedHttpOption.Checked = true;
					break;
			}

			this.lidClosedCommandTextbox.Text = config.LidClosedCommand.Command;
			switch (config.LidClosedCommand.Type)
			{
				case ButtonCommand.CommandType.None:
					this.lidClosedNoneOption.Checked = true;
					break;
				case ButtonCommand.CommandType.CommandLine:
					this.lidClosedShellOption.Checked = true;
					break;
				case ButtonCommand.CommandType.HttpRequest:
					this.lidClosedHttpOption.Checked = true;
					break;
			}

			this.lidOpenedCommandTextbox.Text = config.LidOpenedCommand.Command;
			switch (config.LidOpenedCommand.Type)
			{
				case ButtonCommand.CommandType.None:
					this.lidOpenedNoneOption.Checked = true;
					break;
				case ButtonCommand.CommandType.CommandLine:
					this.lidOpenedShellOption.Checked = true;
					break;
				case ButtonCommand.CommandType.HttpRequest:
					this.lidOpenedHttpOption.Checked = true;
					break;
			}
		}

		
	}
}
