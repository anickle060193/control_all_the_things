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
            this.MinimizeToSystemTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunOnStartup = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewLogFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsFileLocationDialog = new System.Windows.Forms.OpenFileDialog();
            this.BoardPanel = new System.Windows.Forms.Panel();
            this.YellowButton = new ControlAllTheThings.BoardComponents.ButtonComponent();
            this.YellowLatch = new ControlAllTheThings.BoardComponents.ButtonComponent();
            this.WhiteButton = new ControlAllTheThings.BoardComponents.ButtonComponent();
            this.GreenLatch = new ControlAllTheThings.BoardComponents.ButtonComponent();
            this.WhiteLatch = new ControlAllTheThings.BoardComponents.ButtonComponent();
            this.BlueButton = new ControlAllTheThings.BoardComponents.ButtonComponent();
            this.GreenButton = new ControlAllTheThings.BoardComponents.ButtonComponent();
            this.BlueLatch = new ControlAllTheThings.BoardComponents.ButtonComponent();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
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
            // BoardPanel
            // 
            this.BoardPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BoardPanel.AutoSize = true;
            this.BoardPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BoardPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BoardPanel.Controls.Add(this.YellowButton);
            this.BoardPanel.Controls.Add(this.YellowLatch);
            this.BoardPanel.Controls.Add(this.WhiteButton);
            this.BoardPanel.Controls.Add(this.GreenLatch);
            this.BoardPanel.Controls.Add(this.WhiteLatch);
            this.BoardPanel.Controls.Add(this.BlueButton);
            this.BoardPanel.Controls.Add(this.GreenButton);
            this.BoardPanel.Controls.Add(this.BlueLatch);
            this.BoardPanel.Location = new System.Drawing.Point(132, 27);
            this.BoardPanel.Name = "BoardPanel";
            this.BoardPanel.Padding = new System.Windows.Forms.Padding(3);
            this.BoardPanel.Size = new System.Drawing.Size(230, 118);
            this.BoardPanel.TabIndex = 15;
            // 
            // YellowButton
            // 
            this.YellowButton.BackColor = System.Drawing.Color.LightGray;
            this.YellowButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YellowButton.Location = new System.Drawing.Point(6, 6);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Pin = 0;
            this.YellowButton.Size = new System.Drawing.Size(50, 50);
            this.YellowButton.TabIndex = 10;
            // 
            // YellowLatch
            // 
            this.YellowLatch.BackColor = System.Drawing.Color.LightGray;
            this.YellowLatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YellowLatch.Location = new System.Drawing.Point(6, 62);
            this.YellowLatch.Name = "YellowLatch";
            this.YellowLatch.Pin = 23;
            this.YellowLatch.Size = new System.Drawing.Size(50, 50);
            this.YellowLatch.TabIndex = 1;
            // 
            // WhiteButton
            // 
            this.WhiteButton.BackColor = System.Drawing.Color.LightGray;
            this.WhiteButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WhiteButton.Location = new System.Drawing.Point(174, 6);
            this.WhiteButton.Name = "WhiteButton";
            this.WhiteButton.Pin = 11;
            this.WhiteButton.Size = new System.Drawing.Size(50, 50);
            this.WhiteButton.TabIndex = 13;
            // 
            // GreenLatch
            // 
            this.GreenLatch.BackColor = System.Drawing.Color.LightGray;
            this.GreenLatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreenLatch.Location = new System.Drawing.Point(62, 62);
            this.GreenLatch.Name = "GreenLatch";
            this.GreenLatch.Pin = 20;
            this.GreenLatch.Size = new System.Drawing.Size(50, 50);
            this.GreenLatch.TabIndex = 4;
            // 
            // WhiteLatch
            // 
            this.WhiteLatch.BackColor = System.Drawing.Color.LightGray;
            this.WhiteLatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WhiteLatch.Location = new System.Drawing.Point(174, 62);
            this.WhiteLatch.Name = "WhiteLatch";
            this.WhiteLatch.Pin = 15;
            this.WhiteLatch.Size = new System.Drawing.Size(50, 50);
            this.WhiteLatch.TabIndex = 8;
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.LightGray;
            this.BlueButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlueButton.Location = new System.Drawing.Point(118, 6);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Pin = 7;
            this.BlueButton.Size = new System.Drawing.Size(50, 50);
            this.BlueButton.TabIndex = 12;
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.LightGray;
            this.GreenButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreenButton.Location = new System.Drawing.Point(62, 6);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Pin = 4;
            this.GreenButton.Size = new System.Drawing.Size(50, 50);
            this.GreenButton.TabIndex = 11;
            // 
            // BlueLatch
            // 
            this.BlueLatch.BackColor = System.Drawing.Color.LightGray;
            this.BlueLatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlueLatch.Location = new System.Drawing.Point(118, 62);
            this.BlueLatch.Name = "BlueLatch";
            this.BlueLatch.Pin = 17;
            this.BlueLatch.Size = new System.Drawing.Size(50, 50);
            this.BlueLatch.TabIndex = 9;
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

        private BoardComponents.ButtonComponent YellowLatch;
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
        private System.Windows.Forms.Panel BoardPanel;
        private System.Windows.Forms.RichTextBox LogTextBox;

    }
}

