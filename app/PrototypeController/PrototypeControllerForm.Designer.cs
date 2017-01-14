namespace PrototypeController
{
    partial class PrototypeControllerForm
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
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.PrototypeBoardControl = new PrototypeController.PrototypeBoardControl();
            this.StatusStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
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
            // PrototypeBoardControl
            // 
            this.PrototypeBoardControl.BackColor = System.Drawing.Color.Black;
            this.PrototypeBoardControl.Location = new System.Drawing.Point(132, 27);
            this.PrototypeBoardControl.Name = "PrototypeBoardControl";
            this.PrototypeBoardControl.Size = new System.Drawing.Size(230, 118);
            this.PrototypeBoardControl.TabIndex = 17;
            // 
            // PrototypeControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 381);
            this.Controls.Add(this.PrototypeBoardControl);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "PrototypeControllerForm";
            this.Text = "Prototype Controller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlAllTheThingsForm_FormClosed);
            this.Resize += new System.EventHandler(this.ControlAllTheThingsForm_Resize);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
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
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.ToolStripSeparator OptionsMenuSeparator;
        private PrototypeBoardControl PrototypeBoardControl;
    }
}

