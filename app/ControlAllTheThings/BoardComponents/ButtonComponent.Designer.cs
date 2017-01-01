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
            this.ClearPressedActions = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonComponentContextMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SetUnpressedActions = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearUnpressedActions = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonComponentContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonComponentContextMenu
            // 
            this.ButtonComponentContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetPressedActions,
            this.ClearPressedActions,
            this.ButtonComponentContextMenuSeparator,
            this.SetUnpressedActions,
            this.ClearUnpressedActions});
            this.ButtonComponentContextMenu.Name = "ContextMenu";
            this.ButtonComponentContextMenu.Size = new System.Drawing.Size(203, 98);
            // 
            // SetPressedActions
            // 
            this.SetPressedActions.Name = "SetPressedActions";
            this.SetPressedActions.Size = new System.Drawing.Size(202, 22);
            this.SetPressedActions.Text = "Set Pressed Actions";
            this.SetPressedActions.Click += new System.EventHandler(this.SetPressedActions_Click);
            // 
            // ClearPressedActions
            // 
            this.ClearPressedActions.Name = "ClearPressedActions";
            this.ClearPressedActions.Size = new System.Drawing.Size(202, 22);
            this.ClearPressedActions.Text = "Clear Pressed Actions";
            this.ClearPressedActions.Click += new System.EventHandler(this.ClearPressedActions_Click);
            // 
            // ButtonComponentContextMenuSeparator
            // 
            this.ButtonComponentContextMenuSeparator.Name = "ButtonComponentContextMenuSeparator";
            this.ButtonComponentContextMenuSeparator.Size = new System.Drawing.Size(199, 6);
            // 
            // SetUnpressedActions
            // 
            this.SetUnpressedActions.Name = "SetUnpressedActions";
            this.SetUnpressedActions.Size = new System.Drawing.Size(202, 22);
            this.SetUnpressedActions.Text = "Set Unpressed Actions";
            this.SetUnpressedActions.Click += new System.EventHandler(this.SetUnpressedActions_Click);
            // 
            // ClearUnpressedActions
            // 
            this.ClearUnpressedActions.Name = "ClearUnpressedActions";
            this.ClearUnpressedActions.Size = new System.Drawing.Size(202, 22);
            this.ClearUnpressedActions.Text = "Clear Unpressed Actions";
            this.ClearUnpressedActions.Click += new System.EventHandler(this.ClearUnpressedActions_Click);
            // 
            // ButtonComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ContextMenuStrip = this.ButtonComponentContextMenu;
            this.Name = "ButtonComponent";
            this.Size = new System.Drawing.Size(40, 40);
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

    }
}
