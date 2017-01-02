namespace ControlAllTheThings.BoardComponents
{
    partial class ButtonComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonComponentContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SetPressedActions = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickAddPressedActionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickAddPressedActionSetLedMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickAddPressedActionSetLedOn = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickAddPressedActionSetLedOff = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickAddPressedActionSetPinMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickAddPressedActionTogglePinMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearPressedActions = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonComponentContextMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SetUnpressedActions = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickAddUnpressedActionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickAddUnpressedActionSetLedMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickAddUnpressedActionSetLedOn = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickAddUnpressedActionSetLedOff = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickAddUnpressedActionSetPinMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickAddUnpressedActionTogglePinMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearUnpressedActions = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonComponentContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonComponentContextMenu
            // 
            this.ButtonComponentContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetPressedActions,
            this.QuickAddPressedActionMenu,
            this.ClearPressedActions,
            this.ButtonComponentContextMenuSeparator,
            this.SetUnpressedActions,
            this.QuickAddUnpressedActionMenu,
            this.ClearUnpressedActions});
            this.ButtonComponentContextMenu.Name = "ContextMenu";
            this.ButtonComponentContextMenu.Size = new System.Drawing.Size(227, 142);
            this.ButtonComponentContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ButtonComponentContextMenu_Opening);
            // 
            // SetPressedActions
            // 
            this.SetPressedActions.Name = "SetPressedActions";
            this.SetPressedActions.Size = new System.Drawing.Size(226, 22);
            this.SetPressedActions.Text = "Set Pressed Actions";
            this.SetPressedActions.Click += new System.EventHandler(this.SetPressedActions_Click);
            // 
            // QuickAddPressedActionMenu
            // 
            this.QuickAddPressedActionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuickAddPressedActionSetLedMenu,
            this.QuickAddPressedActionSetPinMenu,
            this.QuickAddPressedActionTogglePinMenu});
            this.QuickAddPressedActionMenu.Name = "QuickAddPressedActionMenu";
            this.QuickAddPressedActionMenu.Size = new System.Drawing.Size(226, 22);
            this.QuickAddPressedActionMenu.Text = "Quick Add Pressed Action";
            // 
            // QuickAddPressedActionSetLedMenu
            // 
            this.QuickAddPressedActionSetLedMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuickAddPressedActionSetLedOn,
            this.QuickAddPressedActionSetLedOff});
            this.QuickAddPressedActionSetLedMenu.Name = "QuickAddPressedActionSetLedMenu";
            this.QuickAddPressedActionSetLedMenu.Size = new System.Drawing.Size(131, 22);
            this.QuickAddPressedActionSetLedMenu.Text = "Set LED";
            // 
            // QuickAddPressedActionSetLedOn
            // 
            this.QuickAddPressedActionSetLedOn.Name = "QuickAddPressedActionSetLedOn";
            this.QuickAddPressedActionSetLedOn.Size = new System.Drawing.Size(91, 22);
            this.QuickAddPressedActionSetLedOn.Text = "On";
            this.QuickAddPressedActionSetLedOn.Click += new System.EventHandler(this.QuickAddPressedActionSetLed_Click);
            // 
            // QuickAddPressedActionSetLedOff
            // 
            this.QuickAddPressedActionSetLedOff.Name = "QuickAddPressedActionSetLedOff";
            this.QuickAddPressedActionSetLedOff.Size = new System.Drawing.Size(91, 22);
            this.QuickAddPressedActionSetLedOff.Text = "Off";
            this.QuickAddPressedActionSetLedOff.Click += new System.EventHandler(this.QuickAddPressedActionSetLed_Click);
            // 
            // QuickAddPressedActionSetPinMenu
            // 
            this.QuickAddPressedActionSetPinMenu.Name = "QuickAddPressedActionSetPinMenu";
            this.QuickAddPressedActionSetPinMenu.Size = new System.Drawing.Size(131, 22);
            this.QuickAddPressedActionSetPinMenu.Text = "Set Pin";
            // 
            // QuickAddPressedActionTogglePinMenu
            // 
            this.QuickAddPressedActionTogglePinMenu.Name = "QuickAddPressedActionTogglePinMenu";
            this.QuickAddPressedActionTogglePinMenu.Size = new System.Drawing.Size(131, 22);
            this.QuickAddPressedActionTogglePinMenu.Text = "Toggle Pin";
            // 
            // ClearPressedActions
            // 
            this.ClearPressedActions.Name = "ClearPressedActions";
            this.ClearPressedActions.Size = new System.Drawing.Size(226, 22);
            this.ClearPressedActions.Text = "Clear Pressed Actions";
            this.ClearPressedActions.Click += new System.EventHandler(this.ClearPressedActions_Click);
            // 
            // ButtonComponentContextMenuSeparator
            // 
            this.ButtonComponentContextMenuSeparator.Name = "ButtonComponentContextMenuSeparator";
            this.ButtonComponentContextMenuSeparator.Size = new System.Drawing.Size(223, 6);
            // 
            // SetUnpressedActions
            // 
            this.SetUnpressedActions.Name = "SetUnpressedActions";
            this.SetUnpressedActions.Size = new System.Drawing.Size(226, 22);
            this.SetUnpressedActions.Text = "Set Unpressed Actions";
            this.SetUnpressedActions.Click += new System.EventHandler(this.SetUnpressedActions_Click);
            // 
            // QuickAddUnpressedActionMenu
            // 
            this.QuickAddUnpressedActionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuickAddUnpressedActionSetLedMenu,
            this.QuickAddUnpressedActionSetPinMenu,
            this.QuickAddUnpressedActionTogglePinMenu});
            this.QuickAddUnpressedActionMenu.Name = "QuickAddUnpressedActionMenu";
            this.QuickAddUnpressedActionMenu.Size = new System.Drawing.Size(226, 22);
            this.QuickAddUnpressedActionMenu.Text = "Quick Add Unpressed Action";
            // 
            // QuickAddUnpressedActionSetLedMenu
            // 
            this.QuickAddUnpressedActionSetLedMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuickAddUnpressedActionSetLedOn,
            this.QuickAddUnpressedActionSetLedOff});
            this.QuickAddUnpressedActionSetLedMenu.Name = "QuickAddUnpressedActionSetLedMenu";
            this.QuickAddUnpressedActionSetLedMenu.Size = new System.Drawing.Size(131, 22);
            this.QuickAddUnpressedActionSetLedMenu.Text = "Set LED";
            // 
            // QuickAddUnpressedActionSetLedOn
            // 
            this.QuickAddUnpressedActionSetLedOn.Name = "QuickAddUnpressedActionSetLedOn";
            this.QuickAddUnpressedActionSetLedOn.Size = new System.Drawing.Size(91, 22);
            this.QuickAddUnpressedActionSetLedOn.Text = "On";
            this.QuickAddUnpressedActionSetLedOn.Click += new System.EventHandler(this.QuickAddUnpressedActionSetLed_Click);
            // 
            // QuickAddUnpressedActionSetLedOff
            // 
            this.QuickAddUnpressedActionSetLedOff.Name = "QuickAddUnpressedActionSetLedOff";
            this.QuickAddUnpressedActionSetLedOff.Size = new System.Drawing.Size(91, 22);
            this.QuickAddUnpressedActionSetLedOff.Text = "Off";
            this.QuickAddUnpressedActionSetLedOff.Click += new System.EventHandler(this.QuickAddUnpressedActionSetLed_Click);
            // 
            // QuickAddUnpressedActionSetPinMenu
            // 
            this.QuickAddUnpressedActionSetPinMenu.Name = "QuickAddUnpressedActionSetPinMenu";
            this.QuickAddUnpressedActionSetPinMenu.Size = new System.Drawing.Size(131, 22);
            this.QuickAddUnpressedActionSetPinMenu.Text = "Set Pin";
            // 
            // QuickAddUnpressedActionTogglePinMenu
            // 
            this.QuickAddUnpressedActionTogglePinMenu.Name = "QuickAddUnpressedActionTogglePinMenu";
            this.QuickAddUnpressedActionTogglePinMenu.Size = new System.Drawing.Size(131, 22);
            this.QuickAddUnpressedActionTogglePinMenu.Text = "Toggle Pin";
            // 
            // ClearUnpressedActions
            // 
            this.ClearUnpressedActions.Name = "ClearUnpressedActions";
            this.ClearUnpressedActions.Size = new System.Drawing.Size(226, 22);
            this.ClearUnpressedActions.Text = "Clear Unpressed Actions";
            this.ClearUnpressedActions.Click += new System.EventHandler(this.ClearUnpressedActions_Click);
            // 
            // ButtonComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.ButtonComponentContextMenu;
            this.Name = "ButtonComponent";
            this.Size = new System.Drawing.Size(40, 40);
            this.Load += new System.EventHandler(this.ButtonComponent_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonComponent_Paint);
            this.DoubleClick += new System.EventHandler(this.ButtonComponent_DoubleClick);
            this.ButtonComponentContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ButtonComponentContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SetPressedActions;
        private System.Windows.Forms.ToolStripMenuItem SetUnpressedActions;
        private System.Windows.Forms.ToolStripMenuItem ClearPressedActions;
        private System.Windows.Forms.ToolStripSeparator ButtonComponentContextMenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem ClearUnpressedActions;
        private System.Windows.Forms.ToolStripMenuItem QuickAddPressedActionMenu;
        private System.Windows.Forms.ToolStripMenuItem QuickAddPressedActionSetLedMenu;
        private System.Windows.Forms.ToolStripMenuItem QuickAddPressedActionSetLedOn;
        private System.Windows.Forms.ToolStripMenuItem QuickAddPressedActionSetLedOff;
        private System.Windows.Forms.ToolStripMenuItem QuickAddPressedActionSetPinMenu;
        private System.Windows.Forms.ToolStripMenuItem QuickAddPressedActionTogglePinMenu;
        private System.Windows.Forms.ToolStripMenuItem QuickAddUnpressedActionMenu;
        private System.Windows.Forms.ToolStripMenuItem QuickAddUnpressedActionSetLedMenu;
        private System.Windows.Forms.ToolStripMenuItem QuickAddUnpressedActionSetLedOn;
        private System.Windows.Forms.ToolStripMenuItem QuickAddUnpressedActionSetLedOff;
        private System.Windows.Forms.ToolStripMenuItem QuickAddUnpressedActionSetPinMenu;
        private System.Windows.Forms.ToolStripMenuItem QuickAddUnpressedActionTogglePinMenu;

    }
}
