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
            this.PrototypeBoardControl = new PrototypeController.PrototypeBoardControl();
            this.SuspendLayout();
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
            this.Name = "PrototypeControllerForm";
            this.Controls.SetChildIndex(this.PrototypeBoardControl, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PrototypeBoardControl PrototypeBoardControl;
    }
}