namespace UI
{
    partial class CampaignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampaignForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.initDateLabel = new MetroFramework.Controls.MetroLabel();
            this.initDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.endDateLabel = new MetroFramework.Controls.MetroLabel();
            this.endDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.initTimeLabel = new MetroFramework.Controls.MetroLabel();
            this.initTimePicker = new MetroFramework.Controls.MetroDateTime();
            this.endTimePicker = new MetroFramework.Controls.MetroDateTime();
            this.endTimeLabel = new MetroFramework.Controls.MetroLabel();
            this.campignImages = new System.Windows.Forms.ImageList(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.campaignImagesList = new MetroFramework.Controls.MetroGrid();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.campaignImagesList)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(23, 77);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 19);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nombre";
            // 
            // nameTextBox
            // 
            // 
            // 
            // 
            this.nameTextBox.CustomButton.Image = null;
            this.nameTextBox.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.nameTextBox.CustomButton.Name = "";
            this.nameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTextBox.CustomButton.TabIndex = 1;
            this.nameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTextBox.CustomButton.UseSelectable = true;
            this.nameTextBox.CustomButton.Visible = false;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(23, 99);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.ShortcutsEnabled = true;
            this.nameTextBox.Size = new System.Drawing.Size(282, 23);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.UseSelectable = true;
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nameTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Enabled = false;
            this.descriptionLabel.Location = new System.Drawing.Point(23, 134);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(76, 19);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Descripcion";
            // 
            // descriptionTextBox
            // 
            // 
            // 
            // 
            this.descriptionTextBox.CustomButton.Image = null;
            this.descriptionTextBox.CustomButton.Location = new System.Drawing.Point(244, 2);
            this.descriptionTextBox.CustomButton.Name = "";
            this.descriptionTextBox.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.descriptionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionTextBox.CustomButton.TabIndex = 1;
            this.descriptionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionTextBox.CustomButton.UseSelectable = true;
            this.descriptionTextBox.CustomButton.Visible = false;
            this.descriptionTextBox.Lines = new string[0];
            this.descriptionTextBox.Location = new System.Drawing.Point(23, 156);
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.SelectionLength = 0;
            this.descriptionTextBox.SelectionStart = 0;
            this.descriptionTextBox.ShortcutsEnabled = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(282, 40);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.UseSelectable = true;
            this.descriptionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // initDateLabel
            // 
            this.initDateLabel.AutoSize = true;
            this.initDateLabel.Location = new System.Drawing.Point(23, 208);
            this.initDateLabel.Name = "initDateLabel";
            this.initDateLabel.Size = new System.Drawing.Size(96, 19);
            this.initDateLabel.TabIndex = 4;
            this.initDateLabel.Text = "Fecha de inicio";
            // 
            // initDatePicker
            // 
            this.initDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.initDatePicker.Location = new System.Drawing.Point(23, 230);
            this.initDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.initDatePicker.Name = "initDatePicker";
            this.initDatePicker.Size = new System.Drawing.Size(96, 29);
            this.initDatePicker.TabIndex = 5;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(170, 208);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(80, 19);
            this.endDateLabel.TabIndex = 6;
            this.endDateLabel.Text = "Fecha de fin";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(170, 230);
            this.endDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(96, 29);
            this.endDatePicker.TabIndex = 7;
            // 
            // initTimeLabel
            // 
            this.initTimeLabel.AutoSize = true;
            this.initTimeLabel.Location = new System.Drawing.Point(23, 271);
            this.initTimeLabel.Name = "initTimeLabel";
            this.initTimeLabel.Size = new System.Drawing.Size(91, 19);
            this.initTimeLabel.TabIndex = 8;
            this.initTimeLabel.Text = "Hora de inicio";
            // 
            // initTimePicker
            // 
            this.initTimePicker.CustomFormat = "hh:mm";
            this.initTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.initTimePicker.Location = new System.Drawing.Point(23, 293);
            this.initTimePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.initTimePicker.Name = "initTimePicker";
            this.initTimePicker.Size = new System.Drawing.Size(96, 29);
            this.initTimePicker.TabIndex = 9;
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "hh:mm";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(170, 293);
            this.endTimePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(96, 29);
            this.endTimePicker.TabIndex = 11;
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(170, 271);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(75, 19);
            this.endTimeLabel.TabIndex = 10;
            this.endTimeLabel.Text = "Hora de fin";
            // 
            // campignImages
            // 
            this.campignImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("campignImages.ImageStream")));
            this.campignImages.TransparentColor = System.Drawing.Color.Transparent;
            this.campignImages.Images.SetKeyName(0, "banner.png");
            this.campignImages.Images.SetKeyName(1, "exit (1).png");
            this.campignImages.Images.SetKeyName(2, "fonts.png");
            this.campignImages.Images.SetKeyName(3, "monitor (1).png");
            this.campignImages.Images.SetKeyName(4, "monitor.png");
            this.campignImages.Images.SetKeyName(5, "moon (1).png");
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(359, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Imagenes";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // campaignImagesList
            // 
            this.campaignImagesList.AllowUserToAddRows = false;
            this.campaignImagesList.AllowUserToDeleteRows = false;
            this.campaignImagesList.AllowUserToResizeRows = false;
            this.campaignImagesList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.campaignImagesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campaignImagesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.campaignImagesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.campaignImagesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.campaignImagesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.campaignImagesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.Description,
            this.Duration,
            this.Order});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.campaignImagesList.DefaultCellStyle = dataGridViewCellStyle2;
            this.campaignImagesList.EnableHeadersVisualStyles = false;
            this.campaignImagesList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.campaignImagesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.campaignImagesList.Location = new System.Drawing.Point(359, 99);
            this.campaignImagesList.Name = "campaignImagesList";
            this.campaignImagesList.ReadOnly = true;
            this.campaignImagesList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.campaignImagesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.campaignImagesList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.campaignImagesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.campaignImagesList.Size = new System.Drawing.Size(557, 223);
            this.campaignImagesList.TabIndex = 14;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Image.DataPropertyName = "Bytes";
            this.Image.HeaderText = "Imagen";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Descripcion";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duracion";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // Order
            // 
            this.Order.DataPropertyName = "Order";
            this.Order.HeaderText = "Orden";
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            // 
            // CampaignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 547);
            this.Controls.Add(this.campaignImagesList);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.initTimePicker);
            this.Controls.Add(this.initTimeLabel);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.initDatePicker);
            this.Controls.Add(this.initDateLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "CampaignForm";
            this.Text = "Formulario de camapaña";
            this.Load += new System.EventHandler(this.CampaignForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.campaignImagesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroLabel descriptionLabel;
        private MetroFramework.Controls.MetroTextBox descriptionTextBox;
        private MetroFramework.Controls.MetroLabel initDateLabel;
        private MetroFramework.Controls.MetroDateTime initDatePicker;
        private MetroFramework.Controls.MetroLabel endDateLabel;
        private MetroFramework.Controls.MetroDateTime endDatePicker;
        private MetroFramework.Controls.MetroLabel initTimeLabel;
        private MetroFramework.Controls.MetroDateTime initTimePicker;
        private MetroFramework.Controls.MetroDateTime endTimePicker;
        private MetroFramework.Controls.MetroLabel endTimeLabel;
        private System.Windows.Forms.ImageList campignImages;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid campaignImagesList;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
    }
}