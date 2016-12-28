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
            this.Pin11ButtonComponent = new ControlAllTheThings.ButtonComponent();
            this.Pin12ButtonComponent = new ControlAllTheThings.ButtonComponent();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.OptionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewLogFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTextBox.Location = new System.Drawing.Point(12, 73);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTextBox.Size = new System.Drawing.Size(363, 193);
            this.LogTextBox.TabIndex = 2;
            this.LogTextBox.WordWrap = false;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripSpring,
            this.ConnectionStatusLabel,
            this.ConnectionStatusProgressBar});
            this.StatusStrip.Location = new System.Drawing.Point(0, 275);
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
            // Pin11ButtonComponent
            // 
            this.Pin11ButtonComponent.BackColor = System.Drawing.Color.LightGray;
            this.Pin11ButtonComponent.BoardInterface = null;
            this.Pin11ButtonComponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pin11ButtonComponent.Location = new System.Drawing.Point(58, 27);
            this.Pin11ButtonComponent.MaximumSize = new System.Drawing.Size(40, 40);
            this.Pin11ButtonComponent.MinimumSize = new System.Drawing.Size(40, 40);
            this.Pin11ButtonComponent.Name = "Pin11ButtonComponent";
            this.Pin11ButtonComponent.Pin = 11;
            this.Pin11ButtonComponent.PressedAction = null;
            this.Pin11ButtonComponent.Size = new System.Drawing.Size(40, 40);
            this.Pin11ButtonComponent.TabIndex = 4;
            this.Pin11ButtonComponent.UnpressedAction = null;
            // 
            // Pin12ButtonComponent
            // 
            this.Pin12ButtonComponent.BackColor = System.Drawing.Color.LightGray;
            this.Pin12ButtonComponent.BoardInterface = null;
            this.Pin12ButtonComponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pin12ButtonComponent.Location = new System.Drawing.Point(12, 27);
            this.Pin12ButtonComponent.MaximumSize = new System.Drawing.Size(40, 40);
            this.Pin12ButtonComponent.MinimumSize = new System.Drawing.Size(40, 40);
            this.Pin12ButtonComponent.Name = "Pin12ButtonComponent";
            this.Pin12ButtonComponent.Pin = 12;
            this.Pin12ButtonComponent.PressedAction = null;
            this.Pin12ButtonComponent.Size = new System.Drawing.Size(40, 40);
            this.Pin12ButtonComponent.TabIndex = 1;
            this.Pin12ButtonComponent.UnpressedAction = null;
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
            this.ViewLogFileMenuItem,
            this.OptionsMenuSeparator,
            this.ExitMenuItem});
            this.OptionsMenu.Name = "OptionsMenu";
            this.OptionsMenu.Size = new System.Drawing.Size(61, 20);
            this.OptionsMenu.Text = "Options";
            // 
            // ViewLogFileMenuItem
            // 
            this.ViewLogFileMenuItem.Name = "ViewLogFileMenuItem";
            this.ViewLogFileMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ViewLogFileMenuItem.Text = "View Log File";
            this.ViewLogFileMenuItem.Click += new System.EventHandler(this.ViewLogFileMenuItem_Click);
            // 
            // OptionsMenuSeparator
            // 
            this.OptionsMenuSeparator.Name = "OptionsMenuSeparator";
            this.OptionsMenuSeparator.Size = new System.Drawing.Size(140, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ControlAllTheThingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 297);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.Pin11ButtonComponent);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.Pin12ButtonComponent);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "ControlAllTheThingsForm";
            this.Text = "Control All The Things";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlAllTheThingsForm_FormClosing);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonComponent Pin12ButtonComponent;
        private System.Windows.Forms.TextBox LogTextBox;
        private ButtonComponent Pin11ButtonComponent;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripSpring;
        private System.Windows.Forms.ToolStripStatusLabel ConnectionStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar ConnectionStatusProgressBar;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewLogFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator OptionsMenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;

    }
}

