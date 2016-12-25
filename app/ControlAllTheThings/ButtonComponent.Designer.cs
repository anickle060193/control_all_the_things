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
            this.SetPressedBehaviorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetUnpressedBehaviorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonComponentContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonComponentContextMenu
            // 
            this.ButtonComponentContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetPressedBehaviorMenuItem,
            this.SetUnpressedBehaviorMenuItem});
            this.ButtonComponentContextMenu.Name = "ContextMenu";
            this.ButtonComponentContextMenu.Size = new System.Drawing.Size(198, 48);
            // 
            // SetPressedBehaviorMenuItem
            // 
            this.SetPressedBehaviorMenuItem.Name = "SetPressedBehaviorMenuItem";
            this.SetPressedBehaviorMenuItem.Size = new System.Drawing.Size(197, 22);
            this.SetPressedBehaviorMenuItem.Text = "Set Pressed Behavior";
            this.SetPressedBehaviorMenuItem.Click += new System.EventHandler(this.SetPressedBehaviorMenuItem_Click);
            // 
            // SetUnpressedBehaviorMenuItem
            // 
            this.SetUnpressedBehaviorMenuItem.Name = "SetUnpressedBehaviorMenuItem";
            this.SetUnpressedBehaviorMenuItem.Size = new System.Drawing.Size(197, 22);
            this.SetUnpressedBehaviorMenuItem.Text = "Set Unpressed Behavior";
            this.SetUnpressedBehaviorMenuItem.Click += new System.EventHandler(this.SetUnpressedBehaviorMenuItem_Click);
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
            this.ButtonComponentContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ButtonComponentContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SetPressedBehaviorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetUnpressedBehaviorMenuItem;

    }
}
