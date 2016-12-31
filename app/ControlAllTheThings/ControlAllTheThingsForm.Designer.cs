namespace ControlAllTheThings
{
    partial class ControlAllTheThingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConnectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConnectionStatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.OptionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseSettingsLocationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewLogFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsFileLocationDialog = new System.Windows.Forms.OpenFileDialog();
            this.MinimizeToSystemTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunOnStartup = new System.Windows.Forms.ToolStripMenuItem();
            this.WhiteButton = new ControlAllTheThings.BoardComponents.ButtonComponent();
            this.BlueButton = new ControlAllTheThings.BoardComponents.ButtonComponent();
            this.GreenButton = new ControlAllTheThings.BoardComponents.ButtonComponent();
            this.YellowButton = new ControlAllTheThings.BoardComponents.ButtonComponent();
            this.BlueLatch = new ControlAllTheThings.BoardComponents.ButtonComponent();
            this.WhiteLatch = new ControlAllTheThings.BoardComponents.ButtonComponent();
            this.GreenLatch = new ControlAllTheThings.BoardComponents.ButtonComponent();
            this.YellowLatch = new ControlAllTheThings.BoardComponents.ButtonComponent();
            this.StatusStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTextBox.Location = new System.Drawing.Point(12, 119);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTextBox.Size = new System.Drawing.Size(363, 225);
            this.LogTextBox.TabIndex = 2;
            this.LogTextBox.WordWrap = false;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripSpring,
            this.ConnectionStatusLabel,
            this.ConnectionStatusProgressBar});
            this.StatusStrip.Location = new System.Drawing.Point(0, 353);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(387, 22);
            this.StatusStrip.TabIndex = 5;
            // 
            // StatusStripSpring
            // 
            this.StatusStripSpring.Name = "StatusStripSpring";
            this.StatusStripSpring.Size = new System.Drawing.Size(182, 17);
            this.StatusStripSpring.Spring = true;
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(88, 17);
            this.ConnectionStatusLabel.Text = "Not Connected";
            // 
            // ConnectionStatusProgressBar
            // 
            this.ConnectionStatusProgressBar.MarqueeAnimationSpeed = 50;
            this.ConnectionStatusProgressBar.Name = "ConnectionStatusProgressBar";
            this.ConnectionStatusProgressBar.Size = new System.Drawing.Size(100, 16);
            this.ConnectionStatusProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsMenu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(387, 24);
            this.MenuStrip.TabIndex = 7;
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseSettingsLocationMenuItem,
            this.MinimizeToSystemTrayMenuItem,
            this.RunOnStartup,
            this.ViewLogFileMenuItem});
            this.OptionsMenu.Name = "OptionsMenu";
            this.OptionsMenu.Size = new System.Drawing.Size(61, 20);
            this.OptionsMenu.Text = "Options";
            // 
            // ChooseSettingsLocationMenuItem
            // 
            this.ChooseSettingsLocationMenuItem.Name = "ChooseSettingsLocationMenuItem";
            this.ChooseSettingsLocationMenuItem.Size = new System.Drawing.Size(217, 22);
            this.ChooseSettingsLocationMenuItem.Text = "Choose Settings Location...";
            this.ChooseSettingsLocationMenuItem.Click += new System.EventHandler(this.ChooseSettingsLocation_Click);
            // 
            // ViewLogFileMenuItem
            // 
            this.ViewLogFileMenuItem.Name = "ViewLogFileMenuItem";
            this.ViewLogFileMenuItem.Size = new System.Drawing.Size(217, 22);
            this.ViewLogFileMenuItem.Text = "View Log File";
            this.ViewLogFileMenuItem.Click += new System.EventHandler(this.ViewLogFileMenuItem_Click);
            // 
            // SettingsFileLocationDialog
            // 
            this.SettingsFileLocationDialog.CheckFileExists = false;
            this.SettingsFileLocationDialog.FileName = "settings.json";
            this.SettingsFileLocationDialog.SupportMultiDottedExtensions = true;
            this.SettingsFileLocationDialog.Title = "Choose settings file location:";
            // 
            // MinimizeToSystemTrayMenuItem
            // 
            this.MinimizeToSystemTrayMenuItem.Checked = true;
            this.MinimizeToSystemTrayMenuItem.CheckOnClick = true;
            this.MinimizeToSystemTrayMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MinimizeToSystemTrayMenuItem.Name = "MinimizeToSystemTrayMenuItem";
            this.MinimizeToSystemTrayMenuItem.Size = new System.Drawing.Size(217, 22);
            this.MinimizeToSystemTrayMenuItem.Text = "Minimize to System Tray";
            // 
            // RunOnStartup
            // 
            this.RunOnStartup.CheckOnClick = true;
            this.RunOnStartup.Name = "RunOnStartup";
            this.RunOnStartup.Size = new System.Drawing.Size(217, 22);
            this.RunOnStartup.Text = "Run on Startup";
            this.RunOnStartup.CheckedChanged += new System.EventHandler(this.RunOnStartup_CheckedChanged);
            // 
            // WhiteButton
            // 
            this.WhiteButton.BackColor = System.Drawing.Color.LightGray;
            this.WhiteButton.BoardInterface = null;
            this.WhiteButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WhiteButton.Location = new System.Drawing.Point(150, 27);
            this.WhiteButton.MaximumSize = new System.Drawing.Size(40, 40);
            this.WhiteButton.MinimumSize = new System.Drawing.Size(40, 40);
            this.WhiteButton.Name = "WhiteButton";
            this.WhiteButton.PressedAction = null;
            this.WhiteButton.Size = new System.Drawing.Size(40, 40);
            this.WhiteButton.TabIndex = 13;
            this.WhiteButton.UnpressedAction = null;
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.LightGray;
            this.BlueButton.BoardInterface = null;
            this.BlueButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlueButton.Location = new System.Drawing.Point(104, 27);
            this.BlueButton.MaximumSize = new System.Drawing.Size(40, 40);
            this.BlueButton.MinimumSize = new System.Drawing.Size(40, 40);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.PressedAction = null;
            this.BlueButton.Size = new System.Drawing.Size(40, 40);
            this.BlueButton.TabIndex = 12;
            this.BlueButton.UnpressedAction = null;
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.LightGray;
            this.GreenButton.BoardInterface = null;
            this.GreenButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreenButton.Location = new System.Drawing.Point(58, 27);
            this.GreenButton.MaximumSize = new System.Drawing.Size(40, 40);
            this.GreenButton.MinimumSize = new System.Drawing.Size(40, 40);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.PressedAction = null;
            this.GreenButton.Size = new System.Drawing.Size(40, 40);
            this.GreenButton.TabIndex = 11;
            this.GreenButton.UnpressedAction = null;
            // 
            // YellowButton
            // 
            this.YellowButton.BackColor = System.Drawing.Color.LightGray;
            this.YellowButton.BoardInterface = null;
            this.YellowButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YellowButton.Location = new System.Drawing.Point(12, 27);
            this.YellowButton.MaximumSize = new System.Drawing.Size(40, 40);
            this.YellowButton.MinimumSize = new System.Drawing.Size(40, 40);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.PressedAction = null;
            this.YellowButton.Size = new System.Drawing.Size(40, 40);
            this.YellowButton.TabIndex = 10;
            this.YellowButton.UnpressedAction = null;
            // 
            // BlueLatch
            // 
            this.BlueLatch.BackColor = System.Drawing.Color.LightGray;
            this.BlueLatch.BoardInterface = null;
            this.BlueLatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlueLatch.Location = new System.Drawing.Point(104, 73);
            this.BlueLatch.MaximumSize = new System.Drawing.Size(40, 40);
            this.BlueLatch.MinimumSize = new System.Drawing.Size(40, 40);
            this.BlueLatch.Name = "BlueLatch";
            this.BlueLatch.PressedAction = null;
            this.BlueLatch.Size = new System.Drawing.Size(40, 40);
            this.BlueLatch.TabIndex = 9;
            this.BlueLatch.UnpressedAction = null;
            // 
            // WhiteLatch
            // 
            this.WhiteLatch.BackColor = System.Drawing.Color.LightGray;
            this.WhiteLatch.BoardInterface = null;
            this.WhiteLatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WhiteLatch.Location = new System.Drawing.Point(150, 73);
            this.WhiteLatch.MaximumSize = new System.Drawing.Size(40, 40);
            this.WhiteLatch.MinimumSize = new System.Drawing.Size(40, 40);
            this.WhiteLatch.Name = "WhiteLatch";
            this.WhiteLatch.PressedAction = null;
            this.WhiteLatch.Size = new System.Drawing.Size(40, 40);
            this.WhiteLatch.TabIndex = 8;
            this.WhiteLatch.UnpressedAction = null;
            // 
            // GreenLatch
            // 
            this.GreenLatch.BackColor = System.Drawing.Color.LightGray;
            this.GreenLatch.BoardInterface = null;
            this.GreenLatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreenLatch.Location = new System.Drawing.Point(58, 73);
            this.GreenLatch.MaximumSize = new System.Drawing.Size(40, 40);
            this.GreenLatch.MinimumSize = new System.Drawing.Size(40, 40);
            this.GreenLatch.Name = "GreenLatch";
            this.GreenLatch.PressedAction = null;
            this.GreenLatch.Size = new System.Drawing.Size(40, 40);
            this.GreenLatch.TabIndex = 4;
            this.GreenLatch.UnpressedAction = null;
            // 
            // YellowLatch
            // 
            this.YellowLatch.BackColor = System.Drawing.Color.LightGray;
            this.YellowLatch.BoardInterface = null;
            this.YellowLatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YellowLatch.Location = new System.Drawing.Point(12, 73);
            this.YellowLatch.MaximumSize = new System.Drawing.Size(40, 40);
            this.YellowLatch.MinimumSize = new System.Drawing.Size(40, 40);
            this.YellowLatch.Name = "YellowLatch";
            this.YellowLatch.PressedAction = null;
            this.YellowLatch.Size = new System.Drawing.Size(40, 40);
            this.YellowLatch.TabIndex = 1;
            this.YellowLatch.UnpressedAction = null;
            // 
            // ControlAllTheThingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 375);
            this.Controls.Add(this.WhiteButton);
            this.Controls.Add(this.BlueButton);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.YellowButton);
            this.Controls.Add(this.BlueLatch);
            this.Controls.Add(this.WhiteLatch);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.GreenLatch);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.YellowLatch);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "ControlAllTheThingsForm";
            this.Text = "Control All The Things";
            this.Resize += new System.EventHandler(this.ControlAllTheThingsForm_Resize);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BoardComponents.ButtonComponent YellowLatch;
        private System.Windows.Forms.TextBox LogTextBox;
        private BoardComponents.ButtonComponent GreenLatch;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripSpring;
        private System.Windows.Forms.ToolStripStatusLabel ConnectionStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar ConnectionStatusProgressBar;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenu;
        private BoardComponents.ButtonComponent WhiteLatch;
        private BoardComponents.ButtonComponent BlueLatch;
        private BoardComponents.ButtonComponent YellowButton;
        private BoardComponents.ButtonComponent GreenButton;
        private BoardComponents.ButtonComponent BlueButton;
        private BoardComponents.ButtonComponent WhiteButton;
        private System.Windows.Forms.ToolStripMenuItem ChooseSettingsLocationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewLogFileMenuItem;
        private System.Windows.Forms.OpenFileDialog SettingsFileLocationDialog;
        private System.Windows.Forms.ToolStripMenuItem MinimizeToSystemTrayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunOnStartup;

    }
}

