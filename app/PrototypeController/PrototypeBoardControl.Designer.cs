namespace PrototypeController
{
    partial class PrototypeBoardControl
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
            this.WhiteLatch = new ControlAllTheThings.BoardComponents.LedButtonComponent();
            this.BlueLatch = new ControlAllTheThings.BoardComponents.LedButtonComponent();
            this.GreenLatch = new ControlAllTheThings.BoardComponents.LedButtonComponent();
            this.YellowLatch = new ControlAllTheThings.BoardComponents.LedButtonComponent();
            this.BlueButton = new ControlAllTheThings.BoardComponents.LedButtonComponent();
            this.YellowButton = new ControlAllTheThings.BoardComponents.LedButtonComponent();
            this.WhiteButton = new ControlAllTheThings.BoardComponents.LedButtonComponent();
            this.GreenButton = new ControlAllTheThings.BoardComponents.LedButtonComponent();
            this.SuspendLayout();
            // 
            // WhiteLatch
            // 
            this.WhiteLatch.BackColor = System.Drawing.Color.LightGray;
            this.WhiteLatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WhiteLatch.LedColor = System.Drawing.Color.White;
            this.WhiteLatch.LedOn = true;
            this.WhiteLatch.Location = new System.Drawing.Point(174, 62);
            this.WhiteLatch.Name = "WhiteLatch";
            this.WhiteLatch.Size = new System.Drawing.Size(50, 50);
            this.WhiteLatch.TabIndex = 32;
            // 
            // BlueLatch
            // 
            this.BlueLatch.BackColor = System.Drawing.Color.LightGray;
            this.BlueLatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlueLatch.LedOn = true;
            this.BlueLatch.Location = new System.Drawing.Point(118, 62);
            this.BlueLatch.Name = "BlueLatch";
            this.BlueLatch.Size = new System.Drawing.Size(50, 50);
            this.BlueLatch.TabIndex = 31;
            // 
            // GreenLatch
            // 
            this.GreenLatch.BackColor = System.Drawing.Color.LightGray;
            this.GreenLatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreenLatch.LedColor = System.Drawing.Color.Green;
            this.GreenLatch.LedOn = true;
            this.GreenLatch.Location = new System.Drawing.Point(62, 62);
            this.GreenLatch.Name = "GreenLatch";
            this.GreenLatch.Size = new System.Drawing.Size(50, 50);
            this.GreenLatch.TabIndex = 30;
            // 
            // YellowLatch
            // 
            this.YellowLatch.BackColor = System.Drawing.Color.LightGray;
            this.YellowLatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YellowLatch.LedColor = System.Drawing.Color.Gold;
            this.YellowLatch.LedOn = true;
            this.YellowLatch.Location = new System.Drawing.Point(6, 62);
            this.YellowLatch.Name = "YellowLatch";
            this.YellowLatch.Size = new System.Drawing.Size(50, 50);
            this.YellowLatch.TabIndex = 29;
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.LightGray;
            this.BlueButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlueButton.LedOn = true;
            this.BlueButton.Location = new System.Drawing.Point(118, 6);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(50, 50);
            this.BlueButton.TabIndex = 27;
            // 
            // YellowButton
            // 
            this.YellowButton.BackColor = System.Drawing.Color.LightGray;
            this.YellowButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YellowButton.LedColor = System.Drawing.Color.Gold;
            this.YellowButton.LedOn = true;
            this.YellowButton.Location = new System.Drawing.Point(6, 6);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(50, 50);
            this.YellowButton.TabIndex = 25;
            // 
            // WhiteButton
            // 
            this.WhiteButton.BackColor = System.Drawing.Color.LightGray;
            this.WhiteButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WhiteButton.LedColor = System.Drawing.Color.White;
            this.WhiteButton.LedOn = true;
            this.WhiteButton.Location = new System.Drawing.Point(174, 6);
            this.WhiteButton.Name = "WhiteButton";
            this.WhiteButton.Size = new System.Drawing.Size(50, 50);
            this.WhiteButton.TabIndex = 28;
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.LightGray;
            this.GreenButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreenButton.LedColor = System.Drawing.Color.Green;
            this.GreenButton.LedOn = true;
            this.GreenButton.Location = new System.Drawing.Point(62, 6);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(50, 50);
            this.GreenButton.TabIndex = 26;
            // 
            // PrototypeBoardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.WhiteLatch);
            this.Controls.Add(this.BlueLatch);
            this.Controls.Add(this.GreenLatch);
            this.Controls.Add(this.YellowLatch);
            this.Controls.Add(this.BlueButton);
            this.Controls.Add(this.YellowButton);
            this.Controls.Add(this.WhiteButton);
            this.Controls.Add(this.GreenButton);
            this.Name = "PrototypeBoardControl";
            this.Size = new System.Drawing.Size(230, 118);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlAllTheThings.BoardComponents.LedButtonComponent WhiteLatch;
        private ControlAllTheThings.BoardComponents.LedButtonComponent BlueLatch;
        private ControlAllTheThings.BoardComponents.LedButtonComponent GreenLatch;
        private ControlAllTheThings.BoardComponents.LedButtonComponent YellowLatch;
        private ControlAllTheThings.BoardComponents.LedButtonComponent BlueButton;
        private ControlAllTheThings.BoardComponents.LedButtonComponent YellowButton;
        private ControlAllTheThings.BoardComponents.LedButtonComponent WhiteButton;
        private ControlAllTheThings.BoardComponents.LedButtonComponent GreenButton;
    }
}
