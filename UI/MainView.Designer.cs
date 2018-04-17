namespace UI
{
    partial class MainView
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
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bannerAdminButton = new MetroFramework.Controls.MetroButton();
            this.bannerAdminLabel = new MetroFramework.Controls.MetroLabel();
            this.openOperativeButton = new MetroFramework.Controls.MetroButton();
            this.openOperativeLabel = new MetroFramework.Controls.MetroLabel();
            this.campaignAdminButton = new MetroFramework.Controls.MetroButton();
            this.campaignAdminLabel = new MetroFramework.Controls.MetroLabel();
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.exitLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.openRssSourceAdmin = new MetroFramework.Controls.MetroButton();
            this.lightThemeButton = new System.Windows.Forms.Button();
            this.darkThemeButton = new System.Windows.Forms.Button();
            this.helpButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bannerAdminButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.bannerAdminLabel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.openOperativeButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.openOperativeLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.campaignAdminButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.campaignAdminLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.exitButton, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.exitLabel, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.openRssSourceAdmin, 4, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1315, 370);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // bannerAdminButton
            // 
            this.bannerAdminButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bannerAdminButton.BackgroundImage = global::UI.Properties.Resources.fonts;
            this.bannerAdminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bannerAdminButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.bannerAdminButton.Location = new System.Drawing.Point(542, 71);
            this.bannerAdminButton.Margin = new System.Windows.Forms.Padding(10);
            this.bannerAdminButton.Name = "bannerAdminButton";
            this.bannerAdminButton.Size = new System.Drawing.Size(230, 234);
            this.bannerAdminButton.TabIndex = 4;
            this.bannerAdminButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bannerAdminButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bannerAdminButton.UseSelectable = true;
            this.bannerAdminButton.Click += new System.EventHandler(this.openBannerAdmin);
            // 
            // bannerAdminLabel
            // 
            this.bannerAdminLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bannerAdminLabel.AutoSize = true;
            this.bannerAdminLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.bannerAdminLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.bannerAdminLabel.Location = new System.Drawing.Point(535, 322);
            this.bannerAdminLabel.Name = "bannerAdminLabel";
            this.bannerAdminLabel.Size = new System.Drawing.Size(244, 25);
            this.bannerAdminLabel.TabIndex = 7;
            this.bannerAdminLabel.Text = "Admin banners";
            this.bannerAdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openOperativeButton
            // 
            this.openOperativeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openOperativeButton.BackgroundImage = global::UI.Properties.Resources.monitor__1_;
            this.openOperativeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openOperativeButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.openOperativeButton.Location = new System.Drawing.Point(42, 71);
            this.openOperativeButton.Margin = new System.Windows.Forms.Padding(10);
            this.openOperativeButton.Name = "openOperativeButton";
            this.openOperativeButton.Size = new System.Drawing.Size(230, 234);
            this.openOperativeButton.TabIndex = 1;
            this.openOperativeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openOperativeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.openOperativeButton.UseSelectable = true;
            this.openOperativeButton.Click += new System.EventHandler(this.openOperativeButton_Click);
            // 
            // openOperativeLabel
            // 
            this.openOperativeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.openOperativeLabel.AutoSize = true;
            this.openOperativeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.openOperativeLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.openOperativeLabel.Location = new System.Drawing.Point(35, 322);
            this.openOperativeLabel.Name = "openOperativeLabel";
            this.openOperativeLabel.Size = new System.Drawing.Size(244, 25);
            this.openOperativeLabel.TabIndex = 2;
            this.openOperativeLabel.Text = "Abrir ventana publicitaria";
            this.openOperativeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campaignAdminButton
            // 
            this.campaignAdminButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.campaignAdminButton.BackgroundImage = global::UI.Properties.Resources.pictures__1_;
            this.campaignAdminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.campaignAdminButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.campaignAdminButton.Location = new System.Drawing.Point(292, 71);
            this.campaignAdminButton.Margin = new System.Windows.Forms.Padding(10);
            this.campaignAdminButton.Name = "campaignAdminButton";
            this.campaignAdminButton.Size = new System.Drawing.Size(230, 234);
            this.campaignAdminButton.TabIndex = 3;
            this.campaignAdminButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.campaignAdminButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.campaignAdminButton.UseSelectable = true;
            this.campaignAdminButton.Click += new System.EventHandler(this.openCampaignAdmin);
            // 
            // campaignAdminLabel
            // 
            this.campaignAdminLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.campaignAdminLabel.AutoSize = true;
            this.campaignAdminLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.campaignAdminLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.campaignAdminLabel.Location = new System.Drawing.Point(285, 322);
            this.campaignAdminLabel.Name = "campaignAdminLabel";
            this.campaignAdminLabel.Size = new System.Drawing.Size(244, 25);
            this.campaignAdminLabel.TabIndex = 6;
            this.campaignAdminLabel.Text = "Admin campañas";
            this.campaignAdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackgroundImage = global::UI.Properties.Resources.exit__1_;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.exitButton.Location = new System.Drawing.Point(1042, 71);
            this.exitButton.Margin = new System.Windows.Forms.Padding(10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(230, 234);
            this.exitButton.TabIndex = 5;
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.exitButton.UseSelectable = true;
            this.exitButton.Click += new System.EventHandler(this.exit);
            // 
            // exitLabel
            // 
            this.exitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.exitLabel.AutoSize = true;
            this.exitLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.exitLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.exitLabel.Location = new System.Drawing.Point(1035, 322);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(244, 25);
            this.exitLabel.TabIndex = 8;
            this.exitLabel.Text = "Salir";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(785, 322);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(244, 25);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Admin fuentes RSS";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openRssSourceAdmin
            // 
            this.openRssSourceAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openRssSourceAdmin.BackgroundImage = global::UI.Properties.Resources.rss;
            this.openRssSourceAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openRssSourceAdmin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.openRssSourceAdmin.Location = new System.Drawing.Point(792, 71);
            this.openRssSourceAdmin.Margin = new System.Windows.Forms.Padding(10);
            this.openRssSourceAdmin.Name = "openRssSourceAdmin";
            this.openRssSourceAdmin.Size = new System.Drawing.Size(230, 234);
            this.openRssSourceAdmin.TabIndex = 10;
            this.openRssSourceAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openRssSourceAdmin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.openRssSourceAdmin.UseSelectable = true;
            this.openRssSourceAdmin.Click += new System.EventHandler(this.openRssSourceAdmin_Click);
            // 
            // lightThemeButton
            // 
            this.lightThemeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lightThemeButton.BackColor = System.Drawing.Color.Transparent;
            this.lightThemeButton.BackgroundImage = global::UI.Properties.Resources.sun__1_;
            this.lightThemeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lightThemeButton.FlatAppearance.BorderSize = 0;
            this.lightThemeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lightThemeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lightThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightThemeButton.Location = new System.Drawing.Point(63, 439);
            this.lightThemeButton.Name = "lightThemeButton";
            this.lightThemeButton.Size = new System.Drawing.Size(50, 50);
            this.lightThemeButton.TabIndex = 5;
            this.lightThemeButton.UseMnemonic = false;
            this.lightThemeButton.UseVisualStyleBackColor = false;
            this.lightThemeButton.Click += new System.EventHandler(this.setLightTheme);
            // 
            // darkThemeButton
            // 
            this.darkThemeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.darkThemeButton.BackColor = System.Drawing.Color.Transparent;
            this.darkThemeButton.BackgroundImage = global::UI.Properties.Resources.moon__1_;
            this.darkThemeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.darkThemeButton.FlatAppearance.BorderSize = 0;
            this.darkThemeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.darkThemeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.darkThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkThemeButton.Location = new System.Drawing.Point(7, 439);
            this.darkThemeButton.Name = "darkThemeButton";
            this.darkThemeButton.Size = new System.Drawing.Size(50, 50);
            this.darkThemeButton.TabIndex = 4;
            this.darkThemeButton.UseMnemonic = false;
            this.darkThemeButton.UseVisualStyleBackColor = false;
            this.darkThemeButton.Click += new System.EventHandler(this.setDarkTheme);
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.Location = new System.Drawing.Point(1235, 452);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(103, 37);
            this.helpButton.TabIndex = 6;
            this.helpButton.Text = "NEED HELP ?";
            this.helpButton.UseSelectable = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 497);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.lightThemeButton);
            this.Controls.Add(this.darkThemeButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainView";
            this.Text = "Digital Signage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroButton openOperativeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel openOperativeLabel;
        private MetroFramework.Controls.MetroButton bannerAdminButton;
        private MetroFramework.Controls.MetroButton exitButton;
        private MetroFramework.Controls.MetroLabel bannerAdminLabel;
        private MetroFramework.Controls.MetroLabel exitLabel;
        private MetroFramework.Controls.MetroButton campaignAdminButton;
        private MetroFramework.Controls.MetroLabel campaignAdminLabel;
        private System.Windows.Forms.Button darkThemeButton;
        private System.Windows.Forms.Button lightThemeButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton openRssSourceAdmin;
        private MetroFramework.Controls.MetroButton helpButton;
    }
}