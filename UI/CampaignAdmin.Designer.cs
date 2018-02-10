namespace UI
{
    partial class CampaignAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.campaignsGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CampaignName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.campaignsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // campaignsGridView
            // 
            this.campaignsGridView.AllowUserToAddRows = false;
            this.campaignsGridView.AllowUserToDeleteRows = false;
            this.campaignsGridView.AllowUserToOrderColumns = true;
            this.campaignsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.campaignsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CampaignName,
            this.Description});
            this.campaignsGridView.Location = new System.Drawing.Point(12, 82);
            this.campaignsGridView.MultiSelect = false;
            this.campaignsGridView.Name = "campaignsGridView";
            this.campaignsGridView.ReadOnly = true;
            this.campaignsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.campaignsGridView.Size = new System.Drawing.Size(881, 384);
            this.campaignsGridView.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // CampaignName
            // 
            this.CampaignName.DataPropertyName = "Name";
            this.CampaignName.HeaderText = "Nombre";
            this.CampaignName.Name = "CampaignName";
            this.CampaignName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Descripcion";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // CampaignAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 478);
            this.Controls.Add(this.campaignsGridView);
            this.Name = "CampaignAdmin";
            this.Text = "CampaignAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.campaignsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView campaignsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CampaignName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}