namespace ControlAllTheThings
{
    partial class ActionForm
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
            this.SetLedAction = new System.Windows.Forms.RadioButton();
            this.SetLedActionOptions = new System.Windows.Forms.GroupBox();
            this.SetLedActionStateOption = new System.Windows.Forms.CheckBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SetPinAction = new System.Windows.Forms.RadioButton();
            this.SetPinActionPinOptionLabel = new System.Windows.Forms.Label();
            this.SetPinActionPinOption = new System.Windows.Forms.NumericUpDown();
            this.SetPinActionStateOption = new System.Windows.Forms.CheckBox();
            this.ActionFormTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SetPinActionOptions = new System.Windows.Forms.GroupBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SetLedActionOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetPinActionPinOption)).BeginInit();
            this.ActionFormTableLayout.SuspendLayout();
            this.SetPinActionOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetLedAction
            // 
            this.SetLedAction.AutoSize = true;
            this.SetLedAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetLedAction.Location = new System.Drawing.Point(3, 3);
            this.SetLedAction.Name = "SetLedAction";
            this.SetLedAction.Size = new System.Drawing.Size(14, 45);
            this.SetLedAction.TabIndex = 1;
            this.SetLedAction.UseVisualStyleBackColor = true;
            this.SetLedAction.CheckedChanged += new System.EventHandler(this.Action_CheckedChanged);
            // 
            // SetLedActionOptions
            // 
            this.SetLedActionOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetLedActionOptions.Controls.Add(this.SetLedActionStateOption);
            this.SetLedActionOptions.Location = new System.Drawing.Point(23, 3);
            this.SetLedActionOptions.Name = "SetLedActionOptions";
            this.SetLedActionOptions.Size = new System.Drawing.Size(153, 45);
            this.SetLedActionOptions.TabIndex = 9;
            this.SetLedActionOptions.TabStop = false;
            this.SetLedActionOptions.Text = "Set LED";
            // 
            // SetLedActionStateOption
            // 
            this.SetLedActionStateOption.AutoSize = true;
            this.SetLedActionStateOption.Location = new System.Drawing.Point(6, 19);
            this.SetLedActionStateOption.Name = "SetLedActionStateOption";
            this.SetLedActionStateOption.Size = new System.Drawing.Size(75, 17);
            this.SetLedActionStateOption.TabIndex = 4;
            this.SetLedActionStateOption.Text = "LED State";
            this.SetLedActionStateOption.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(108, 180);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SetPinAction
            // 
            this.SetPinAction.AutoSize = true;
            this.SetPinAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetPinAction.Location = new System.Drawing.Point(3, 54);
            this.SetPinAction.Name = "SetPinAction";
            this.SetPinAction.Size = new System.Drawing.Size(14, 48);
            this.SetPinAction.TabIndex = 5;
            this.SetPinAction.UseVisualStyleBackColor = true;
            this.SetPinAction.CheckedChanged += new System.EventHandler(this.Action_CheckedChanged);
            // 
            // SetPinActionPinOptionLabel
            // 
            this.SetPinActionPinOptionLabel.AutoSize = true;
            this.SetPinActionPinOptionLabel.Location = new System.Drawing.Point(6, 21);
            this.SetPinActionPinOptionLabel.Name = "SetPinActionPinOptionLabel";
            this.SetPinActionPinOptionLabel.Size = new System.Drawing.Size(25, 13);
            this.SetPinActionPinOptionLabel.TabIndex = 6;
            this.SetPinActionPinOptionLabel.Text = "Pin:";
            // 
            // SetPinActionPinOption
            // 
            this.SetPinActionPinOption.Location = new System.Drawing.Point(32, 19);
            this.SetPinActionPinOption.Name = "SetPinActionPinOption";
            this.SetPinActionPinOption.Size = new System.Drawing.Size(35, 20);
            this.SetPinActionPinOption.TabIndex = 7;
            // 
            // SetPinActionStateOption
            // 
            this.SetPinActionStateOption.AutoSize = true;
            this.SetPinActionStateOption.Location = new System.Drawing.Point(73, 20);
            this.SetPinActionStateOption.Name = "SetPinActionStateOption";
            this.SetPinActionStateOption.Size = new System.Drawing.Size(69, 17);
            this.SetPinActionStateOption.TabIndex = 8;
            this.SetPinActionStateOption.Text = "Pin State";
            this.SetPinActionStateOption.UseVisualStyleBackColor = true;
            // 
            // ActionFormTableLayout
            // 
            this.ActionFormTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionFormTableLayout.ColumnCount = 2;
            this.ActionFormTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ActionFormTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ActionFormTableLayout.Controls.Add(this.SetLedAction, 0, 0);
            this.ActionFormTableLayout.Controls.Add(this.SetLedActionOptions, 1, 0);
            this.ActionFormTableLayout.Controls.Add(this.SetPinAction, 0, 1);
            this.ActionFormTableLayout.Controls.Add(this.SetPinActionOptions, 1, 1);
            this.ActionFormTableLayout.Location = new System.Drawing.Point(4, 12);
            this.ActionFormTableLayout.Name = "ActionFormTableLayout";
            this.ActionFormTableLayout.RowCount = 3;
            this.ActionFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ActionFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ActionFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ActionFormTableLayout.Size = new System.Drawing.Size(179, 162);
            this.ActionFormTableLayout.TabIndex = 10;
            // 
            // SetPinActionOptions
            // 
            this.SetPinActionOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetPinActionOptions.Controls.Add(this.SetPinActionPinOptionLabel);
            this.SetPinActionOptions.Controls.Add(this.SetPinActionStateOption);
            this.SetPinActionOptions.Controls.Add(this.SetPinActionPinOption);
            this.SetPinActionOptions.Location = new System.Drawing.Point(23, 54);
            this.SetPinActionOptions.Name = "SetPinActionOptions";
            this.SetPinActionOptions.Size = new System.Drawing.Size(153, 48);
            this.SetPinActionOptions.TabIndex = 10;
            this.SetPinActionOptions.TabStop = false;
            this.SetPinActionOptions.Text = "Set Pin";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(27, 180);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ActionForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(195, 215);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ActionFormTableLayout);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ActionForm";
            this.Text = "Action";
            this.SetLedActionOptions.ResumeLayout(false);
            this.SetLedActionOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetPinActionPinOption)).EndInit();
            this.ActionFormTableLayout.ResumeLayout(false);
            this.ActionFormTableLayout.PerformLayout();
            this.SetPinActionOptions.ResumeLayout(false);
            this.SetPinActionOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton SetLedAction;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.CheckBox SetLedActionStateOption;
        private System.Windows.Forms.RadioButton SetPinAction;
        private System.Windows.Forms.Label SetPinActionPinOptionLabel;
        private System.Windows.Forms.NumericUpDown SetPinActionPinOption;
        private System.Windows.Forms.CheckBox SetPinActionStateOption;
        private System.Windows.Forms.GroupBox SetLedActionOptions;
        private System.Windows.Forms.TableLayoutPanel ActionFormTableLayout;
        private System.Windows.Forms.GroupBox SetPinActionOptions;
        private System.Windows.Forms.Button CancelButton;
    }
}