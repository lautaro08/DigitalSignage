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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.initDateLabel = new MetroFramework.Controls.MetroLabel();
            this.initDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.endDateLabel = new MetroFramework.Controls.MetroLabel();
            this.endDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.imagesGridView = new MetroFramework.Controls.MetroGrid();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initTimeLabel = new MetroFramework.Controls.MetroLabel();
            this.initTimeHours = new MetroFramework.Controls.MetroComboBox();
            this.initTimeMinutes = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.endTimeMinutes = new MetroFramework.Controls.MetroComboBox();
            this.endTimeHours = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.addImageButton = new MetroFramework.Controls.MetroButton();
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.deleteImageButton = new MetroFramework.Controls.MetroButton();
            this.modifyImageButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imagesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
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
            this.descriptionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.descriptionTextBox_Validating);
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
            this.initDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.initDatePicker_Validating);
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(149, 208);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(80, 19);
            this.endDateLabel.TabIndex = 6;
            this.endDateLabel.Text = "Fecha de fin";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(152, 230);
            this.endDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(96, 29);
            this.endDatePicker.TabIndex = 7;
            this.endDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.endDatePicker_Validating);
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
            // imagesGridView
            // 
            this.imagesGridView.AllowUserToAddRows = false;
            this.imagesGridView.AllowUserToDeleteRows = false;
            this.imagesGridView.AllowUserToResizeRows = false;
            this.imagesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagesGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imagesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imagesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.imagesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.imagesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.imagesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imagesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.imagesGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.imagesGridView.EnableHeadersVisualStyles = false;
            this.imagesGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.imagesGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imagesGridView.Location = new System.Drawing.Point(359, 99);
            this.imagesGridView.MultiSelect = false;
            this.imagesGridView.Name = "imagesGridView";
            this.imagesGridView.ReadOnly = true;
            this.imagesGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.imagesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.imagesGridView.RowHeadersVisible = false;
            this.imagesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            this.imagesGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.imagesGridView.RowTemplate.Height = 150;
            this.imagesGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imagesGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.imagesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.imagesGridView.Size = new System.Drawing.Size(557, 301);
            this.imagesGridView.TabIndex = 14;
            this.imagesGridView.Validating += new System.ComponentModel.CancelEventHandler(this.imagesGridView_Validating);
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Image.DataPropertyName = "Bytes";
            this.Image.FillWeight = 1F;
            this.Image.HeaderText = "Imagen";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Image.MinimumWidth = 250;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 1F;
            this.Description.HeaderText = "Descripcion";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Duration.DataPropertyName = "Duration";
            this.Duration.FillWeight = 1F;
            this.Duration.HeaderText = "Duracion";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // Order
            // 
            this.Order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Order.DataPropertyName = "Order";
            this.Order.FillWeight = 1F;
            this.Order.HeaderText = "Orden";
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            // 
            // initTimeLabel
            // 
            this.initTimeLabel.AutoSize = true;
            this.initTimeLabel.Location = new System.Drawing.Point(28, 274);
            this.initTimeLabel.Name = "initTimeLabel";
            this.initTimeLabel.Size = new System.Drawing.Size(91, 19);
            this.initTimeLabel.TabIndex = 8;
            this.initTimeLabel.Text = "Hora de inicio";
            // 
            // initTimeHours
            // 
            this.initTimeHours.FormattingEnabled = true;
            this.initTimeHours.ItemHeight = 23;
            this.initTimeHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.initTimeHours.Location = new System.Drawing.Point(23, 296);
            this.initTimeHours.Name = "initTimeHours";
            this.initTimeHours.Size = new System.Drawing.Size(77, 29);
            this.initTimeHours.TabIndex = 15;
            this.initTimeHours.UseSelectable = true;
            this.initTimeHours.SelectedValueChanged += new System.EventHandler(this.initTimeHours_SelectedValueChanged);
            this.initTimeHours.Validating += new System.ComponentModel.CancelEventHandler(this.initTimeHours_Validating);
            // 
            // initTimeMinutes
            // 
            this.initTimeMinutes.Enabled = false;
            this.initTimeMinutes.FormattingEnabled = true;
            this.initTimeMinutes.ItemHeight = 23;
            this.initTimeMinutes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.initTimeMinutes.Location = new System.Drawing.Point(152, 296);
            this.initTimeMinutes.Name = "initTimeMinutes";
            this.initTimeMinutes.Size = new System.Drawing.Size(77, 29);
            this.initTimeMinutes.TabIndex = 16;
            this.initTimeMinutes.UseSelectable = true;
            this.initTimeMinutes.SelectedValueChanged += new System.EventHandler(this.initTimeMinutes_SelectedValueChanged);
            this.initTimeMinutes.Validating += new System.ComponentModel.CancelEventHandler(this.initTimeMinutes_Validating);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(120, 306);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(12, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = ":";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(120, 371);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(12, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = ":";
            // 
            // endTimeMinutes
            // 
            this.endTimeMinutes.Enabled = false;
            this.endTimeMinutes.FormattingEnabled = true;
            this.endTimeMinutes.ItemHeight = 23;
            this.endTimeMinutes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.endTimeMinutes.Location = new System.Drawing.Point(152, 361);
            this.endTimeMinutes.Name = "endTimeMinutes";
            this.endTimeMinutes.Size = new System.Drawing.Size(77, 29);
            this.endTimeMinutes.TabIndex = 20;
            this.endTimeMinutes.UseSelectable = true;
            this.endTimeMinutes.Validating += new System.ComponentModel.CancelEventHandler(this.endTimeMinutes_Validating);
            // 
            // endTimeHours
            // 
            this.endTimeHours.Enabled = false;
            this.endTimeHours.FormattingEnabled = true;
            this.endTimeHours.ItemHeight = 23;
            this.endTimeHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.endTimeHours.Location = new System.Drawing.Point(23, 361);
            this.endTimeHours.Name = "endTimeHours";
            this.endTimeHours.Size = new System.Drawing.Size(77, 29);
            this.endTimeHours.TabIndex = 19;
            this.endTimeHours.UseSelectable = true;
            this.endTimeHours.SelectedValueChanged += new System.EventHandler(this.endTimeHours_SelectedValueChanged);
            this.endTimeHours.Validating += new System.ComponentModel.CancelEventHandler(this.endTimeHours_Validating);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 339);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Hora de fin";
            // 
            // addImageButton
            // 
            this.addImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addImageButton.BackColor = System.Drawing.Color.LightGreen;
            this.addImageButton.Location = new System.Drawing.Point(735, 406);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(181, 23);
            this.addImageButton.Style = MetroFramework.MetroColorStyle.Green;
            this.addImageButton.TabIndex = 22;
            this.addImageButton.Text = "agregar imagen";
            this.addImageButton.UseSelectable = true;
            this.addImageButton.UseStyleColors = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitButton.Location = new System.Drawing.Point(278, 489);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(146, 23);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "salir";
            this.exitButton.UseSelectable = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(483, 489);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(146, 23);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "guardar cambios";
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteImageButton
            // 
            this.deleteImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteImageButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteImageButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteImageButton.Location = new System.Drawing.Point(359, 406);
            this.deleteImageButton.Name = "deleteImageButton";
            this.deleteImageButton.Size = new System.Drawing.Size(191, 23);
            this.deleteImageButton.Style = MetroFramework.MetroColorStyle.Red;
            this.deleteImageButton.TabIndex = 25;
            this.deleteImageButton.Text = "eliminar imagen";
            this.deleteImageButton.UseSelectable = true;
            this.deleteImageButton.UseStyleColors = true;
            this.deleteImageButton.Click += new System.EventHandler(this.deleteImageButton_Click);
            // 
            // modifyImageButton
            // 
            this.modifyImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyImageButton.Location = new System.Drawing.Point(549, 406);
            this.modifyImageButton.Name = "modifyImageButton";
            this.modifyImageButton.Size = new System.Drawing.Size(187, 23);
            this.modifyImageButton.TabIndex = 26;
            this.modifyImageButton.Text = "modificar imagen";
            this.modifyImageButton.UseSelectable = true;
            this.modifyImageButton.Click += new System.EventHandler(this.modifyImageButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CampaignForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(939, 547);
            this.Controls.Add(this.modifyImageButton);
            this.Controls.Add(this.deleteImageButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.endTimeMinutes);
            this.Controls.Add(this.endTimeHours);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.initTimeMinutes);
            this.Controls.Add(this.initTimeHours);
            this.Controls.Add(this.imagesGridView);
            this.Controls.Add(this.metroLabel1);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.imagesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid imagesGridView;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private MetroFramework.Controls.MetroLabel initTimeLabel;
        private MetroFramework.Controls.MetroComboBox initTimeHours;
        private MetroFramework.Controls.MetroComboBox initTimeMinutes;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox endTimeMinutes;
        private MetroFramework.Controls.MetroComboBox endTimeHours;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton addImageButton;
        private MetroFramework.Controls.MetroButton exitButton;
        private MetroFramework.Controls.MetroButton saveButton;
        private MetroFramework.Controls.MetroButton deleteImageButton;
        private MetroFramework.Controls.MetroButton modifyImageButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}