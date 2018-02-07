namespace UI
{
    partial class Admin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signageButton = new System.Windows.Forms.Button();
            this.campaignAdminButton = new System.Windows.Forms.Button();
            this.bannerAdminButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // signageButton
            // 
            this.signageButton.BackColor = System.Drawing.Color.Transparent;
            this.signageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signageButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.signageButton.FlatAppearance.BorderSize = 20;
            this.signageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signageButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signageButton.ForeColor = System.Drawing.Color.White;
            this.signageButton.Location = new System.Drawing.Point(273, 114);
            this.signageButton.Name = "signageButton";
            this.signageButton.Size = new System.Drawing.Size(368, 53);
            this.signageButton.TabIndex = 1;
            this.signageButton.Text = "VENTANA PUBLICITARIA";
            this.signageButton.UseVisualStyleBackColor = false;
            this.signageButton.MouseEnter += new System.EventHandler(this.styleMouseEnter);
            this.signageButton.MouseLeave += new System.EventHandler(this.styleMouseLeave);
            // 
            // campaignAdminButton
            // 
            this.campaignAdminButton.BackColor = System.Drawing.Color.Transparent;
            this.campaignAdminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.campaignAdminButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.campaignAdminButton.FlatAppearance.BorderSize = 20;
            this.campaignAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.campaignAdminButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campaignAdminButton.ForeColor = System.Drawing.Color.White;
            this.campaignAdminButton.Location = new System.Drawing.Point(273, 191);
            this.campaignAdminButton.Name = "campaignAdminButton";
            this.campaignAdminButton.Size = new System.Drawing.Size(368, 53);
            this.campaignAdminButton.TabIndex = 2;
            this.campaignAdminButton.Text = "ADMINISTRAR CAMPAÑAS";
            this.campaignAdminButton.UseVisualStyleBackColor = false;
            this.campaignAdminButton.MouseEnter += new System.EventHandler(this.styleMouseEnter);
            this.campaignAdminButton.MouseLeave += new System.EventHandler(this.styleMouseLeave);
            // 
            // bannerAdminButton
            // 
            this.bannerAdminButton.BackColor = System.Drawing.Color.Transparent;
            this.bannerAdminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bannerAdminButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bannerAdminButton.FlatAppearance.BorderSize = 20;
            this.bannerAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bannerAdminButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerAdminButton.ForeColor = System.Drawing.Color.White;
            this.bannerAdminButton.Location = new System.Drawing.Point(273, 265);
            this.bannerAdminButton.Name = "bannerAdminButton";
            this.bannerAdminButton.Size = new System.Drawing.Size(368, 53);
            this.bannerAdminButton.TabIndex = 3;
            this.bannerAdminButton.Text = "ADMINISTRAR BANNERS";
            this.bannerAdminButton.UseVisualStyleBackColor = false;
            this.bannerAdminButton.MouseEnter += new System.EventHandler(this.styleMouseEnter);
            this.bannerAdminButton.MouseLeave += new System.EventHandler(this.styleMouseLeave);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderSize = 20;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(273, 339);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(368, 53);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "SALIR";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.styleMouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.styleMouseLeave);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.digital_signage_background;
            this.ClientSize = new System.Drawing.Size(911, 503);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.bannerAdminButton);
            this.Controls.Add(this.campaignAdminButton);
            this.Controls.Add(this.signageButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button signageButton;
        private System.Windows.Forms.Button campaignAdminButton;
        private System.Windows.Forms.Button bannerAdminButton;
        private System.Windows.Forms.Button exitButton;
    }
}

