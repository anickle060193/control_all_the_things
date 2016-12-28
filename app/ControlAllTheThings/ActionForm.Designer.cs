﻿namespace ControlAllTheThings
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
            this.Ok = new System.Windows.Forms.Button();
            this.SetPinAction = new System.Windows.Forms.RadioButton();
            this.SetPinActionPinOptionLabel = new System.Windows.Forms.Label();
            this.SetPinActionPinOption = new System.Windows.Forms.NumericUpDown();
            this.SetPinActionStateOption = new System.Windows.Forms.CheckBox();
            this.ActionFormTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SetPinActionOptions = new System.Windows.Forms.GroupBox();
            this.TogglePinAction = new System.Windows.Forms.RadioButton();
            this.TogglePinActionOptions = new System.Windows.Forms.GroupBox();
            this.TogglePinActionPinOptionLabel = new System.Windows.Forms.Label();
            this.TogglePinActionPinOption = new System.Windows.Forms.NumericUpDown();
            this.SetLedActionOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetPinActionPinOption)).BeginInit();
            this.ActionFormTableLayout.SuspendLayout();
            this.SetPinActionOptions.SuspendLayout();
            this.TogglePinActionOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TogglePinActionPinOption)).BeginInit();
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
            this.SetLedActionOptions.Size = new System.Drawing.Size(161, 45);
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
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.Location = new System.Drawing.Point(108, 192);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 3;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
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
            this.ActionFormTableLayout.Controls.Add(this.TogglePinAction, 0, 2);
            this.ActionFormTableLayout.Controls.Add(this.TogglePinActionOptions, 1, 2);
            this.ActionFormTableLayout.Location = new System.Drawing.Point(4, 4);
            this.ActionFormTableLayout.Name = "ActionFormTableLayout";
            this.ActionFormTableLayout.RowCount = 4;
            this.ActionFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ActionFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ActionFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ActionFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ActionFormTableLayout.Size = new System.Drawing.Size(187, 182);
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
            this.SetPinActionOptions.Size = new System.Drawing.Size(161, 48);
            this.SetPinActionOptions.TabIndex = 10;
            this.SetPinActionOptions.TabStop = false;
            this.SetPinActionOptions.Text = "Set Pin";
            // 
            // TogglePinAction
            // 
            this.TogglePinAction.AutoSize = true;
            this.TogglePinAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TogglePinAction.Location = new System.Drawing.Point(3, 108);
            this.TogglePinAction.Name = "TogglePinAction";
            this.TogglePinAction.Size = new System.Drawing.Size(14, 48);
            this.TogglePinAction.TabIndex = 11;
            this.TogglePinAction.UseVisualStyleBackColor = true;
            this.TogglePinAction.CheckedChanged += new System.EventHandler(this.Action_CheckedChanged);
            // 
            // TogglePinActionOptions
            // 
            this.TogglePinActionOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TogglePinActionOptions.Controls.Add(this.TogglePinActionPinOptionLabel);
            this.TogglePinActionOptions.Controls.Add(this.TogglePinActionPinOption);
            this.TogglePinActionOptions.Location = new System.Drawing.Point(23, 108);
            this.TogglePinActionOptions.Name = "TogglePinActionOptions";
            this.TogglePinActionOptions.Size = new System.Drawing.Size(161, 48);
            this.TogglePinActionOptions.TabIndex = 12;
            this.TogglePinActionOptions.TabStop = false;
            this.TogglePinActionOptions.Text = "Set Pin";
            // 
            // TogglePinActionPinOptionLabel
            // 
            this.TogglePinActionPinOptionLabel.AutoSize = true;
            this.TogglePinActionPinOptionLabel.Location = new System.Drawing.Point(6, 21);
            this.TogglePinActionPinOptionLabel.Name = "TogglePinActionPinOptionLabel";
            this.TogglePinActionPinOptionLabel.Size = new System.Drawing.Size(25, 13);
            this.TogglePinActionPinOptionLabel.TabIndex = 6;
            this.TogglePinActionPinOptionLabel.Text = "Pin:";
            // 
            // TogglePinActionPinOption
            // 
            this.TogglePinActionPinOption.Location = new System.Drawing.Point(32, 19);
            this.TogglePinActionPinOption.Name = "TogglePinActionPinOption";
            this.TogglePinActionPinOption.Size = new System.Drawing.Size(35, 20);
            this.TogglePinActionPinOption.TabIndex = 7;
            // 
            // ActionForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 227);
            this.Controls.Add(this.ActionFormTableLayout);
            this.Controls.Add(this.Ok);
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
            this.TogglePinActionOptions.ResumeLayout(false);
            this.TogglePinActionOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TogglePinActionPinOption)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton SetLedAction;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.CheckBox SetLedActionStateOption;
        private System.Windows.Forms.RadioButton SetPinAction;
        private System.Windows.Forms.Label SetPinActionPinOptionLabel;
        private System.Windows.Forms.NumericUpDown SetPinActionPinOption;
        private System.Windows.Forms.CheckBox SetPinActionStateOption;
        private System.Windows.Forms.GroupBox SetLedActionOptions;
        private System.Windows.Forms.TableLayoutPanel ActionFormTableLayout;
        private System.Windows.Forms.GroupBox SetPinActionOptions;
        private System.Windows.Forms.RadioButton TogglePinAction;
        private System.Windows.Forms.GroupBox TogglePinActionOptions;
        private System.Windows.Forms.Label TogglePinActionPinOptionLabel;
        private System.Windows.Forms.NumericUpDown TogglePinActionPinOption;
    }
}