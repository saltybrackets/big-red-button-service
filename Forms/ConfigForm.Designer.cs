namespace BigRedButtonService
{
	partial class ConfigForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonPressedCommandTextbox = new System.Windows.Forms.TextBox();
			this.buttonPressedGroup = new System.Windows.Forms.GroupBox();
			this.buttonPressedTypeLabel = new System.Windows.Forms.Label();
			this.buttonPressedNoneOption = new System.Windows.Forms.RadioButton();
			this.buttonPressedHttpOption = new System.Windows.Forms.RadioButton();
			this.buttonPressedShellOption = new System.Windows.Forms.RadioButton();
			this.buttonPressedCommandLabel = new System.Windows.Forms.Label();
			this.lidOpenedGroup = new System.Windows.Forms.GroupBox();
			this.lidOpenedTypeLabel = new System.Windows.Forms.Label();
			this.lidOpenedNoneOption = new System.Windows.Forms.RadioButton();
			this.lidOpenedHttpOption = new System.Windows.Forms.RadioButton();
			this.lidOpenedShellOption = new System.Windows.Forms.RadioButton();
			this.lidOpenedCommandLabel = new System.Windows.Forms.Label();
			this.lidOpenedCommandTextbox = new System.Windows.Forms.TextBox();
			this.lidClosedGroup = new System.Windows.Forms.GroupBox();
			this.lidClosedTypeLabel = new System.Windows.Forms.Label();
			this.lidClosedNoneOption = new System.Windows.Forms.RadioButton();
			this.lidClosedHttpOption = new System.Windows.Forms.RadioButton();
			this.lidClosedShellOption = new System.Windows.Forms.RadioButton();
			this.lidClosedCommandLabel = new System.Windows.Forms.Label();
			this.lidClosedCommandTextbox = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.buttonPressedGroup.SuspendLayout();
			this.lidOpenedGroup.SuspendLayout();
			this.lidClosedGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonPressedCommandTextbox
			// 
			this.buttonPressedCommandTextbox.Enabled = false;
			this.buttonPressedCommandTextbox.Location = new System.Drawing.Point(72, 51);
			this.buttonPressedCommandTextbox.Name = "buttonPressedCommandTextbox";
			this.buttonPressedCommandTextbox.Size = new System.Drawing.Size(365, 20);
			this.buttonPressedCommandTextbox.TabIndex = 2;
			this.buttonPressedCommandTextbox.Leave += new System.EventHandler(this.buttonPressedCommandTextbox_Leave);
			// 
			// buttonPressedGroup
			// 
			this.buttonPressedGroup.Controls.Add(this.buttonPressedTypeLabel);
			this.buttonPressedGroup.Controls.Add(this.buttonPressedNoneOption);
			this.buttonPressedGroup.Controls.Add(this.buttonPressedHttpOption);
			this.buttonPressedGroup.Controls.Add(this.buttonPressedShellOption);
			this.buttonPressedGroup.Controls.Add(this.buttonPressedCommandLabel);
			this.buttonPressedGroup.Controls.Add(this.buttonPressedCommandTextbox);
			this.buttonPressedGroup.Location = new System.Drawing.Point(12, 12);
			this.buttonPressedGroup.Name = "buttonPressedGroup";
			this.buttonPressedGroup.Size = new System.Drawing.Size(443, 83);
			this.buttonPressedGroup.TabIndex = 3;
			this.buttonPressedGroup.TabStop = false;
			this.buttonPressedGroup.Text = "Button Pressed Command";
			// 
			// buttonPressedTypeLabel
			// 
			this.buttonPressedTypeLabel.AutoSize = true;
			this.buttonPressedTypeLabel.Location = new System.Drawing.Point(9, 30);
			this.buttonPressedTypeLabel.Name = "buttonPressedTypeLabel";
			this.buttonPressedTypeLabel.Size = new System.Drawing.Size(34, 13);
			this.buttonPressedTypeLabel.TabIndex = 7;
			this.buttonPressedTypeLabel.Text = "Type:";
			this.buttonPressedTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonPressedNoneOption
			// 
			this.buttonPressedNoneOption.AutoSize = true;
			this.buttonPressedNoneOption.Checked = true;
			this.buttonPressedNoneOption.Location = new System.Drawing.Point(72, 28);
			this.buttonPressedNoneOption.Name = "buttonPressedNoneOption";
			this.buttonPressedNoneOption.Size = new System.Drawing.Size(51, 17);
			this.buttonPressedNoneOption.TabIndex = 6;
			this.buttonPressedNoneOption.TabStop = true;
			this.buttonPressedNoneOption.Text = "None";
			this.buttonPressedNoneOption.UseVisualStyleBackColor = true;
			this.buttonPressedNoneOption.CheckedChanged += new System.EventHandler(this.buttonPressedNoneOption_CheckedChanged);
			// 
			// buttonPressedHttpOption
			// 
			this.buttonPressedHttpOption.AutoSize = true;
			this.buttonPressedHttpOption.Location = new System.Drawing.Point(180, 28);
			this.buttonPressedHttpOption.Name = "buttonPressedHttpOption";
			this.buttonPressedHttpOption.Size = new System.Drawing.Size(54, 17);
			this.buttonPressedHttpOption.TabIndex = 5;
			this.buttonPressedHttpOption.TabStop = true;
			this.buttonPressedHttpOption.Text = "HTTP";
			this.buttonPressedHttpOption.UseVisualStyleBackColor = true;
			this.buttonPressedHttpOption.CheckedChanged += new System.EventHandler(this.buttonPressedHttpOption_CheckedChanged);
			// 
			// buttonPressedShellOption
			// 
			this.buttonPressedShellOption.AutoSize = true;
			this.buttonPressedShellOption.Location = new System.Drawing.Point(126, 28);
			this.buttonPressedShellOption.Name = "buttonPressedShellOption";
			this.buttonPressedShellOption.Size = new System.Drawing.Size(48, 17);
			this.buttonPressedShellOption.TabIndex = 4;
			this.buttonPressedShellOption.TabStop = true;
			this.buttonPressedShellOption.Text = "Shell";
			this.buttonPressedShellOption.UseVisualStyleBackColor = true;
			this.buttonPressedShellOption.CheckedChanged += new System.EventHandler(this.buttonPressedShellOption_CheckedChanged);
			// 
			// buttonPressedCommandLabel
			// 
			this.buttonPressedCommandLabel.AutoSize = true;
			this.buttonPressedCommandLabel.Location = new System.Drawing.Point(9, 54);
			this.buttonPressedCommandLabel.Name = "buttonPressedCommandLabel";
			this.buttonPressedCommandLabel.Size = new System.Drawing.Size(57, 13);
			this.buttonPressedCommandLabel.TabIndex = 3;
			this.buttonPressedCommandLabel.Text = "Command:";
			this.buttonPressedCommandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lidOpenedGroup
			// 
			this.lidOpenedGroup.Controls.Add(this.lidOpenedTypeLabel);
			this.lidOpenedGroup.Controls.Add(this.lidOpenedNoneOption);
			this.lidOpenedGroup.Controls.Add(this.lidOpenedHttpOption);
			this.lidOpenedGroup.Controls.Add(this.lidOpenedShellOption);
			this.lidOpenedGroup.Controls.Add(this.lidOpenedCommandLabel);
			this.lidOpenedGroup.Controls.Add(this.lidOpenedCommandTextbox);
			this.lidOpenedGroup.Location = new System.Drawing.Point(12, 110);
			this.lidOpenedGroup.Name = "lidOpenedGroup";
			this.lidOpenedGroup.Size = new System.Drawing.Size(443, 83);
			this.lidOpenedGroup.TabIndex = 3;
			this.lidOpenedGroup.TabStop = false;
			this.lidOpenedGroup.Text = "Lid Opened Command";
			// 
			// lidOpenedTypeLabel
			// 
			this.lidOpenedTypeLabel.AutoSize = true;
			this.lidOpenedTypeLabel.Location = new System.Drawing.Point(9, 30);
			this.lidOpenedTypeLabel.Name = "lidOpenedTypeLabel";
			this.lidOpenedTypeLabel.Size = new System.Drawing.Size(34, 13);
			this.lidOpenedTypeLabel.TabIndex = 7;
			this.lidOpenedTypeLabel.Text = "Type:";
			this.lidOpenedTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lidOpenedNoneOption
			// 
			this.lidOpenedNoneOption.AutoSize = true;
			this.lidOpenedNoneOption.Checked = true;
			this.lidOpenedNoneOption.Location = new System.Drawing.Point(72, 28);
			this.lidOpenedNoneOption.Name = "lidOpenedNoneOption";
			this.lidOpenedNoneOption.Size = new System.Drawing.Size(51, 17);
			this.lidOpenedNoneOption.TabIndex = 6;
			this.lidOpenedNoneOption.TabStop = true;
			this.lidOpenedNoneOption.Text = "None";
			this.lidOpenedNoneOption.UseVisualStyleBackColor = true;
			this.lidOpenedNoneOption.CheckedChanged += new System.EventHandler(this.lidOpenedNoneOption_CheckedChanged);
			// 
			// lidOpenedHttpOption
			// 
			this.lidOpenedHttpOption.AutoSize = true;
			this.lidOpenedHttpOption.Location = new System.Drawing.Point(180, 28);
			this.lidOpenedHttpOption.Name = "lidOpenedHttpOption";
			this.lidOpenedHttpOption.Size = new System.Drawing.Size(54, 17);
			this.lidOpenedHttpOption.TabIndex = 5;
			this.lidOpenedHttpOption.Text = "HTTP";
			this.lidOpenedHttpOption.UseVisualStyleBackColor = true;
			this.lidOpenedHttpOption.CheckedChanged += new System.EventHandler(this.lidOpenedHttpOption_CheckedChanged);
			// 
			// lidOpenedShellOption
			// 
			this.lidOpenedShellOption.AutoSize = true;
			this.lidOpenedShellOption.Location = new System.Drawing.Point(126, 28);
			this.lidOpenedShellOption.Name = "lidOpenedShellOption";
			this.lidOpenedShellOption.Size = new System.Drawing.Size(48, 17);
			this.lidOpenedShellOption.TabIndex = 4;
			this.lidOpenedShellOption.Text = "Shell";
			this.lidOpenedShellOption.UseVisualStyleBackColor = true;
			this.lidOpenedShellOption.CheckedChanged += new System.EventHandler(this.lidOpenedShellOption_CheckedChanged);
			// 
			// lidOpenedCommandLabel
			// 
			this.lidOpenedCommandLabel.AutoSize = true;
			this.lidOpenedCommandLabel.Location = new System.Drawing.Point(9, 54);
			this.lidOpenedCommandLabel.Name = "lidOpenedCommandLabel";
			this.lidOpenedCommandLabel.Size = new System.Drawing.Size(57, 13);
			this.lidOpenedCommandLabel.TabIndex = 3;
			this.lidOpenedCommandLabel.Text = "Command:";
			this.lidOpenedCommandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lidOpenedCommandTextbox
			// 
			this.lidOpenedCommandTextbox.Enabled = false;
			this.lidOpenedCommandTextbox.Location = new System.Drawing.Point(72, 51);
			this.lidOpenedCommandTextbox.Name = "lidOpenedCommandTextbox";
			this.lidOpenedCommandTextbox.Size = new System.Drawing.Size(365, 20);
			this.lidOpenedCommandTextbox.TabIndex = 2;
			this.lidOpenedCommandTextbox.Leave += new System.EventHandler(this.lidOpenedCommandTextbox_Leave);
			// 
			// lidClosedGroup
			// 
			this.lidClosedGroup.Controls.Add(this.lidClosedTypeLabel);
			this.lidClosedGroup.Controls.Add(this.lidClosedNoneOption);
			this.lidClosedGroup.Controls.Add(this.lidClosedHttpOption);
			this.lidClosedGroup.Controls.Add(this.lidClosedShellOption);
			this.lidClosedGroup.Controls.Add(this.lidClosedCommandLabel);
			this.lidClosedGroup.Controls.Add(this.lidClosedCommandTextbox);
			this.lidClosedGroup.Location = new System.Drawing.Point(12, 208);
			this.lidClosedGroup.Name = "lidClosedGroup";
			this.lidClosedGroup.Size = new System.Drawing.Size(443, 83);
			this.lidClosedGroup.TabIndex = 8;
			this.lidClosedGroup.TabStop = false;
			this.lidClosedGroup.Text = "Lid Closed Command";
			// 
			// lidClosedTypeLabel
			// 
			this.lidClosedTypeLabel.AutoSize = true;
			this.lidClosedTypeLabel.Location = new System.Drawing.Point(9, 30);
			this.lidClosedTypeLabel.Name = "lidClosedTypeLabel";
			this.lidClosedTypeLabel.Size = new System.Drawing.Size(34, 13);
			this.lidClosedTypeLabel.TabIndex = 7;
			this.lidClosedTypeLabel.Text = "Type:";
			this.lidClosedTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lidClosedNoneOption
			// 
			this.lidClosedNoneOption.AutoSize = true;
			this.lidClosedNoneOption.Checked = true;
			this.lidClosedNoneOption.Location = new System.Drawing.Point(72, 28);
			this.lidClosedNoneOption.Name = "lidClosedNoneOption";
			this.lidClosedNoneOption.Size = new System.Drawing.Size(51, 17);
			this.lidClosedNoneOption.TabIndex = 6;
			this.lidClosedNoneOption.TabStop = true;
			this.lidClosedNoneOption.Text = "None";
			this.lidClosedNoneOption.UseVisualStyleBackColor = true;
			this.lidClosedNoneOption.CheckedChanged += new System.EventHandler(this.lidClosedNoneOption_CheckedChanged);
			// 
			// lidClosedHttpOption
			// 
			this.lidClosedHttpOption.AutoSize = true;
			this.lidClosedHttpOption.Location = new System.Drawing.Point(180, 28);
			this.lidClosedHttpOption.Name = "lidClosedHttpOption";
			this.lidClosedHttpOption.Size = new System.Drawing.Size(54, 17);
			this.lidClosedHttpOption.TabIndex = 5;
			this.lidClosedHttpOption.TabStop = true;
			this.lidClosedHttpOption.Text = "HTTP";
			this.lidClosedHttpOption.UseVisualStyleBackColor = true;
			this.lidClosedHttpOption.CheckedChanged += new System.EventHandler(this.lidClosedHttpOption_CheckedChanged);
			// 
			// lidClosedShellOption
			// 
			this.lidClosedShellOption.AutoSize = true;
			this.lidClosedShellOption.Location = new System.Drawing.Point(126, 28);
			this.lidClosedShellOption.Name = "lidClosedShellOption";
			this.lidClosedShellOption.Size = new System.Drawing.Size(48, 17);
			this.lidClosedShellOption.TabIndex = 4;
			this.lidClosedShellOption.TabStop = true;
			this.lidClosedShellOption.Text = "Shell";
			this.lidClosedShellOption.UseVisualStyleBackColor = true;
			this.lidClosedShellOption.CheckedChanged += new System.EventHandler(this.lidClosedShellOption_CheckedChanged);
			// 
			// lidClosedCommandLabel
			// 
			this.lidClosedCommandLabel.AutoSize = true;
			this.lidClosedCommandLabel.Location = new System.Drawing.Point(9, 54);
			this.lidClosedCommandLabel.Name = "lidClosedCommandLabel";
			this.lidClosedCommandLabel.Size = new System.Drawing.Size(57, 13);
			this.lidClosedCommandLabel.TabIndex = 3;
			this.lidClosedCommandLabel.Text = "Command:";
			this.lidClosedCommandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lidClosedCommandTextbox
			// 
			this.lidClosedCommandTextbox.Enabled = false;
			this.lidClosedCommandTextbox.Location = new System.Drawing.Point(72, 51);
			this.lidClosedCommandTextbox.Name = "lidClosedCommandTextbox";
			this.lidClosedCommandTextbox.Size = new System.Drawing.Size(365, 20);
			this.lidClosedCommandTextbox.TabIndex = 2;
			this.lidClosedCommandTextbox.Leave += new System.EventHandler(this.lidClosedCommandTextbox_Leave);
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveButton.Location = new System.Drawing.Point(368, 297);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(87, 33);
			this.saveButton.TabIndex = 9;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// ConfigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 337);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.lidClosedGroup);
			this.Controls.Add(this.lidOpenedGroup);
			this.Controls.Add(this.buttonPressedGroup);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConfigForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Big Red Button Config";
			this.buttonPressedGroup.ResumeLayout(false);
			this.buttonPressedGroup.PerformLayout();
			this.lidOpenedGroup.ResumeLayout(false);
			this.lidOpenedGroup.PerformLayout();
			this.lidClosedGroup.ResumeLayout(false);
			this.lidClosedGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox buttonPressedCommandTextbox;
		private System.Windows.Forms.GroupBox buttonPressedGroup;
		private System.Windows.Forms.RadioButton buttonPressedNoneOption;
		private System.Windows.Forms.RadioButton buttonPressedHttpOption;
		private System.Windows.Forms.RadioButton buttonPressedShellOption;
		private System.Windows.Forms.Label buttonPressedCommandLabel;
		private System.Windows.Forms.Label buttonPressedTypeLabel;
		private System.Windows.Forms.GroupBox lidOpenedGroup;
		private System.Windows.Forms.Label lidOpenedTypeLabel;
		private System.Windows.Forms.RadioButton lidOpenedNoneOption;
		private System.Windows.Forms.RadioButton lidOpenedHttpOption;
		private System.Windows.Forms.RadioButton lidOpenedShellOption;
		private System.Windows.Forms.Label lidOpenedCommandLabel;
		private System.Windows.Forms.TextBox lidOpenedCommandTextbox;
		private System.Windows.Forms.GroupBox lidClosedGroup;
		private System.Windows.Forms.Label lidClosedTypeLabel;
		private System.Windows.Forms.RadioButton lidClosedNoneOption;
		private System.Windows.Forms.RadioButton lidClosedHttpOption;
		private System.Windows.Forms.RadioButton lidClosedShellOption;
		private System.Windows.Forms.Label lidClosedCommandLabel;
		private System.Windows.Forms.TextBox lidClosedCommandTextbox;
		private System.Windows.Forms.Button saveButton;
	}
}

