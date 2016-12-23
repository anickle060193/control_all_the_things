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
            this.WaitForBoardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WaitForBoardBtn
            // 
            this.WaitForBoardBtn.Location = new System.Drawing.Point(80, 103);
            this.WaitForBoardBtn.Name = "WaitForBoardBtn";
            this.WaitForBoardBtn.Size = new System.Drawing.Size(109, 23);
            this.WaitForBoardBtn.TabIndex = 0;
            this.WaitForBoardBtn.Text = "Wait for Board";
            this.WaitForBoardBtn.UseVisualStyleBackColor = true;
            this.WaitForBoardBtn.Click += new System.EventHandler(this.WaitForBoardBtn_Click);
            // 
            // ControlAllTheThingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.WaitForBoardBtn);
            this.Name = "ControlAllTheThingsForm";
            this.Text = "Control All The Things";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WaitForBoardBtn;
    }
}

