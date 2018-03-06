namespace UI.RssSource_source_forms
{
    partial class RssSourceAdmin
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
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.searchButton = new MetroFramework.Controls.MetroButton();
            this.filterComboBox = new MetroFramework.Controls.MetroComboBox();
            this.modifyRssSourceButton = new MetroFramework.Controls.MetroButton();
            this.deleteRssSourceButton = new MetroFramework.Controls.MetroButton();
            this.addRssSourceButton = new MetroFramework.Controls.MetroButton();
            this.rssSourcesGridView = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.selectRssSourceButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.rssSourcesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(16, 72);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(118, 19);
            this.nameLabel.TabIndex = 52;
            this.nameLabel.Text = "listado filtrado por";
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
            this.searchTextBox.Location = new System.Drawing.Point(383, 67);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.SelectionLength = 0;
            this.searchTextBox.SelectionStart = 0;
            this.searchTextBox.ShortcutsEnabled = true;
            this.searchTextBox.Size = new System.Drawing.Size(237, 29);
            this.searchTextBox.TabIndex = 50;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.searchTextBox_Validating);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(650, 67);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(261, 29);
            this.searchButton.TabIndex = 49;
            this.searchButton.Text = "buscar";
            this.searchButton.UseSelectable = true;
            this.searchButton.Visible = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.ItemHeight = 23;
            this.filterComboBox.Location = new System.Drawing.Point(140, 67);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(237, 29);
            this.filterComboBox.TabIndex = 48;
            this.filterComboBox.UseSelectable = true;
            this.filterComboBox.SelectedValueChanged += new System.EventHandler(this.filterComboBox_SelectedValueChanged);
            // 
            // modifyRssSourceButton
            // 
            this.modifyRssSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyRssSourceButton.Location = new System.Drawing.Point(310, 431);
            this.modifyRssSourceButton.Name = "modifyRssSourceButton";
            this.modifyRssSourceButton.Size = new System.Drawing.Size(314, 23);
            this.modifyRssSourceButton.TabIndex = 47;
            this.modifyRssSourceButton.Text = "modificar fuente RSS";
            this.modifyRssSourceButton.UseSelectable = true;
            this.modifyRssSourceButton.Click += new System.EventHandler(this.modifyRssSourceButton_Click);
            // 
            // deleteRssSourceButton
            // 
            this.deleteRssSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteRssSourceButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteRssSourceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteRssSourceButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteRssSourceButton.Location = new System.Drawing.Point(23, 431);
            this.deleteRssSourceButton.Name = "deleteRssSourceButton";
            this.deleteRssSourceButton.Size = new System.Drawing.Size(287, 23);
            this.deleteRssSourceButton.Style = MetroFramework.MetroColorStyle.Red;
            this.deleteRssSourceButton.TabIndex = 46;
            this.deleteRssSourceButton.Text = "eliminar fuente RSS";
            this.deleteRssSourceButton.UseSelectable = true;
            this.deleteRssSourceButton.UseStyleColors = true;
            this.deleteRssSourceButton.Click += new System.EventHandler(this.deleteRssSourceButton_Click);
            // 
            // addRssSourceButton
            // 
            this.addRssSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addRssSourceButton.BackColor = System.Drawing.Color.LightGreen;
            this.addRssSourceButton.Location = new System.Drawing.Point(624, 431);
            this.addRssSourceButton.Name = "addRssSourceButton";
            this.addRssSourceButton.Size = new System.Drawing.Size(287, 23);
            this.addRssSourceButton.Style = MetroFramework.MetroColorStyle.Green;
            this.addRssSourceButton.TabIndex = 45;
            this.addRssSourceButton.Text = "agregar fuente RSS";
            this.addRssSourceButton.UseSelectable = true;
            this.addRssSourceButton.UseStyleColors = true;
            this.addRssSourceButton.Click += new System.EventHandler(this.addRssSourceButton_Click);
            // 
            // rssSourcesGridView
            // 
            this.rssSourcesGridView.AllowUserToAddRows = false;
            this.rssSourcesGridView.AllowUserToDeleteRows = false;
            this.rssSourcesGridView.AllowUserToOrderColumns = true;
            this.rssSourcesGridView.AllowUserToResizeRows = false;
            this.rssSourcesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rssSourcesGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rssSourcesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rssSourcesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.rssSourcesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rssSourcesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.rssSourcesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rssSourcesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Description,
            this.Url});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rssSourcesGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.rssSourcesGridView.EnableHeadersVisualStyles = false;
            this.rssSourcesGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rssSourcesGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rssSourcesGridView.Location = new System.Drawing.Point(23, 102);
            this.rssSourcesGridView.Name = "rssSourcesGridView";
            this.rssSourcesGridView.ReadOnly = true;
            this.rssSourcesGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rssSourcesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.rssSourcesGridView.RowHeadersVisible = false;
            this.rssSourcesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.rssSourcesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rssSourcesGridView.Size = new System.Drawing.Size(888, 323);
            this.rssSourcesGridView.TabIndex = 44;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Descripcion";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Url
            // 
            this.Url.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Url.DataPropertyName = "Url";
            this.Url.HeaderText = "Url";
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // selectRssSourceButton
            // 
            this.selectRssSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectRssSourceButton.Location = new System.Drawing.Point(310, 431);
            this.selectRssSourceButton.Name = "selectRssSourceButton";
            this.selectRssSourceButton.Size = new System.Drawing.Size(314, 23);
            this.selectRssSourceButton.TabIndex = 53;
            this.selectRssSourceButton.Text = "seleccionar fuente RSS";
            this.selectRssSourceButton.UseSelectable = true;
            this.selectRssSourceButton.Visible = false;
            this.selectRssSourceButton.Click += new System.EventHandler(this.selectRssSourceButton_Click);
            // 
            // RssSourceAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(929, 478);
            this.Controls.Add(this.selectRssSourceButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.modifyRssSourceButton);
            this.Controls.Add(this.deleteRssSourceButton);
            this.Controls.Add(this.addRssSourceButton);
            this.Controls.Add(this.rssSourcesGridView);
            this.Name = "RssSourceAdmin";
            this.Text = "Administrador de fuentes RSS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.rssSourcesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroButton searchButton;
        private MetroFramework.Controls.MetroComboBox filterComboBox;
        private MetroFramework.Controls.MetroButton modifyRssSourceButton;
        private MetroFramework.Controls.MetroButton deleteRssSourceButton;
        private MetroFramework.Controls.MetroButton addRssSourceButton;
        private MetroFramework.Controls.MetroGrid rssSourcesGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private MetroFramework.Controls.MetroButton selectRssSourceButton;
    }
}