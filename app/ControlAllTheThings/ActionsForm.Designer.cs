namespace ControlAllTheThings
{
    partial class ActionsForm
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
            this.ActionsGridView = new System.Windows.Forms.DataGridView();
            this.ActionsColumnAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionsColumnRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddAction = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ActionsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionsGridView
            // 
            this.ActionsGridView.AllowUserToAddRows = false;
            this.ActionsGridView.AllowUserToDeleteRows = false;
            this.ActionsGridView.AllowUserToResizeColumns = false;
            this.ActionsGridView.AllowUserToResizeRows = false;
            this.ActionsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ActionsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ActionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActionsColumnAction,
            this.ActionsColumnRemove});
            this.ActionsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ActionsGridView.Location = new System.Drawing.Point(12, 12);
            this.ActionsGridView.MultiSelect = false;
            this.ActionsGridView.Name = "ActionsGridView";
            this.ActionsGridView.ReadOnly = true;
            this.ActionsGridView.RowHeadersVisible = false;
            this.ActionsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ActionsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActionsGridView.Size = new System.Drawing.Size(321, 222);
            this.ActionsGridView.TabIndex = 0;
            this.ActionsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActionsGridView_CellContentClick);
            this.ActionsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActionsGridView_CellDoubleClick);
            // 
            // ActionsColumnAction
            // 
            this.ActionsColumnAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActionsColumnAction.HeaderText = "Action";
            this.ActionsColumnAction.Name = "ActionsColumnAction";
            this.ActionsColumnAction.ReadOnly = true;
            // 
            // ActionsColumnRemove
            // 
            this.ActionsColumnRemove.HeaderText = "";
            this.ActionsColumnRemove.Name = "ActionsColumnRemove";
            this.ActionsColumnRemove.ReadOnly = true;
            this.ActionsColumnRemove.Width = 5;
            // 
            // AddAction
            // 
            this.AddAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAction.Location = new System.Drawing.Point(177, 240);
            this.AddAction.Name = "AddAction";
            this.AddAction.Size = new System.Drawing.Size(75, 23);
            this.AddAction.TabIndex = 1;
            this.AddAction.Text = "Add Action";
            this.AddAction.UseVisualStyleBackColor = true;
            this.AddAction.Click += new System.EventHandler(this.AddAction_Click);
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.Location = new System.Drawing.Point(258, 240);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 2;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // ActionsForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 275);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.AddAction);
            this.Controls.Add(this.ActionsGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionsForm";
            this.Text = "Actions";
            ((System.ComponentModel.ISupportInitialize)(this.ActionsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ActionsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionsColumnAction;
        private System.Windows.Forms.DataGridViewButtonColumn ActionsColumnRemove;
        private System.Windows.Forms.Button AddAction;
        private System.Windows.Forms.Button Ok;


    }
}