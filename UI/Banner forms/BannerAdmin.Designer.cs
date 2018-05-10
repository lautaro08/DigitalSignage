namespace UI
{
    partial class BannerAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.searchDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.searchButton = new MetroFramework.Controls.MetroButton();
            this.filterComboBox = new MetroFramework.Controls.MetroComboBox();
            this.modifyBannerButton = new MetroFramework.Controls.MetroButton();
            this.deleteBannerButton = new MetroFramework.Controls.MetroButton();
            this.addBannerButton = new MetroFramework.Controls.MetroButton();
            this.bannersGridView = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CampignName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bannersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(16, 74);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(118, 19);
            this.nameLabel.TabIndex = 43;
            this.nameLabel.Text = "listado filtrado por";
            // 
            // searchDatePicker
            // 
            this.searchDatePicker.Location = new System.Drawing.Point(383, 69);
            this.searchDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.searchDatePicker.Name = "searchDatePicker";
            this.searchDatePicker.Size = new System.Drawing.Size(237, 29);
            this.searchDatePicker.TabIndex = 42;
            this.searchDatePicker.Visible = false;
            this.searchDatePicker.ValueChanged += new System.EventHandler(this.searchDatePicker_ValueChanged);
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
            this.searchTextBox.TabIndex = 41;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.searchTextBox_Validating);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(650, 69);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(261, 29);
            this.searchButton.TabIndex = 40;
            this.searchButton.Text = "buscar";
            this.searchButton.UseSelectable = true;
            this.searchButton.Visible = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.ItemHeight = 23;
            this.filterComboBox.Location = new System.Drawing.Point(140, 69);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(237, 29);
            this.filterComboBox.TabIndex = 39;
            this.filterComboBox.UseSelectable = true;
            this.filterComboBox.SelectedValueChanged += new System.EventHandler(this.filterComboBox_SelectedValueChanged);
            // 
            // modifyBannerButton
            // 
            this.modifyBannerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyBannerButton.Location = new System.Drawing.Point(310, 433);
            this.modifyBannerButton.Name = "modifyBannerButton";
            this.modifyBannerButton.Size = new System.Drawing.Size(314, 23);
            this.modifyBannerButton.TabIndex = 38;
            this.modifyBannerButton.Text = "modificar banner";
            this.modifyBannerButton.UseSelectable = true;
            this.modifyBannerButton.Click += new System.EventHandler(this.modifyBannerButton_Click);
            // 
            // deleteBannerButton
            // 
            this.deleteBannerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteBannerButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteBannerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteBannerButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteBannerButton.Location = new System.Drawing.Point(23, 433);
            this.deleteBannerButton.Name = "deleteBannerButton";
            this.deleteBannerButton.Size = new System.Drawing.Size(287, 23);
            this.deleteBannerButton.Style = MetroFramework.MetroColorStyle.Red;
            this.deleteBannerButton.TabIndex = 37;
            this.deleteBannerButton.Text = "eliminar banner";
            this.deleteBannerButton.UseSelectable = true;
            this.deleteBannerButton.UseStyleColors = true;
            this.deleteBannerButton.Click += new System.EventHandler(this.deleteBannerButton_Click);
            // 
            // addBannerButton
            // 
            this.addBannerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBannerButton.BackColor = System.Drawing.Color.LightGreen;
            this.addBannerButton.Location = new System.Drawing.Point(624, 433);
            this.addBannerButton.Name = "addBannerButton";
            this.addBannerButton.Size = new System.Drawing.Size(287, 23);
            this.addBannerButton.Style = MetroFramework.MetroColorStyle.Green;
            this.addBannerButton.TabIndex = 36;
            this.addBannerButton.Text = "agregar banner";
            this.addBannerButton.UseSelectable = true;
            this.addBannerButton.UseStyleColors = true;
            this.addBannerButton.Click += new System.EventHandler(this.addBannerButton_Click);
            // 
            // bannersGridView
            // 
            this.bannersGridView.AllowUserToAddRows = false;
            this.bannersGridView.AllowUserToDeleteRows = false;
            this.bannersGridView.AllowUserToOrderColumns = true;
            this.bannersGridView.AllowUserToResizeRows = false;
            this.bannersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bannersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bannersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bannersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bannersGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bannersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bannersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bannersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CampignName,
            this.Description});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bannersGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.bannersGridView.EnableHeadersVisualStyles = false;
            this.bannersGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bannersGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bannersGridView.Location = new System.Drawing.Point(23, 104);
            this.bannersGridView.Name = "bannersGridView";
            this.bannersGridView.ReadOnly = true;
            this.bannersGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bannersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bannersGridView.RowHeadersVisible = false;
            this.bannersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bannersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bannersGridView.Size = new System.Drawing.Size(888, 323);
            this.bannersGridView.TabIndex = 35;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BannerAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(929, 478);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.searchDatePicker);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.modifyBannerButton);
            this.Controls.Add(this.deleteBannerButton);
            this.Controls.Add(this.addBannerButton);
            this.Controls.Add(this.bannersGridView);
            this.Name = "BannerAdmin";
            this.Text = "Administrador de banner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BannerAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bannersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroDateTime searchDatePicker;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroButton searchButton;
        private MetroFramework.Controls.MetroComboBox filterComboBox;
        private MetroFramework.Controls.MetroButton modifyBannerButton;
        private MetroFramework.Controls.MetroButton deleteBannerButton;
        private MetroFramework.Controls.MetroButton addBannerButton;
        private MetroFramework.Controls.MetroGrid bannersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CampignName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}