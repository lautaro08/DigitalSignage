﻿namespace UI
{
    partial class BannerForm
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.endTimeMinutes = new MetroFramework.Controls.MetroComboBox();
            this.endTimeHours = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.initTimeMinutes = new MetroFramework.Controls.MetroComboBox();
            this.initTimeHours = new MetroFramework.Controls.MetroComboBox();
            this.initTimeLabel = new MetroFramework.Controls.MetroLabel();
            this.endDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.endDateLabel = new MetroFramework.Controls.MetroLabel();
            this.initDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.initDateLabel = new MetroFramework.Controls.MetroLabel();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(120, 374);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(12, 19);
            this.metroLabel3.TabIndex = 37;
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
            this.endTimeMinutes.Location = new System.Drawing.Point(152, 364);
            this.endTimeMinutes.Name = "endTimeMinutes";
            this.endTimeMinutes.Size = new System.Drawing.Size(77, 29);
            this.endTimeMinutes.TabIndex = 36;
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
            this.endTimeHours.Location = new System.Drawing.Point(23, 364);
            this.endTimeHours.Name = "endTimeHours";
            this.endTimeHours.Size = new System.Drawing.Size(77, 29);
            this.endTimeHours.TabIndex = 35;
            this.endTimeHours.UseSelectable = true;
            this.endTimeHours.SelectedValueChanged += new System.EventHandler(this.endTimeHours_SelectedValueChanged);
            this.endTimeHours.Validating += new System.ComponentModel.CancelEventHandler(this.endTimeHours_Validating);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 342);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Hora de fin";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(120, 309);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(12, 19);
            this.metroLabel2.TabIndex = 33;
            this.metroLabel2.Text = ":";
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
            this.initTimeMinutes.Location = new System.Drawing.Point(152, 299);
            this.initTimeMinutes.Name = "initTimeMinutes";
            this.initTimeMinutes.Size = new System.Drawing.Size(77, 29);
            this.initTimeMinutes.TabIndex = 32;
            this.initTimeMinutes.UseSelectable = true;
            this.initTimeMinutes.SelectedValueChanged += new System.EventHandler(this.initTimeMinutes_SelectedValueChanged);
            this.initTimeMinutes.Validating += new System.ComponentModel.CancelEventHandler(this.initTimeMinutes_Validating);
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
            this.initTimeHours.Location = new System.Drawing.Point(23, 299);
            this.initTimeHours.Name = "initTimeHours";
            this.initTimeHours.Size = new System.Drawing.Size(77, 29);
            this.initTimeHours.TabIndex = 31;
            this.initTimeHours.UseSelectable = true;
            this.initTimeHours.SelectedValueChanged += new System.EventHandler(this.initTimeHours_SelectedValueChanged);
            this.initTimeHours.Validating += new System.ComponentModel.CancelEventHandler(this.initTimeHours_Validating);
            // 
            // initTimeLabel
            // 
            this.initTimeLabel.AutoSize = true;
            this.initTimeLabel.Location = new System.Drawing.Point(28, 277);
            this.initTimeLabel.Name = "initTimeLabel";
            this.initTimeLabel.Size = new System.Drawing.Size(91, 19);
            this.initTimeLabel.TabIndex = 30;
            this.initTimeLabel.Text = "Hora de inicio";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(152, 233);
            this.endDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(96, 29);
            this.endDatePicker.TabIndex = 29;
            this.endDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.endDatePicker_Validating);
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(149, 211);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(80, 19);
            this.endDateLabel.TabIndex = 28;
            this.endDateLabel.Text = "Fecha de fin";
            // 
            // initDatePicker
            // 
            this.initDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.initDatePicker.Location = new System.Drawing.Point(23, 233);
            this.initDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.initDatePicker.Name = "initDatePicker";
            this.initDatePicker.Size = new System.Drawing.Size(96, 29);
            this.initDatePicker.TabIndex = 27;
            this.initDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.initDatePicker_Validating);
            // 
            // initDateLabel
            // 
            this.initDateLabel.AutoSize = true;
            this.initDateLabel.Location = new System.Drawing.Point(23, 211);
            this.initDateLabel.Name = "initDateLabel";
            this.initDateLabel.Size = new System.Drawing.Size(96, 19);
            this.initDateLabel.TabIndex = 26;
            this.initDateLabel.Text = "Fecha de inicio";
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
            this.descriptionTextBox.Location = new System.Drawing.Point(23, 159);
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
            this.descriptionTextBox.TabIndex = 25;
            this.descriptionTextBox.UseSelectable = true;
            this.descriptionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.descriptionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.descriptionTextBox_Validating);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Enabled = false;
            this.descriptionLabel.Location = new System.Drawing.Point(23, 137);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(76, 19);
            this.descriptionLabel.TabIndex = 24;
            this.descriptionLabel.Text = "Descripcion";
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
            this.nameTextBox.Location = new System.Drawing.Point(23, 102);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.ShortcutsEnabled = true;
            this.nameTextBox.Size = new System.Drawing.Size(282, 23);
            this.nameTextBox.TabIndex = 23;
            this.nameTextBox.UseSelectable = true;
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(23, 80);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 19);
            this.nameLabel.TabIndex = 22;
            this.nameLabel.Text = "Nombre";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(329, 459);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(146, 49);
            this.saveButton.TabIndex = 39;
            this.saveButton.Text = "guardar cambios";
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitButton.Location = new System.Drawing.Point(124, 459);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(146, 49);
            this.exitButton.TabIndex = 38;
            this.exitButton.Text = "salir";
            this.exitButton.UseSelectable = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(591, 531);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.endTimeMinutes);
            this.Controls.Add(this.endTimeHours);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.initTimeMinutes);
            this.Controls.Add(this.initTimeHours);
            this.Controls.Add(this.initTimeLabel);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.initDatePicker);
            this.Controls.Add(this.initDateLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "BannerForm";
            this.Text = "BannerForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox endTimeMinutes;
        private MetroFramework.Controls.MetroComboBox endTimeHours;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox initTimeMinutes;
        private MetroFramework.Controls.MetroComboBox initTimeHours;
        private MetroFramework.Controls.MetroLabel initTimeLabel;
        private MetroFramework.Controls.MetroDateTime endDatePicker;
        private MetroFramework.Controls.MetroLabel endDateLabel;
        private MetroFramework.Controls.MetroDateTime initDatePicker;
        private MetroFramework.Controls.MetroLabel initDateLabel;
        private MetroFramework.Controls.MetroTextBox descriptionTextBox;
        private MetroFramework.Controls.MetroLabel descriptionLabel;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroButton saveButton;
        private MetroFramework.Controls.MetroButton exitButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}