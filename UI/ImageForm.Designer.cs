namespace UI
{
    partial class ImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageForm));
            this.picureBox = new System.Windows.Forms.PictureBox();
            this.openImageButton = new MetroFramework.Controls.MetroButton();
            this.selectedImagePath = new System.Windows.Forms.Label();
            this.saveImageButton = new MetroFramework.Controls.MetroButton();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.orderComboBox = new MetroFramework.Controls.MetroComboBox();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.durationTextBox = new MetroFramework.Controls.MetroTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // picureBox
            // 
            this.picureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("picureBox.InitialImage")));
            this.picureBox.Location = new System.Drawing.Point(32, 102);
            this.picureBox.Name = "picureBox";
            this.picureBox.Size = new System.Drawing.Size(456, 226);
            this.picureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picureBox.TabIndex = 0;
            this.picureBox.TabStop = false;
            this.picureBox.Validating += new System.ComponentModel.CancelEventHandler(this.picureBox_Validating);
            // 
            // openImageButton
            // 
            this.openImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openImageButton.Location = new System.Drawing.Point(32, 73);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(456, 23);
            this.openImageButton.TabIndex = 1;
            this.openImageButton.Text = "seleccionar imagen";
            this.openImageButton.UseSelectable = true;
            this.openImageButton.Click += new System.EventHandler(this.openImageButton_Click);
            // 
            // selectedImagePath
            // 
            this.selectedImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectedImagePath.AutoSize = true;
            this.selectedImagePath.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.selectedImagePath.Location = new System.Drawing.Point(29, 331);
            this.selectedImagePath.Name = "selectedImagePath";
            this.selectedImagePath.Size = new System.Drawing.Size(152, 13);
            this.selectedImagePath.TabIndex = 2;
            this.selectedImagePath.Text = "ruta del archivo seleccionado..";
            // 
            // saveImageButton
            // 
            this.saveImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveImageButton.Location = new System.Drawing.Point(158, 482);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(217, 42);
            this.saveImageButton.TabIndex = 3;
            this.saveImageButton.Text = "guardar imagen";
            this.saveImageButton.UseSelectable = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.descriptionTextBox.CustomButton.Image = null;
            this.descriptionTextBox.CustomButton.Location = new System.Drawing.Point(434, 1);
            this.descriptionTextBox.CustomButton.Name = "";
            this.descriptionTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.descriptionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionTextBox.CustomButton.TabIndex = 1;
            this.descriptionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionTextBox.CustomButton.UseSelectable = true;
            this.descriptionTextBox.CustomButton.Visible = false;
            this.descriptionTextBox.Lines = new string[0];
            this.descriptionTextBox.Location = new System.Drawing.Point(32, 374);
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.SelectionLength = 0;
            this.descriptionTextBox.SelectionStart = 0;
            this.descriptionTextBox.ShortcutsEnabled = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(456, 23);
            this.descriptionTextBox.TabIndex = 4;
            this.descriptionTextBox.UseSelectable = true;
            this.descriptionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.descriptionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.descriptionTextBox_Validating);
            // 
            // orderComboBox
            // 
            this.orderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.ItemHeight = 23;
            this.orderComboBox.Location = new System.Drawing.Point(32, 428);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(121, 29);
            this.orderComboBox.TabIndex = 8;
            this.orderComboBox.UseSelectable = true;
            this.orderComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.orderComboBox_Validating);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(32, 352);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(76, 19);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Descripcion";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 406);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Orden de aparicion";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(181, 406);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(196, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Duracion en pantalla (segundos)";
            // 
            // durationTextBox
            // 
            this.durationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.durationTextBox.CustomButton.Image = null;
            this.durationTextBox.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.durationTextBox.CustomButton.Name = "";
            this.durationTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.durationTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.durationTextBox.CustomButton.TabIndex = 1;
            this.durationTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.durationTextBox.CustomButton.UseSelectable = true;
            this.durationTextBox.CustomButton.Visible = false;
            this.durationTextBox.Lines = new string[0];
            this.durationTextBox.Location = new System.Drawing.Point(181, 434);
            this.durationTextBox.MaxLength = 32767;
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.PasswordChar = '\0';
            this.durationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.durationTextBox.SelectedText = "";
            this.durationTextBox.SelectionLength = 0;
            this.durationTextBox.SelectionStart = 0;
            this.durationTextBox.ShortcutsEnabled = true;
            this.durationTextBox.Size = new System.Drawing.Size(119, 23);
            this.durationTextBox.TabIndex = 13;
            this.durationTextBox.UseSelectable = true;
            this.durationTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.durationTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.durationTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.durationTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(524, 547);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.orderComboBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.selectedImagePath);
            this.Controls.Add(this.openImageButton);
            this.Controls.Add(this.picureBox);
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            ((System.ComponentModel.ISupportInitialize)(this.picureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picureBox;
        private MetroFramework.Controls.MetroButton openImageButton;
        private System.Windows.Forms.Label selectedImagePath;
        private MetroFramework.Controls.MetroButton saveImageButton;
        private MetroFramework.Controls.MetroTextBox descriptionTextBox;
        private MetroFramework.Controls.MetroComboBox orderComboBox;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox durationTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}