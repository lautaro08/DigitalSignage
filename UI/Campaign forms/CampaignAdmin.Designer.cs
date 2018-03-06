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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.campaignsGridView = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CampignName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyCampaignButton = new MetroFramework.Controls.MetroButton();
            this.deleteCampaignButton = new MetroFramework.Controls.MetroButton();
            this.addCampaignButton = new MetroFramework.Controls.MetroButton();
            this.filterComboBox = new MetroFramework.Controls.MetroComboBox();
            this.searchButton = new MetroFramework.Controls.MetroButton();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.searchDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.campaignsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // campaignsGridView
            // 
            this.campaignsGridView.AllowUserToAddRows = false;
            this.campaignsGridView.AllowUserToDeleteRows = false;
            this.campaignsGridView.AllowUserToOrderColumns = true;
            this.campaignsGridView.AllowUserToResizeRows = false;
            this.campaignsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.campaignsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.campaignsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campaignsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.campaignsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.campaignsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.campaignsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.campaignsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CampignName,
            this.Description});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.campaignsGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.campaignsGridView.EnableHeadersVisualStyles = false;
            this.campaignsGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.campaignsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.campaignsGridView.Location = new System.Drawing.Point(23, 104);
            this.campaignsGridView.Name = "campaignsGridView";
            this.campaignsGridView.ReadOnly = true;
            this.campaignsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.campaignsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.campaignsGridView.RowHeadersVisible = false;
            this.campaignsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.campaignsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.campaignsGridView.Size = new System.Drawing.Size(888, 323);
            this.campaignsGridView.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // CampignName
            // 
            this.CampignName.DataPropertyName = "Name";
            this.CampignName.HeaderText = "Nombre";
            this.CampignName.Name = "CampignName";
            this.CampignName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Descripcion";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // modifyCampaignButton
            // 
            this.modifyCampaignButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyCampaignButton.Location = new System.Drawing.Point(310, 433);
            this.modifyCampaignButton.Name = "modifyCampaignButton";
            this.modifyCampaignButton.Size = new System.Drawing.Size(314, 23);
            this.modifyCampaignButton.TabIndex = 29;
            this.modifyCampaignButton.Text = "modificar campaña";
            this.modifyCampaignButton.UseSelectable = true;
            this.modifyCampaignButton.Click += new System.EventHandler(this.modifyCampaignButton_Click);
            // 
            // deleteCampaignButton
            // 
            this.deleteCampaignButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteCampaignButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteCampaignButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteCampaignButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteCampaignButton.Location = new System.Drawing.Point(23, 433);
            this.deleteCampaignButton.Name = "deleteCampaignButton";
            this.deleteCampaignButton.Size = new System.Drawing.Size(287, 23);
            this.deleteCampaignButton.Style = MetroFramework.MetroColorStyle.Red;
            this.deleteCampaignButton.TabIndex = 28;
            this.deleteCampaignButton.Text = "eliminar campaña";
            this.deleteCampaignButton.UseSelectable = true;
            this.deleteCampaignButton.UseStyleColors = true;
            this.deleteCampaignButton.Click += new System.EventHandler(this.deleteCampaignButton_Click);
            // 
            // addCampaignButton
            // 
            this.addCampaignButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addCampaignButton.BackColor = System.Drawing.Color.LightGreen;
            this.addCampaignButton.Location = new System.Drawing.Point(624, 433);
            this.addCampaignButton.Name = "addCampaignButton";
            this.addCampaignButton.Size = new System.Drawing.Size(287, 23);
            this.addCampaignButton.Style = MetroFramework.MetroColorStyle.Green;
            this.addCampaignButton.TabIndex = 27;
            this.addCampaignButton.Text = "agregar campaña";
            this.addCampaignButton.UseSelectable = true;
            this.addCampaignButton.UseStyleColors = true;
            this.addCampaignButton.Click += new System.EventHandler(this.addCampaignButton_Click);
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.ItemHeight = 23;
            this.filterComboBox.Location = new System.Drawing.Point(140, 69);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(237, 29);
            this.filterComboBox.TabIndex = 30;
            this.filterComboBox.UseSelectable = true;
            this.filterComboBox.SelectedValueChanged += new System.EventHandler(this.filterComboBox_SelectedValueChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(650, 69);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(261, 29);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "buscar";
            this.searchButton.UseSelectable = true;
            this.searchButton.Visible = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            // 
            // 
            // 
            this.searchTextBox.CustomButton.Image = null;
            this.searchTextBox.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.searchTextBox.CustomButton.Name = "";
            this.searchTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.searchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTextBox.CustomButton.TabIndex = 1;
            this.searchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTextBox.CustomButton.UseSelectable = true;
            this.searchTextBox.CustomButton.Visible = false;
            this.searchTextBox.Lines = new string[0];
            this.searchTextBox.Location = new System.Drawing.Point(383, 69);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.SelectionLength = 0;
            this.searchTextBox.SelectionStart = 0;
            this.searchTextBox.ShortcutsEnabled = true;
            this.searchTextBox.Size = new System.Drawing.Size(237, 29);
            this.searchTextBox.TabIndex = 32;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.searchTextBox_Validating);
            // 
            // searchDatePicker
            // 
            this.searchDatePicker.Location = new System.Drawing.Point(383, 69);
            this.searchDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.searchDatePicker.Name = "searchDatePicker";
            this.searchDatePicker.Size = new System.Drawing.Size(237, 29);
            this.searchDatePicker.TabIndex = 33;
            this.searchDatePicker.Visible = false;
            this.searchDatePicker.ValueChanged += new System.EventHandler(this.searchDatePicker_ValueChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(16, 74);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(118, 19);
            this.nameLabel.TabIndex = 34;
            this.nameLabel.Text = "listado filtrado por";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CampaignAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(929, 478);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.searchDatePicker);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.modifyCampaignButton);
            this.Controls.Add(this.deleteCampaignButton);
            this.Controls.Add(this.addCampaignButton);
            this.Controls.Add(this.campaignsGridView);
            this.Name = "CampaignAdmin";
            this.Text = "Administrador de campañas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.campaignsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid campaignsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CampignName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private MetroFramework.Controls.MetroButton modifyCampaignButton;
        private MetroFramework.Controls.MetroButton deleteCampaignButton;
        private MetroFramework.Controls.MetroButton addCampaignButton;
        private MetroFramework.Controls.MetroComboBox filterComboBox;
        private MetroFramework.Controls.MetroButton searchButton;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroDateTime searchDatePicker;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}