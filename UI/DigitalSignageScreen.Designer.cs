namespace UI
{
    partial class DigitalSignageScreen
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
            this.campaignImage = new System.Windows.Forms.PictureBox();
            this.bannerText = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.campaignImage)).BeginInit();
            this.SuspendLayout();
            // 
            // campaignImage
            // 
            this.campaignImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.campaignImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.campaignImage.Location = new System.Drawing.Point(0, 0);
            this.campaignImage.Name = "campaignImage";
            this.campaignImage.Size = new System.Drawing.Size(835, 450);
            this.campaignImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.campaignImage.TabIndex = 0;
            this.campaignImage.TabStop = false;
            // 
            // bannerText
            // 
            this.bannerText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bannerText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.bannerText.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.bannerText.Location = new System.Drawing.Point(0, 453);
            this.bannerText.Name = "bannerText";
            this.bannerText.Size = new System.Drawing.Size(835, 51);
            this.bannerText.TabIndex = 7;
            this.bannerText.Text = "Admin campañas";
            this.bannerText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DigitalSignageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 504);
            this.Controls.Add(this.bannerText);
            this.Controls.Add(this.campaignImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DigitalSignageScreen";
            this.Text = "DigitalSignageScreen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DigitalSignageScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.campaignImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox campaignImage;
        private MetroFramework.Controls.MetroLabel bannerText;
        private System.Windows.Forms.Timer timer1;
    }
}