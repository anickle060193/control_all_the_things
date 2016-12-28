namespace ControlAllTheThings
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
            this.SetPressedAction = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearPressedAction = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonComponentContextMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SetUnpressedAction = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearUnpressedAction = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonComponentContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonComponentContextMenu
            // 
            this.ButtonComponentContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetPressedAction,
            this.ClearPressedAction,
            this.ButtonComponentContextMenuSeparator,
            this.SetUnpressedAction,
            this.ClearUnpressedAction});
            this.ButtonComponentContextMenu.Name = "ContextMenu";
            this.ButtonComponentContextMenu.Size = new System.Drawing.Size(198, 120);
            // 
            // SetPressedAction
            // 
            this.SetPressedAction.Name = "SetPressedAction";
            this.SetPressedAction.Size = new System.Drawing.Size(197, 22);
            this.SetPressedAction.Text = "Set Pressed Action";
            this.SetPressedAction.Click += new System.EventHandler(this.SetPressedAction_Click);
            // 
            // ClearPressedAction
            // 
            this.ClearPressedAction.Name = "ClearPressedAction";
            this.ClearPressedAction.Size = new System.Drawing.Size(197, 22);
            this.ClearPressedAction.Text = "Clear Pressed Action";
            this.ClearPressedAction.Click += new System.EventHandler(this.ClearPressedAction_Click);
            // 
            // ButtonComponentContextMenuSeparator
            // 
            this.ButtonComponentContextMenuSeparator.Name = "ButtonComponentContextMenuSeparator";
            this.ButtonComponentContextMenuSeparator.Size = new System.Drawing.Size(194, 6);
            // 
            // SetUnpressedAction
            // 
            this.SetUnpressedAction.Name = "SetUnpressedAction";
            this.SetUnpressedAction.Size = new System.Drawing.Size(197, 22);
            this.SetUnpressedAction.Text = "Set Unpressed Action";
            this.SetUnpressedAction.Click += new System.EventHandler(this.SetUnpressedAction_Click);
            // 
            // ClearUnpressedAction
            // 
            this.ClearUnpressedAction.Name = "ClearUnpressedAction";
            this.ClearUnpressedAction.Size = new System.Drawing.Size(197, 22);
            this.ClearUnpressedAction.Text = "Clear Unpressed Action";
            this.ClearUnpressedAction.Click += new System.EventHandler(this.ClearUnpressedAction_Click);
            // 
            // ButtonComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ContextMenuStrip = this.ButtonComponentContextMenu;
            this.MaximumSize = new System.Drawing.Size(40, 40);
            this.MinimumSize = new System.Drawing.Size(40, 40);
            this.Name = "ButtonComponent";
            this.Size = new System.Drawing.Size(36, 36);
            this.DoubleClick += new System.EventHandler(this.ButtonComponent_DoubleClick);
            this.ButtonComponentContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ButtonComponentContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SetPressedAction;
        private System.Windows.Forms.ToolStripMenuItem SetUnpressedAction;
        private System.Windows.Forms.ToolStripMenuItem ClearPressedAction;
        private System.Windows.Forms.ToolStripSeparator ButtonComponentContextMenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem ClearUnpressedAction;

    }
}
