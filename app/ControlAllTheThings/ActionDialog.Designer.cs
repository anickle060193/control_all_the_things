namespace ControlAllTheThings
{
    partial class ActionDialog
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
            this.SetPinActionStateOption = new System.Windows.Forms.CheckBox();
            this.ActionFormTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RunScriptAction = new System.Windows.Forms.RadioButton();
            this.SetPinActionOptions = new System.Windows.Forms.GroupBox();
            this.SetPinActionPinOption = new System.Windows.Forms.ComboBox();
            this.TogglePinAction = new System.Windows.Forms.RadioButton();
            this.TogglePinActionOptions = new System.Windows.Forms.GroupBox();
            this.TogglePinActionPinOption = new System.Windows.Forms.ComboBox();
            this.TogglePinActionPinOptionLabel = new System.Windows.Forms.Label();
            this.NoAction = new System.Windows.Forms.RadioButton();
            this.NoActionLabel = new System.Windows.Forms.Label();
            this.RunScriptActionOptions = new System.Windows.Forms.GroupBox();
            this.RunScriptActionArgumentsOption = new System.Windows.Forms.TextBox();
            this.RunScriptActionFileNameOption = new System.Windows.Forms.TextBox();
            this.RunScriptActionArgumentsOptionLabel = new System.Windows.Forms.Label();
            this.RunScriptActionFileNameOptionLabel = new System.Windows.Forms.Label();
            this.TestAction = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SendTextAction = new System.Windows.Forms.RadioButton();
            this.SendTextActionOptions = new System.Windows.Forms.GroupBox();
            this.SendTextActionTextOptionLabel = new System.Windows.Forms.Label();
            this.SendTextActionTextOption = new System.Windows.Forms.TextBox();
            this.SetLedActionOptions.SuspendLayout();
            this.ActionFormTableLayout.SuspendLayout();
            this.SetPinActionOptions.SuspendLayout();
            this.TogglePinActionOptions.SuspendLayout();
            this.RunScriptActionOptions.SuspendLayout();
            this.SendTextActionOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetLedAction
            // 
            this.SetLedAction.AutoSize = true;
            this.SetLedAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetLedAction.Location = new System.Drawing.Point(3, 22);
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
            this.SetLedActionOptions.Location = new System.Drawing.Point(23, 22);
            this.SetLedActionOptions.Name = "SetLedActionOptions";
            this.SetLedActionOptions.Size = new System.Drawing.Size(292, 45);
            this.SetLedActionOptions.TabIndex = 9;
            this.SetLedActionOptions.TabStop = false;
            this.SetLedActionOptions.Text = "Set LED";
            // 
            // SetLedActionStateOption
            // 
            this.SetLedActionStateOption.AutoSize = true;
            this.SetLedActionStateOption.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SetLedActionStateOption.Location = new System.Drawing.Point(6, 19);
            this.SetLedActionStateOption.Name = "SetLedActionStateOption";
            this.SetLedActionStateOption.Size = new System.Drawing.Size(78, 17);
            this.SetLedActionStateOption.TabIndex = 4;
            this.SetLedActionStateOption.Text = "LED State:";
            this.SetLedActionStateOption.UseVisualStyleBackColor = true;
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.Location = new System.Drawing.Point(239, 327);
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
            this.SetPinAction.Location = new System.Drawing.Point(3, 73);
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
            // SetPinActionStateOption
            // 
            this.SetPinActionStateOption.AutoSize = true;
            this.SetPinActionStateOption.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SetPinActionStateOption.Location = new System.Drawing.Point(78, 20);
            this.SetPinActionStateOption.Name = "SetPinActionStateOption";
            this.SetPinActionStateOption.Size = new System.Drawing.Size(72, 17);
            this.SetPinActionStateOption.TabIndex = 8;
            this.SetPinActionStateOption.Text = "Pin State:";
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
            this.ActionFormTableLayout.Controls.Add(this.RunScriptAction, 0, 4);
            this.ActionFormTableLayout.Controls.Add(this.SetLedAction, 0, 1);
            this.ActionFormTableLayout.Controls.Add(this.SetLedActionOptions, 1, 1);
            this.ActionFormTableLayout.Controls.Add(this.SetPinAction, 0, 2);
            this.ActionFormTableLayout.Controls.Add(this.SetPinActionOptions, 1, 2);
            this.ActionFormTableLayout.Controls.Add(this.TogglePinAction, 0, 3);
            this.ActionFormTableLayout.Controls.Add(this.TogglePinActionOptions, 1, 3);
            this.ActionFormTableLayout.Controls.Add(this.NoAction, 0, 0);
            this.ActionFormTableLayout.Controls.Add(this.NoActionLabel, 1, 0);
            this.ActionFormTableLayout.Controls.Add(this.RunScriptActionOptions, 1, 4);
            this.ActionFormTableLayout.Controls.Add(this.SendTextAction, 0, 5);
            this.ActionFormTableLayout.Controls.Add(this.SendTextActionOptions, 1, 5);
            this.ActionFormTableLayout.Location = new System.Drawing.Point(4, 4);
            this.ActionFormTableLayout.Name = "ActionFormTableLayout";
            this.ActionFormTableLayout.RowCount = 7;
            this.ActionFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ActionFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ActionFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ActionFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ActionFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ActionFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ActionFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ActionFormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ActionFormTableLayout.Size = new System.Drawing.Size(318, 317);
            this.ActionFormTableLayout.TabIndex = 10;
            // 
            // RunScriptAction
            // 
            this.RunScriptAction.AutoSize = true;
            this.RunScriptAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RunScriptAction.Location = new System.Drawing.Point(3, 181);
            this.RunScriptAction.Name = "RunScriptAction";
            this.RunScriptAction.Size = new System.Drawing.Size(14, 76);
            this.RunScriptAction.TabIndex = 15;
            this.RunScriptAction.UseVisualStyleBackColor = true;
            this.RunScriptAction.CheckedChanged += new System.EventHandler(this.Action_CheckedChanged);
            // 
            // SetPinActionOptions
            // 
            this.SetPinActionOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetPinActionOptions.Controls.Add(this.SetPinActionPinOption);
            this.SetPinActionOptions.Controls.Add(this.SetPinActionPinOptionLabel);
            this.SetPinActionOptions.Controls.Add(this.SetPinActionStateOption);
            this.SetPinActionOptions.Location = new System.Drawing.Point(23, 73);
            this.SetPinActionOptions.Name = "SetPinActionOptions";
            this.SetPinActionOptions.Size = new System.Drawing.Size(292, 48);
            this.SetPinActionOptions.TabIndex = 10;
            this.SetPinActionOptions.TabStop = false;
            this.SetPinActionOptions.Text = "Set Pin";
            // 
            // SetPinActionPinOption
            // 
            this.SetPinActionPinOption.FormattingEnabled = true;
            this.SetPinActionPinOption.Location = new System.Drawing.Point(37, 18);
            this.SetPinActionPinOption.Name = "SetPinActionPinOption";
            this.SetPinActionPinOption.Size = new System.Drawing.Size(35, 21);
            this.SetPinActionPinOption.TabIndex = 9;
            // 
            // TogglePinAction
            // 
            this.TogglePinAction.AutoSize = true;
            this.TogglePinAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TogglePinAction.Location = new System.Drawing.Point(3, 127);
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
            this.TogglePinActionOptions.Controls.Add(this.TogglePinActionPinOption);
            this.TogglePinActionOptions.Controls.Add(this.TogglePinActionPinOptionLabel);
            this.TogglePinActionOptions.Location = new System.Drawing.Point(23, 127);
            this.TogglePinActionOptions.Name = "TogglePinActionOptions";
            this.TogglePinActionOptions.Size = new System.Drawing.Size(292, 48);
            this.TogglePinActionOptions.TabIndex = 12;
            this.TogglePinActionOptions.TabStop = false;
            this.TogglePinActionOptions.Text = "Toggle Pin";
            // 
            // TogglePinActionPinOption
            // 
            this.TogglePinActionPinOption.FormattingEnabled = true;
            this.TogglePinActionPinOption.Location = new System.Drawing.Point(37, 18);
            this.TogglePinActionPinOption.Name = "TogglePinActionPinOption";
            this.TogglePinActionPinOption.Size = new System.Drawing.Size(35, 21);
            this.TogglePinActionPinOption.TabIndex = 10;
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
            // NoAction
            // 
            this.NoAction.AutoSize = true;
            this.NoAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoAction.Location = new System.Drawing.Point(3, 3);
            this.NoAction.Name = "NoAction";
            this.NoAction.Size = new System.Drawing.Size(14, 13);
            this.NoAction.TabIndex = 13;
            this.NoAction.UseVisualStyleBackColor = true;
            this.NoAction.CheckedChanged += new System.EventHandler(this.Action_CheckedChanged);
            // 
            // NoActionLabel
            // 
            this.NoActionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoActionLabel.AutoSize = true;
            this.NoActionLabel.Location = new System.Drawing.Point(23, 0);
            this.NoActionLabel.Name = "NoActionLabel";
            this.NoActionLabel.Size = new System.Drawing.Size(292, 19);
            this.NoActionLabel.TabIndex = 14;
            this.NoActionLabel.Text = "No Action";
            this.NoActionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RunScriptActionOptions
            // 
            this.RunScriptActionOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RunScriptActionOptions.Controls.Add(this.RunScriptActionArgumentsOption);
            this.RunScriptActionOptions.Controls.Add(this.RunScriptActionFileNameOption);
            this.RunScriptActionOptions.Controls.Add(this.RunScriptActionArgumentsOptionLabel);
            this.RunScriptActionOptions.Controls.Add(this.RunScriptActionFileNameOptionLabel);
            this.RunScriptActionOptions.Location = new System.Drawing.Point(23, 181);
            this.RunScriptActionOptions.Name = "RunScriptActionOptions";
            this.RunScriptActionOptions.Size = new System.Drawing.Size(292, 76);
            this.RunScriptActionOptions.TabIndex = 16;
            this.RunScriptActionOptions.TabStop = false;
            this.RunScriptActionOptions.Text = "Run Script";
            // 
            // RunScriptActionArgumentsOption
            // 
            this.RunScriptActionArgumentsOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RunScriptActionArgumentsOption.Location = new System.Drawing.Point(72, 45);
            this.RunScriptActionArgumentsOption.Name = "RunScriptActionArgumentsOption";
            this.RunScriptActionArgumentsOption.Size = new System.Drawing.Size(214, 20);
            this.RunScriptActionArgumentsOption.TabIndex = 3;
            // 
            // RunScriptActionFileNameOption
            // 
            this.RunScriptActionFileNameOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RunScriptActionFileNameOption.Location = new System.Drawing.Point(72, 19);
            this.RunScriptActionFileNameOption.Name = "RunScriptActionFileNameOption";
            this.RunScriptActionFileNameOption.Size = new System.Drawing.Size(214, 20);
            this.RunScriptActionFileNameOption.TabIndex = 2;
            // 
            // RunScriptActionArgumentsOptionLabel
            // 
            this.RunScriptActionArgumentsOptionLabel.AutoSize = true;
            this.RunScriptActionArgumentsOptionLabel.Location = new System.Drawing.Point(6, 48);
            this.RunScriptActionArgumentsOptionLabel.Name = "RunScriptActionArgumentsOptionLabel";
            this.RunScriptActionArgumentsOptionLabel.Size = new System.Drawing.Size(60, 13);
            this.RunScriptActionArgumentsOptionLabel.TabIndex = 1;
            this.RunScriptActionArgumentsOptionLabel.Text = "Arguments:";
            // 
            // RunScriptActionFileNameOptionLabel
            // 
            this.RunScriptActionFileNameOptionLabel.AutoSize = true;
            this.RunScriptActionFileNameOptionLabel.Location = new System.Drawing.Point(6, 22);
            this.RunScriptActionFileNameOptionLabel.Name = "RunScriptActionFileNameOptionLabel";
            this.RunScriptActionFileNameOptionLabel.Size = new System.Drawing.Size(57, 13);
            this.RunScriptActionFileNameOptionLabel.TabIndex = 0;
            this.RunScriptActionFileNameOptionLabel.Text = "File Name:";
            // 
            // TestAction
            // 
            this.TestAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TestAction.Location = new System.Drawing.Point(12, 327);
            this.TestAction.Name = "TestAction";
            this.TestAction.Size = new System.Drawing.Size(75, 23);
            this.TestAction.TabIndex = 11;
            this.TestAction.Text = "Test Action";
            this.TestAction.UseVisualStyleBackColor = true;
            this.TestAction.Click += new System.EventHandler(this.TestAction_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(158, 327);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SendTextAction
            // 
            this.SendTextAction.AutoSize = true;
            this.SendTextAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendTextAction.Location = new System.Drawing.Point(3, 263);
            this.SendTextAction.Name = "SendTextAction";
            this.SendTextAction.Size = new System.Drawing.Size(14, 50);
            this.SendTextAction.TabIndex = 17;
            this.SendTextAction.TabStop = true;
            this.SendTextAction.UseVisualStyleBackColor = true;
            this.SendTextAction.CheckedChanged += new System.EventHandler(this.Action_CheckedChanged);
            // 
            // SendTextActionOptions
            // 
            this.SendTextActionOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendTextActionOptions.Controls.Add(this.SendTextActionTextOption);
            this.SendTextActionOptions.Controls.Add(this.SendTextActionTextOptionLabel);
            this.SendTextActionOptions.Location = new System.Drawing.Point(23, 263);
            this.SendTextActionOptions.Name = "SendTextActionOptions";
            this.SendTextActionOptions.Size = new System.Drawing.Size(292, 50);
            this.SendTextActionOptions.TabIndex = 18;
            this.SendTextActionOptions.TabStop = false;
            this.SendTextActionOptions.Text = "Send Text";
            // 
            // SendTextActionTextOptionLabel
            // 
            this.SendTextActionTextOptionLabel.AutoSize = true;
            this.SendTextActionTextOptionLabel.Location = new System.Drawing.Point(6, 22);
            this.SendTextActionTextOptionLabel.Name = "SendTextActionTextOptionLabel";
            this.SendTextActionTextOptionLabel.Size = new System.Drawing.Size(31, 13);
            this.SendTextActionTextOptionLabel.TabIndex = 4;
            this.SendTextActionTextOptionLabel.Text = "Text:";
            // 
            // SendTextActionTextOption
            // 
            this.SendTextActionTextOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendTextActionTextOption.Location = new System.Drawing.Point(43, 19);
            this.SendTextActionTextOption.Name = "SendTextActionTextOption";
            this.SendTextActionTextOption.Size = new System.Drawing.Size(243, 20);
            this.SendTextActionTextOption.TabIndex = 4;
            // 
            // ActionDialog
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(326, 362);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.TestAction);
            this.Controls.Add(this.ActionFormTableLayout);
            this.Controls.Add(this.Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Action";
            this.SetLedActionOptions.ResumeLayout(false);
            this.SetLedActionOptions.PerformLayout();
            this.ActionFormTableLayout.ResumeLayout(false);
            this.ActionFormTableLayout.PerformLayout();
            this.SetPinActionOptions.ResumeLayout(false);
            this.SetPinActionOptions.PerformLayout();
            this.TogglePinActionOptions.ResumeLayout(false);
            this.TogglePinActionOptions.PerformLayout();
            this.RunScriptActionOptions.ResumeLayout(false);
            this.RunScriptActionOptions.PerformLayout();
            this.SendTextActionOptions.ResumeLayout(false);
            this.SendTextActionOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton SetLedAction;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.CheckBox SetLedActionStateOption;
        private System.Windows.Forms.RadioButton SetPinAction;
        private System.Windows.Forms.Label SetPinActionPinOptionLabel;
        private System.Windows.Forms.CheckBox SetPinActionStateOption;
        private System.Windows.Forms.GroupBox SetLedActionOptions;
        private System.Windows.Forms.TableLayoutPanel ActionFormTableLayout;
        private System.Windows.Forms.GroupBox SetPinActionOptions;
        private System.Windows.Forms.RadioButton TogglePinAction;
        private System.Windows.Forms.GroupBox TogglePinActionOptions;
        private System.Windows.Forms.Label TogglePinActionPinOptionLabel;
        private System.Windows.Forms.ComboBox SetPinActionPinOption;
        private System.Windows.Forms.ComboBox TogglePinActionPinOption;
        private System.Windows.Forms.RadioButton NoAction;
        private System.Windows.Forms.Label NoActionLabel;
        private System.Windows.Forms.Button TestAction;
        private System.Windows.Forms.RadioButton RunScriptAction;
        private System.Windows.Forms.GroupBox RunScriptActionOptions;
        private System.Windows.Forms.TextBox RunScriptActionArgumentsOption;
        private System.Windows.Forms.TextBox RunScriptActionFileNameOption;
        private System.Windows.Forms.Label RunScriptActionArgumentsOptionLabel;
        private System.Windows.Forms.Label RunScriptActionFileNameOptionLabel;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.RadioButton SendTextAction;
        private System.Windows.Forms.GroupBox SendTextActionOptions;
        private System.Windows.Forms.Label SendTextActionTextOptionLabel;
        private System.Windows.Forms.TextBox SendTextActionTextOption;
    }
}