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
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConnectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConnectionStatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.OptionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseSettingsLocationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewLogFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.MinimizeToSystemTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunOnStartup = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsFileLocationDialog = new System.Windows.Forms.OpenFileDialog();
            this.BoardPanel = new System.Windows.Forms.Panel();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.WhiteLatch = new ControlAllTheThings.BoardComponents.LedButtonComponent();
            this.BlueLatch = new ControlAllTheThings.BoardComponents.LedButtonComponent();
            this.GreenLatch = new ControlAllTheThings.BoardComponents.LedButtonComponent();
            this.YellowLatch = new ControlAllTheThings.BoardComponents.LedButtonComponent();
            this.WhiteButton = new ControlAllTheThings.BoardComponents.LedButtonComponent();
            this.BlueButton = new ControlAllTheThings.BoardComponents.LedButtonComponent();
            this.GreenButton = new ControlAllTheThings.BoardComponents.LedButtonComponent();
            this.YellowButton = new ControlAllTheThings.BoardComponents.LedButtonComponent();
            this.StatusStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.BoardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripSpring,
            this.ConnectionStatusLabel,
            this.ConnectionStatusProgressBar});
            this.StatusStrip.Location = new System.Drawing.Point(0, 359);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(494, 22);
            this.StatusStrip.TabIndex = 5;
            // 
            // StatusStripSpring
            // 
            this.StatusStripSpring.Name = "StatusStripSpring";
            this.StatusStripSpring.Size = new System.Drawing.Size(289, 17);
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
            this.MenuStrip.Size = new System.Drawing.Size(494, 24);
            this.MenuStrip.TabIndex = 7;
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseSettingsLocationMenuItem,
            this.ViewLogFileMenuItem,
            this.OptionsMenuSeparator,
            this.MinimizeToSystemTrayMenuItem,
            this.RunOnStartup});
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
            // OptionsMenuSeparator
            // 
            this.OptionsMenuSeparator.Name = "OptionsMenuSeparator";
            this.OptionsMenuSeparator.Size = new System.Drawing.Size(214, 6);
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
            // SettingsFileLocationDialog
            // 
            this.SettingsFileLocationDialog.CheckFileExists = false;
            this.SettingsFileLocationDialog.FileName = "settings.json";
            this.SettingsFileLocationDialog.SupportMultiDottedExtensions = true;
            this.SettingsFileLocationDialog.Title = "Choose settings file location:";
            // 
            // BoardPanel
            // 
            this.BoardPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BoardPanel.AutoSize = true;
            this.BoardPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BoardPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BoardPanel.Controls.Add(this.WhiteLatch);
            this.BoardPanel.Controls.Add(this.BlueLatch);
            this.BoardPanel.Controls.Add(this.GreenLatch);
            this.BoardPanel.Controls.Add(this.YellowLatch);
            this.BoardPanel.Controls.Add(this.WhiteButton);
            this.BoardPanel.Controls.Add(this.BlueButton);
            this.BoardPanel.Controls.Add(this.GreenButton);
            this.BoardPanel.Controls.Add(this.YellowButton);
            this.BoardPanel.Location = new System.Drawing.Point(132, 27);
            this.BoardPanel.Name = "BoardPanel";
            this.BoardPanel.Padding = new System.Windows.Forms.Padding(3);
            this.BoardPanel.Size = new System.Drawing.Size(230, 118);
            this.BoardPanel.TabIndex = 15;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogTextBox.Location = new System.Drawing.Point(12, 151);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.Size = new System.Drawing.Size(470, 205);
            this.LogTextBox.TabIndex = 16;
            this.LogTextBox.Text = "";
            this.LogTextBox.WordWrap = false;
            // 
            // WhiteLatch
            // 
            this.WhiteLatch.BackColor = System.Drawing.Color.LightGray;
            this.WhiteLatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WhiteLatch.LedColor = System.Drawing.Color.White;
            this.WhiteLatch.LedOn = true;
            this.WhiteLatch.LedPin = 14;
            this.WhiteLatch.Location = new System.Drawing.Point(6, 6);
            this.WhiteLatch.Name = "WhiteLatch";
            this.WhiteLatch.Pin = 15;
            this.WhiteLatch.Size = new System.Drawing.Size(50, 50);
            this.WhiteLatch.TabIndex = 24;
            // 
            // BlueLatch
            // 
            this.BlueLatch.BackColor = System.Drawing.Color.LightGray;
            this.BlueLatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlueLatch.LedOn = true;
            this.BlueLatch.LedPin = 16;
            this.BlueLatch.Location = new System.Drawing.Point(62, 6);
            this.BlueLatch.Name = "BlueLatch";
            this.BlueLatch.Pin = 17;
            this.BlueLatch.Size = new System.Drawing.Size(50, 50);
            this.BlueLatch.TabIndex = 23;
            // 
            // GreenLatch
            // 
            this.GreenLatch.BackColor = System.Drawing.Color.LightGray;
            this.GreenLatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreenLatch.LedColor = System.Drawing.Color.Green;
            this.GreenLatch.LedOn = true;
            this.GreenLatch.LedPin = 19;
            this.GreenLatch.Location = new System.Drawing.Point(118, 6);
            this.GreenLatch.Name = "GreenLatch";
            this.GreenLatch.Pin = 20;
            this.GreenLatch.Size = new System.Drawing.Size(50, 50);
            this.GreenLatch.TabIndex = 22;
            // 
            // YellowLatch
            // 
            this.YellowLatch.BackColor = System.Drawing.Color.LightGray;
            this.YellowLatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YellowLatch.LedColor = System.Drawing.Color.Gold;
            this.YellowLatch.LedOn = true;
            this.YellowLatch.LedPin = 22;
            this.YellowLatch.Location = new System.Drawing.Point(174, 6);
            this.YellowLatch.Name = "YellowLatch";
            this.YellowLatch.Pin = 23;
            this.YellowLatch.Size = new System.Drawing.Size(50, 50);
            this.YellowLatch.TabIndex = 21;
            // 
            // WhiteButton
            // 
            this.WhiteButton.BackColor = System.Drawing.Color.LightGray;
            this.WhiteButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WhiteButton.LedColor = System.Drawing.Color.White;
            this.WhiteButton.LedOn = true;
            this.WhiteButton.LedPin = 9;
            this.WhiteButton.Location = new System.Drawing.Point(6, 62);
            this.WhiteButton.Name = "WhiteButton";
            this.WhiteButton.Pin = 11;
            this.WhiteButton.Size = new System.Drawing.Size(50, 50);
            this.WhiteButton.TabIndex = 20;
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.LightGray;
            this.BlueButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlueButton.LedOn = true;
            this.BlueButton.LedPin = 6;
            this.BlueButton.Location = new System.Drawing.Point(62, 62);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Pin = 7;
            this.BlueButton.Size = new System.Drawing.Size(50, 50);
            this.BlueButton.TabIndex = 19;
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.LightGray;
            this.GreenButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreenButton.LedColor = System.Drawing.Color.Green;
            this.GreenButton.LedOn = true;
            this.GreenButton.LedPin = 3;
            this.GreenButton.Location = new System.Drawing.Point(118, 62);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Pin = 4;
            this.GreenButton.Size = new System.Drawing.Size(50, 50);
            this.GreenButton.TabIndex = 18;
            // 
            // YellowButton
            // 
            this.YellowButton.BackColor = System.Drawing.Color.LightGray;
            this.YellowButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YellowButton.LedColor = System.Drawing.Color.Gold;
            this.YellowButton.LedOn = true;
            this.YellowButton.LedPin = 1;
            this.YellowButton.Location = new System.Drawing.Point(174, 62);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Pin = 0;
            this.YellowButton.Size = new System.Drawing.Size(50, 50);
            this.YellowButton.TabIndex = 17;
            // 
            // ControlAllTheThingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 381);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.BoardPanel);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "ControlAllTheThingsForm";
            this.Text = "Control All The Things";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlAllTheThingsForm_FormClosed);
            this.Resize += new System.EventHandler(this.ControlAllTheThingsForm_Resize);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.BoardPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripSpring;
        private System.Windows.Forms.ToolStripStatusLabel ConnectionStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar ConnectionStatusProgressBar;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenu;
        private System.Windows.Forms.ToolStripMenuItem ChooseSettingsLocationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewLogFileMenuItem;
        private System.Windows.Forms.OpenFileDialog SettingsFileLocationDialog;
        private System.Windows.Forms.ToolStripMenuItem MinimizeToSystemTrayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunOnStartup;
        private System.Windows.Forms.Panel BoardPanel;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private BoardComponents.LedButtonComponent YellowButton;
        private BoardComponents.LedButtonComponent GreenButton;
        private BoardComponents.LedButtonComponent BlueButton;
        private BoardComponents.LedButtonComponent WhiteLatch;
        private BoardComponents.LedButtonComponent BlueLatch;
        private BoardComponents.LedButtonComponent GreenLatch;
        private BoardComponents.LedButtonComponent YellowLatch;
        private BoardComponents.LedButtonComponent WhiteButton;
        private System.Windows.Forms.ToolStripSeparator OptionsMenuSeparator;
    }
}

