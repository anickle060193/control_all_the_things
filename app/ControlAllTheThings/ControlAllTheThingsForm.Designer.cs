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
            this.LedCheckBox = new System.Windows.Forms.CheckBox();
            this.Pin12ButtonComponent = new ControlAllTheThings.ButtonComponent();
            this.SuspendLayout();
            // 
            // LedCheckBox
            // 
            this.LedCheckBox.AutoSize = true;
            this.LedCheckBox.Location = new System.Drawing.Point(98, 12);
            this.LedCheckBox.Name = "LedCheckBox";
            this.LedCheckBox.Size = new System.Drawing.Size(47, 17);
            this.LedCheckBox.TabIndex = 0;
            this.LedCheckBox.Text = "LED";
            this.LedCheckBox.UseVisualStyleBackColor = true;
            this.LedCheckBox.CheckedChanged += new System.EventHandler(this.LedCheckBox_CheckedChanged);
            // 
            // Pin12ButtonComponent
            // 
            this.Pin12ButtonComponent.BackColor = System.Drawing.Color.LightGray;
            this.Pin12ButtonComponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pin12ButtonComponent.Location = new System.Drawing.Point(12, 12);
            this.Pin12ButtonComponent.MaximumSize = new System.Drawing.Size(40, 40);
            this.Pin12ButtonComponent.MinimumSize = new System.Drawing.Size(40, 40);
            this.Pin12ButtonComponent.Name = "Pin12ButtonComponent";
            this.Pin12ButtonComponent.Pin = 12;
            this.Pin12ButtonComponent.Size = new System.Drawing.Size(40, 40);
            this.Pin12ButtonComponent.TabIndex = 1;
            // 
            // ControlAllTheThingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Pin12ButtonComponent);
            this.Controls.Add(this.LedCheckBox);
            this.Name = "ControlAllTheThingsForm";
            this.Text = "Control All The Things";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox LedCheckBox;
        private ButtonComponent Pin12ButtonComponent;

    }
}

